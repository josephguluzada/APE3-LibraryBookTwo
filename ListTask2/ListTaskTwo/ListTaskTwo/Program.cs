using ListTaskTwo.Models;
using System;

namespace ListTaskTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Harry Potter", "J.K.Rowling");
            Book book2 = new Book("Jarry Potter", "T.K.Rowling");
            Book book3 = new Book("Yarry Potter", "L.K.Rowling");
            Book book4 = new Book("Garry Potter", "D.K.Rowling");
            Book book5 = new Book("Karry Potter", "D.K.Rowling");


            Library library = new Library("Larry Potter");

            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);
            library.AddBook(book4);

            Console.WriteLine("Books:");
            library.ShowAllBooks();

            Console.WriteLine("Find book by id:");
            Console.WriteLine(library.FindBookById(3).GetInfo());

            Console.WriteLine("Find book by BookCode:");
            Console.WriteLine(library.FindBookByBookCode("GA1004").GetInfo());

            Console.WriteLine("Books List Again:");
            library.ShowAllBooks();

            library.RemoveBookById(1);
            Console.WriteLine("After delete:");
            library.ShowAllBooks();

            library.AddBook(book5);
            Console.WriteLine("After add");
            library.ShowAllBooks();
        }
    }
}
