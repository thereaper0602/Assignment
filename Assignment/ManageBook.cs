using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Xml.Serialization;

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
        // Hàm lưu thông tin vô file xml
        public void SaveToFile(string fileName)
        {
            XmlSerializer obj = new XmlSerializer(typeof(List<Book>));
            using (StreamWriter w = new StreamWriter(fileName))
            {
                obj.Serialize(w, this.listBook);
            }
        }

        // Đọc dữ liệu từ file XML và trả về danh sách các đối tượng
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

        // Kiếm sách dựa trên các thông tin
        public List<Book> FindBook(string id = null,string title = null,string category = null,bool? descending = null)
        {
            /*
             * listBook.AsQueryable() : chuyển đổi 1 danh sách thành 1 đối tượng "IQeryable" -> Cho phép thực hiện truy vấn LINQ trên danh sách đó
             */
            var query = listBook.AsQueryable();

            // Áp dụng các bộ lọc nếu tham số không null
            if (!string.IsNullOrEmpty(id))
            {
                query = query.Where(b => b.Id.Equals(id, StringComparison.OrdinalIgnoreCase));
            }
            if (!string.IsNullOrEmpty(title))
            {
                query = query.Where(b => b.Title.Contains(title));
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

        // cập nhật lại ID cho sách sau khi xóa
        public void updateID()
        {
            int count = 1;
            foreach(Book b in this.Books)
            {
                b.Id = "ISBN" + DateTime.Now.Year.ToString() + (count++).ToString("D5");
            }
        }
    }
}
