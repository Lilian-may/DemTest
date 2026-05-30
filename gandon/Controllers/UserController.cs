using gandon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gandon.Controllers
{
    internal class UserController
    {
        private readonly Ispr2524KuzminAoLibraryContext _context = new();
        public Librarian? Authorize(string login, string password)
        {
            return _context.Librarians.FirstOrDefault(u => u.Login == login && u.Password == password);
        }
    }
}
