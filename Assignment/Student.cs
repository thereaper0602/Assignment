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
        private Book book;
        private int countBook;

        public Student(){}

        public Student(string id, string name, string className, Book book, int quanti)
        {
            this.id = id;
            this.name = name;
            this.className = className;
            this.book = book;
            this.countBook = quanti;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string ClassName { get => className; set => className = value; }
        public Book Books { get => book; set => book = value; }
        public int Quanti { get => countBook; set => countBook = value; }
    }
}
