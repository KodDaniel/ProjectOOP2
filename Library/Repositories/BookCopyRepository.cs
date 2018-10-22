using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Models;

namespace Library.Repositories
{
    class BookCopyRepository:IRepository<BookCopy, int>
    {

        LibraryContext context;

        public BookCopyRepository(LibraryContext c)
        {
            this.context = c;
        }

        public IEnumerable<BookCopy> All()
        {
            return context.BookCopies;
        }

        public void Add(BookCopy item)
        {
            context.BookCopies.Add(item);
        }

        public void Remove(BookCopy item)
        {
            context.BookCopies.Remove(item);
        }

        public BookCopy Find(int id)
        {
            return context.BookCopies.Find(id);
        }

        public void Edit(BookCopy bc)
        {
            // Because the object b was retrieved through the same context, we don't need to do a lookup. 
            // We can just tell the context to save any changes that happened.
            context.SaveChanges();
            // Then why do we still pass the Book object all the way to the repository? Because the service
            // layer doesn't know we use EF. If in the future we decide to switch EF to something else, 
            // we won't have to change the service layer.
        }
    }
}

