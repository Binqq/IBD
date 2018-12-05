using System;
using System.Collections.Generic;

namespace Library.Models.Data
{
    public partial class Author
    {
        public Author()
        {
            Book = new HashSet<Book>();
        }

        public int AuthorId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Description { get; set; }

        public ICollection<Book> Book { get; set; }
    }
}
