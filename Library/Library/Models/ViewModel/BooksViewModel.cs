using Library.Models.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models.ViewModel
{
    public class BooksViewModel
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public AuthorDropDown Author { get; set; }
        public string Description { get; set; }
        public string BookType { get; set; }
        public string Availability { get; set; }



        public BooksViewModel AddBooks(LibraryContext _context,BooksViewModel bookModel)
        {
            Book book = new Book();
            book.AuthorId = bookModel.Author.ID;
            book.BookType = bookModel.BookType;
            book.Description = bookModel.Description;
            book.Title = bookModel.Title;
            _context.Add(book);
            _context.SaveChanges();
            bookModel.BookId = book.BookId;

            return bookModel;
        }

        public List<BooksViewModel> booksViews(LibraryContext _context)
        {
          List<BooksViewModel> books = new List<BooksViewModel>();
           
           var libraryContext = _context.Book.Include(b => b.Author);
           foreach(var book in libraryContext)
            {
                BooksViewModel model = new BooksViewModel();
                AuthorDropDown author = new AuthorDropDown();
                author.Author = book.Author.Name + book.Author.Surname;
                model.Author = author;

                model.BookId = book.BookId;
                model.BookType = book.BookType;
                model.Description = book.Description;
                model.Title = book.Title;

                var lease = _context.Lease.Where(l=>l.BookId==book.BookId).FirstOrDefault();
                if(lease==null)
                {
                    model.Availability = "Dostępna";
                }
                else
                {
                    model.Availability = "Wypożyczona";
                }
                books.Add(model);
            }
            return books;
        }
        public BooksViewModel getBookDetails(LibraryContext _context, int? id)
        {
            var book =  _context.Book.FindAsync(id);
            var author = _context.Author.Find(book.Result.AuthorId);
            BooksViewModel model = new BooksViewModel();
           
            AuthorDropDown authorModel = new AuthorDropDown();
            authorModel.Author = author.Name + author.Surname;
            authorModel.ID = author.AuthorId;
            model.Author = authorModel;

            model.Title = book.Result.Title;
            model.BookId = book.Result.BookId;
            model.BookType = book.Result.BookType;
            model.Description = book.Result.Description;

            return model;
        }
        public List<AuthorDropDown> GetAuthors(LibraryContext _context)
        {
            var authorList = (from Author in _context.Author select Author).ToList();
            List<AuthorDropDown> authors = new List<AuthorDropDown>();
            foreach(var author in authorList)
            {
                AuthorDropDown authorDropDown = new AuthorDropDown();
                authorDropDown.Author = author.Name + author.Surname;
                authorDropDown.ID = author.AuthorId;

                authors.Add(authorDropDown);
            }
                 return authors;
        }
    }
}
