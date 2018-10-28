using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Models;
using Library.Repositories;

namespace Library.Services
{
    class LoanService:IService
    {
        public event EventHandler Updated;

        LoanRepository loanRepository;

        public LoanService(RepositoryFactory rFactory)
        {
            this.loanRepository = rFactory.CreateLoanRepository();
        }

        public IEnumerable<Loan> AllLoans()
        {
            return loanRepository.All();
        }

        public void AddLoan(Loan loan)
        {
            loanRepository.Add(loan);
        }
        public bool AvailableCopies(Book book)
        {
            if (GetNumberOfCurrentLoansByBook(book) < book.BookCopies)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int GetNumberOfCurrentLoansByBook(Book book)
        {
            return AllLoans().Count(l => l.BookCopy.Book == book && l.TimeOfReturn == null);
        }

        public void RemoveLoan(Loan loan)
        {
           loanRepository.Remove(loan);
        }

        public Loan FindLoan (int key)
        {
            return loanRepository.Find(key);
        }
    }
}
