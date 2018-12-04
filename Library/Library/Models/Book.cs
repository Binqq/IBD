using System;
using System.Collections.Generic;

namespace Library.Models
{
    public partial class Book
    {
        public Book()
        {
            Lease = new HashSet<Lease>();
        }

        public int BookId { get; set; }
        public string Title { get; set; }
        public int? AuthorId { get; set; }
        public string Description { get; set; }
        public string BookType { get; set; }

        public Author Author { get; set; }
        public ICollection<Lease> Lease { get; set; }
    }
}
