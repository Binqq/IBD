using Library.Controllers;
using Library.Models.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
namespace XUnitTestProject1
{
    public class UsersControllerTest 
    {
        UsersController _controler;
        LibraryContext _context;
        public UsersControllerTest()
        {
           
            _controler = new UsersController(_context);
        }

        [Fact]
        public void GetAllUsers()
        {
            //var Results = _controler.GetAllUsers();

            //Assert.NotEmpty(Results);
        }
    }
}
