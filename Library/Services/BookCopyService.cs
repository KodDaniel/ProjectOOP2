using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Models;
using Library.Repositories;

namespace Library.Services
{
    class BookCopyService:IService
    {
        public event EventHandler Updated;

        BookCopyRepository bookCopyRepository;

        public BookCopyService(RepositoryFactory rFactory)
        {
            this.bookCopyRepository = rFactory.CreateBookCopyRepository();
        }

        public IEnumerable<BookCopy> AllBookCopies()
        {
           return bookCopyRepository.All();
        }

        public int GetNumberOfCopiesByBookId(int id)
        {
            return bookCopyRepository.GetNumberOfCopiesByBookId(id);
        }


        public void AddBookCopy(BookCopy bookCopy)
        {
            bookCopyRepository.Add(bookCopy);
        }

        public void RemoveBookCopy(BookCopy bookCopy)
        {
            bookCopyRepository.Remove(bookCopy);
        }

        public BookCopy FindBookCopy(int key)
        {
            return bookCopyRepository.Find(key);
        }
    }
}
