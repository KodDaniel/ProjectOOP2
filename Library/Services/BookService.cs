using Library.Models;
using Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services
{
    class BookService:IService

    {
        public event EventHandler Updated;
        /// <summary>
        /// service doesn't need a context but it needs a repository.
        /// </summary>
        BookRepository bookRepository;

    /// <param name="rFactory">A repository factory, so the service can create its own repository.</param>
    public BookService(RepositoryFactory rFactory)
    {
        this.bookRepository = rFactory.CreateBookRepository();
    }

    public IEnumerable<Book> All()
    {
        return bookRepository.All();
    }

        public IEnumerable<Book> AllBooksByAuthor(Author author)
        {
            return bookRepository.All().Where(b => b.Author.Id == author.Id);
        }

        public void AddBook(Book book)
        {
            bookRepository.Add(book);

            if (Updated != null)
            {
                Updated(this, EventArgs.Empty);

            }
        }

        public void RemoveBook(Book book)
        {
            bookRepository.Remove(book);
            if (Updated != null)
            {
                Updated(this, EventArgs.Empty);

            }
        }

        public Book FindBook(int key)
        {
            return bookRepository.Find(key); 
        }

    public IEnumerable<Book> GetAllThatContainsInTitle(string a)
    {
        return from b in bookRepository.All()
            where b.Title.Contains(a)
            select b;
    }

        /// <summary>
        /// The Edit method makes sure that the given Book object is saved to the database and raises the Updated() event.
        /// </summary>
        /// <param name="b"></param>
        public void Edit(Book book)
        {
            bookRepository.Edit(book);
            if (Updated != null)
            {
                Updated(this, EventArgs.Empty);

            }
        }


    }
}
