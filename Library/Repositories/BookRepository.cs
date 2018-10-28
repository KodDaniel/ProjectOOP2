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

        public void Edit(Book item)
        {
            Book oldBook = context.Books.FirstOrDefault(b => b.Id == item.Id);

            oldBook.Title = item.Title;
            oldBook.Isbn = item.Isbn;
            oldBook.Author = item.Author;
            oldBook.BookCopies = item.BookCopies;
            oldBook.Description = item.Description;

            context.SaveChanges();
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