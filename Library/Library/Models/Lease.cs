using System;
using System.Collections.Generic;

namespace Library.Models
{
    public partial class Lease
    {
        public int LeaseId { get; set; }
        public int? BookId { get; set; }
        public int? UserId { get; set; }
        public DateTime? Date { get; set; }

        public Book Book { get; set; }
        public User User { get; set; }
    }
}
