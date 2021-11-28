using my_books.Data.Models;
using my_books.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_books.Data.Services
{
    public class AuthorsService
    {
        private AppDbContext _context;

        public AuthorsService(AppDbContext context)
        {
            this._context = context;
        }

        public List<Author> GetAllAuthors() => _context.Authors.ToList();

        public Author GetAuthorById(int id) => _context.Authors.FirstOrDefault(a => a.Id == id);

        public void AddAuthor(AuthorVM author)
        {
            var _author = new Author()
            {
                FullName = author.FullName
            };

            _context.Authors.Add(_author);
            _context.SaveChanges();
        }

        public AuthorWithBooksVM GetAuthorWithBooks(int id)
        {
            var _author = _context.Authors.Where(a => a.Id == id).Select(a => new AuthorWithBooksVM()
            {
                Fullname = a.FullName,
                BookTitles = a.Book_Authors.Select(a => a.Book.Title).ToList()
            }).FirstOrDefault();

            return _author;
        }
    }
}
