using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Loan
    {
        public int Id { get; set; }
        public DateTime TimeOfLoan { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? TimeOfReturn { get; set; }
        public string Fine { get; set; }
        public virtual BookCopy BookCopy { get; set; }
        public virtual Member Member { get; set; }
    }
}
