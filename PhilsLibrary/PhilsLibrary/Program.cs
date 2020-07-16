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

            Console.WriteLine("Hello World!");
        }
    }
}
