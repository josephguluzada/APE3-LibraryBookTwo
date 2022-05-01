using System;
using System.Collections.Generic;
using System.Text;

namespace ListTaskTwo.Models
{
    class Library
    {
        private static int _id = 0;
        public int Id { get; }
        public string Name { get; set; }
        public List<Book> Books = new List<Book>();

        public Library(string name)
        {
            Id = ++_id;
            Name = name;
        }

        public void AddBook(Book book)
        {
            if (book != null) Books.Add(book);
        }

        public void ShowAllBooks()
        {
            foreach (Book book in Books)
            {
                Console.WriteLine(book.GetInfo());
            }
        }

        public Book FindBookById(int id)
        {
            if(Books.Exists(book => book.Id == id))
            {
                return Books.Find(book => book.Id == id);
            }
            return null;
        }

        public Book FindBookByBookCode(string bookCode)
        {
            if (Books.Exists(book => book.BookCode == bookCode))
            {
                return Books.Find(book => book.BookCode == bookCode);
            }

            return null;
        }

        public void RemoveBookById(int id)
        {
            if(Books.Exists(book => book.Id == id))
            {
                Book wantedBook = Books.Find(book => book.Id == id);
                Books.Remove(wantedBook);
            }
        }

    }
}
