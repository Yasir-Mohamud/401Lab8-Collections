using PhilsLibrary.Class;
using System;
using System.Collections.Generic;

namespace PhilsLibrary
{
    class Program
    {
        public static Library <Book> Library { get; set; }
        public static List <Book> BookBag { get; set; }


        static void Main(string[] args)
        {
            Library = new Library<Book>();
            BookBag = new List <Book> ();
            LoadBooks();
            Console.WriteLine("Hello World!");
        }


        static void LoadBooks()
        {
            Book one = new Book("Percy Jackson Attack on Olympus", 300,"Rick" ,"Rioden" , Genre.Sci_Fi);
            Book two = new Book("Charlie and the Chocolate Factory", 250, "Roald", "Dahl", Genre.Adventure);
            Book three = new Book("Cat in the Hat", 10, "Dr.", "Suess", Genre.Adventure);
            Book four = new Book("Fifty shades of grey", 300, "E.L.", "James", Genre.Romance);
            Book five = new Book("The Great Gatsby", 300, "F. Scott" , "Fitzgerald", Genre.Adventure);


        }
    }
}
