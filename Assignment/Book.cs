using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Book
    {
        private static int count = 0;
        private string id;
        private string title;
        private string author;
        private string category;
        private int quanti;
        private DateTime date;
        public string Id { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public string Author { get => author; set => author = value; }
        public string Category { get => category; set => category = value; }
        public int Quanti { get => quanti; set => quanti = value; }
        public DateTime Date { get => date; set => date = value; }

        public Book(string title, string author, string category, int quanti, DateTime date)
        {
            this.id = "ISBN" + DateTime.Now.Year.ToString() + count.ToString("D5");
            this.Title = title;
            this.Author = author;
            this.Category = category;
            this.Quanti = quanti;
            this.Date = date;
        }
    }
}
