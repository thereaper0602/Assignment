using System;

namespace Assignment
{
    [Serializable]
    public class Book
    {
        private string id;
        private string title;
        private string author;
        private string category;
        private int quanti;
        private DateTime date;
        private string imgPath;
        public Book() { }
        public string Id 
        {
            get { return id; }
            set { id = value; }
        }
        public string Title 
        {
            get { return title; }
            set { title = value; }
        }
        public string Author 
        {
            get { return author; }
            set { author = value; }
        }
        public string Category 
        {
            get { return category; }
            set { category = value; }
        }
        public int Quanti 
        {
            get { return quanti; }
            set { quanti = value; }
        }
        public DateTime Date 
        {
            get { return date; }
            set { date = value; }
        }
        public string ImgPath 
        {
            get { return imgPath; }
            set { imgPath = value; }
        }

        public Book(int count, string title, string author, string category, int quanti, string date)
        {
            this.id = "ISBN" + DateTime.Now.Year.ToString() + count.ToString("D5");
            this.Title = title;
            this.Author = author;
            this.Category = category;
            this.Quanti = quanti;
            this.Date = DateTime.Parse(date);
        }

        public Book(int count,string title, string author, string category, int quanti, string date, string imgPath)
        {
            this.id = "ISBN" + DateTime.Now.Year.ToString() + count.ToString("D5");
            this.Title = title;
            this.Author = author;
            this.Category = category;
            this.Quanti = quanti;
            this.Date = DateTime.Parse(date);
            this.imgPath = imgPath;
        }
    }
}
