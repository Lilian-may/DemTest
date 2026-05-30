using gandon.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gandon.Controllers
{
    internal class BookController
    {
        private readonly Ispr2524KuzminAoLibraryContext _context = new();

        public List<Book> GetBooks()
        {
            return _context.Books.Include(x => x.Author).ToList();
        }

        public List<Author> GetAuthor()
        {
            return _context.Authors.OrderBy(x => x.AuthorName).ToList();
        }

        public void AddBook(string name, int authorId, decimal price)
        {
            Book book = new()
            {
                Name = name,
                AuthorId = authorId,
                Cena = price,
            };
            _context.Books.Add(book);
            _context.SaveChanges();
        }

        public void DeleteBook(int id)
        {
            Book? book = _context.Books.FirstOrDefault(x => x.Idbook == id);
            
            if (book == null) return;

            _context.Remove(book);
            _context.SaveChanges();
        }

        public void DeleteAuthor(int id)
        {
            Author? author = _context.Authors.FirstOrDefault(x => x.Idauthor == id);

            if (author == null) return;

            _context.Remove(author);
            _context.SaveChanges();
        }

        public void UpdateBook(int id, string name, int authorId, decimal price)
        {
            Book? book = _context.Books.FirstOrDefault(x => x.Idbook == id);

            if (book == null) return;

            book.Name = name;
            book.AuthorId = authorId;
            book.Cena = price;

            _context.SaveChanges();
        }
    }
}
