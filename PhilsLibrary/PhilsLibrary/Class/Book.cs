using System;
using System.Collections.Generic;
using System.Text;

namespace PhilsLibrary.Class
{
    class Book : Author
    {
        public string Title { get; set; }

        public int NumberOfPages { get; set; }

        public Author Author { get; set; }

        public Genre Genre { get; set; }

        public Book(string title, int numOfPages, string FirstName, string LastName, Genre genre)
        {
            Title = title;
            NumberOfPages = numOfPages;
            Author = new Author()
            {
                FirstName = FirstName,
                LastName = LastName,
            };
            Genre = genre;
        }

}

enum Genre
{
    Sci_Fi,
    Romance,
    Adventure,
    Thriller
}
}
