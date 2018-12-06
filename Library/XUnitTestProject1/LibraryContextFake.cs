using Library.Models.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace XUnitTestProject1
{
  
    class LibraryContextFake
    {
        private readonly List<User> _users;

        public LibraryContextFake()
        {
            _users = new List<User>()
            {
                new User()
                {
                    AddressId=1,
                    Login="as",
                    Name="sad",
                    Password="sadas",
                    Surname="asda",
                    UserId=12,
                    UserType="dfas",
                }
            };
        }
        public IEnumerable<User> GetAllItems()
        {
            return _users;
        }
    }
}
