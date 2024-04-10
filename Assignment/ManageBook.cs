﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class ManageBook
    {
        List<Book> listBook;
        public ManageBook()
        {
            listBook = new List<Book>();
        }

        public void AddBook(Book b)
        {
            listBook.Add(b);

        }

        public void RemoveBook(Book b)
        {
            listBook.Remove(b);
        }

        public IEnumerable<Book> FindBook(string id = null,string title = null, string author = null, string category = null) {
            var query = this.listBook.AsQueryable();
            if (!string.IsNullOrEmpty(id))
            {
                query = query.Where(b => b.Id.Equals(id, StringComparison.OrdinalIgnoreCase));
            }
            if (!string.IsNullOrEmpty(title))
            {
                query = query.Where(b => b.Id.Equals(title, StringComparison.OrdinalIgnoreCase));
            }
            if (!string.IsNullOrEmpty(author))
            {
                query = query.Where(b => b.Id.Equals(author, StringComparison.OrdinalIgnoreCase));
            }
            if (!string.IsNullOrEmpty(category))
            {
                query = query.Where(b => b.Id.Equals(category, StringComparison.OrdinalIgnoreCase));
            }
            return query.ToList();
        }
    }
}