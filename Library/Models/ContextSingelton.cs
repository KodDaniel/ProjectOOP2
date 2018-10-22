using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    // Class which handels the Life-cycle of DbContext (in this Application) 
    public class ContextSingelton
    {
        private static LibraryContext _context;

        public static LibraryContext GetContext()
        {
            if (_context == null)
            {
                _context = new LibraryContext();
            }
            return _context;
        }
    }
}
