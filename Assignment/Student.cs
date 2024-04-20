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

        public Student(){}

        public Student(string id, string name, string className, Book book)
        {
            this.id = id;
            this.name = name;
            this.className = className;
            this.book = book;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string ClassName { get => className; set => className = value; }
        public Book Books { get => book; set => book = value; }
    }
}
