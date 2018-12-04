using System;
using System.Collections.Generic;

namespace Library.Models
{
    public partial class User
    {
        public User()
        {
            Lease = new HashSet<Lease>();
        }

        public int UserId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int? AddressId { get; set; }

        public Address Address { get; set; }
        public ICollection<Lease> Lease { get; set; }
    }
}
