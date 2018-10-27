using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library.Models;

namespace Library.Repositories
{
    public class BookRepository: IRepository<Book, int>
    {
        LibraryContext context;

        public BookRepository(LibraryContext c)
        {
            this.context = c;
        }

        public IEnumerable<Book> All()
        {
            return context.Books;
        }

        public void Add(Book item)
        {
            context.Books.Add(item);
            context.SaveChanges();

        }

        public void Remove(Book item)
        {
            context.Books.Remove(item);
            context.SaveChanges();

        }

        public Book Find(int id)
        {
            return context.Books.Find(id);
        }

        public void Edit(Book b)
        {
            // Because the object b was retrieved through the same context, we don't need to do a lookup. 
            // We can just tell the context to save any changes that happened.
            context.SaveChanges();
            // Then why do we still pass the Book object all the way to the repository? Because the service
            // layer doesn't know we use EF. If in the future we decide to switch EF to something else, 
            // we won't have to change the service layer.
        }
        //public IEnumerable<Test> GetAllTestsForThisUserName(string userName)
        //{
        //    return _context.Test.
        //        Include(a => a.User).Include(a => a.Questions)
        //        .Where(a => a.User.UserName == userName)
        //        .OrderByDescending(c => c.CreateDate)
        //        .ThenByDescending(c => c.ChangeDate)
        //        .ToList();
        //}

        
    }
}