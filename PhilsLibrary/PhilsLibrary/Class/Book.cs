using System;
using System.Collections.Generic;
using System.Text;

namespace PhilsLibrary.Class
{
    class Book 
    {
        public string Title { get; set; }

        public int NumberOfPages { get; set; }

        public  Author author { get; set; }

        public Genre genre { get; set; }


       
    }

    enum Genre
    {
        Sci_Fi,
        Romance,
        Adventure,
        Thriller
    }
}
