using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization;

namespace Assignment
{
    public class ManageBook
    {
        private List<Book> listBook;
        public List<Book> Books
        {
            get { return this.listBook; }
            set { this.listBook = value; }
        }

        public ManageBook()
        {
            listBook = new List<Book>();
        }

        public void AddBook(Book b)
        {
            listBook.Add(b);
        }

        public void UpdateBook(int index,Book updated)
        {
            if(index >= 0 && index < listBook.Count)
            {
                listBook[index] = updated;
            }
        }

        public void SaveToFile(string fileName)
        {
            XmlSerializer obj = new XmlSerializer(typeof(List<Book>));
            using (StreamWriter w = new StreamWriter(fileName))
            {
                obj.Serialize(w, this.listBook);
            }
        }

        public List<Book> ReadFromFile(string fileName)
        {
            XmlSerializer obj = new XmlSerializer ( typeof(List<Book>));
            using (StreamReader w = new StreamReader(fileName)) 
            {
                return (List<Book>)obj.Deserialize(w);
            }
        }


        public void RemoveBook(Book b)
        {
            listBook.Remove(b);
        }

        public List<Book> FindBook(string id = null,string title = null,string category = null,bool? descending = null)
        {
            var query = listBook.AsQueryable();

            // Áp dụng các bộ lọc nếu tham số không null
            if (!string.IsNullOrEmpty(id))
            {
                query = query.Where(b => b.Id.Equals(id, StringComparison.OrdinalIgnoreCase));
            }
            if (!string.IsNullOrEmpty(title))
            {
                query = query.Where(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            }
            if (!string.IsNullOrEmpty(category))
            {
                query = query.Where(b => b.Category.Equals(category, StringComparison.OrdinalIgnoreCase));
            }

            // Sắp xếp kết quả nếu được yêu cầu
            if (descending.HasValue)
            {
                query = descending.Value ? query.OrderByDescending(b => b.Date) : query.OrderBy(b => b.Date);
            }
            return query.ToList();
        }
    }
}
