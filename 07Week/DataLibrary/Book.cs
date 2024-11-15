using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary
{
    public class Book
    {
        // Property to store the unique ID of the Book
        public int BookId { get; set; }

        // Property to store the Title of the Book
        public string Title { get; set; }

        // Property to store the AuthorId (assumed to be a reference to an Author)
        public int AuthorId { get; set; }
    }
}
