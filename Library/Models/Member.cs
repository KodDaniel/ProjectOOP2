using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Member
    {
        public int Id { get; set; }
        public string Pnr { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Loan> Loans { get; set; }
    }
}
