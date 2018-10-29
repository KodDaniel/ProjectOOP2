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
            if (Updated != null)
            {
                Updated(this, EventArgs.Empty);
            }
        }

        public void LoanBook(BookCopy bookCopy, Member member)
        {
            // Uppgiftsspecifik logik för att ett lån ska vara försenat

            var dateOfLoan = DateTime.Now;

            if (member.Loans is null)
            {
                dateOfLoan = DateTime.Now;               
            }            
            else if (member.Loans.Count >= 1)
            {
                dateOfLoan = DateTime.Now.AddMonths(-1);              
            }

            var loan = new Loan()
            {
                TimeOfLoan = dateOfLoan,
                DueDate = dateOfLoan.AddDays(14),
                BookCopy = bookCopy,
                Member = member,
            };

           AddLoan(loan);
           ConnectMemberAndLoan(loan, member);

        }

        public void ReturnLoan(Loan loan, DateTime timeOfReturn)
        {
            loan.TimeOfReturn = timeOfReturn;

            if (timeOfReturn > loan.DueDate)
            {
                loan.Fine = "50 kronor";
            }
            loanRepository.Edit(loan);
         
            if (Updated != null)
            {
                Updated(this, EventArgs.Empty);

            }
        }

        public void ConnectMemberAndLoan(Loan loan, Member member)
        {
            member.Loans.Add(loan);
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
