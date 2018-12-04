using System;
using System.Collections.Generic;

namespace Library.Models
{
    public partial class Address
    {
        public Address()
        {
            User = new HashSet<User>();
        }

        public int AddressId { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string StreetNumber { get; set; }
        public string PostalCode { get; set; }

        public ICollection<User> User { get; set; }
    }
}
