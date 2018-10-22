using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Models;

namespace Library.Repositories
{
    class LoanRepository:IRepository<Loan, int>
    {

        LibraryContext context;

        public LoanRepository(LibraryContext c)
        {
            this.context = c;
        }

        public IEnumerable<Loan> All()
        {
            return context.Loan;
        }

        public void Add(Loan item)
        {
            context.Loan.Add(item);
        }

        public void Remove(Loan item)
        {
            context.Loan.Remove(item);
        }

        public Loan Find(int id)
        {
            return context.Loan.Find(id);
        }

        public void Edit(Loan l)
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

