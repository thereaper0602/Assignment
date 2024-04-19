using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class Student
    {
        private string id;
        private string name;
        private string className;
        private List<Book> books;

        public Student(){}

        public Student(string id, string name, string className,List<Book> books)
        {
            this.id = id;
            this.name = name;
            this.className = className;
            this.books = books;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string ClassName { get => className; set => className = value; }
        public List<Book> Books { get => books; set => books = value; }
        public void addBook(Book book) { this.books.Add(book); }
        public void removeBook(Book book) {  books.Remove(book); }
    }
}
