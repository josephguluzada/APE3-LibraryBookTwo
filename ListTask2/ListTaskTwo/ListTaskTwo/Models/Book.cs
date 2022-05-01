using System;
using System.Collections.Generic;
using System.Text;

namespace ListTaskTwo.Models
{
    class Book
    {
        private static int _id = 0;
        public int Id { get;}
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public string BookCode { get;}

        public Book(string name,string authorName)
        {
            Id = ++_id;
            Name = name;
            AuthorName = authorName;
            BookCode = Name.Substring(0, 2).ToUpper() + (1000 + _id);
        }

        public string GetInfo()
        {
            return $"BookCode: {BookCode} - Name: {Name} - Authorname: {AuthorName} Id: {Id}";
        }
    }
}
