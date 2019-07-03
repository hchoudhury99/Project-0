using System;
using LoanEntity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanDAL
{
    public class Loandal
    {
        static List<Loanentity> loenty = new List<Loanentity>();
        public void Create(Loanentity newLoan)
        {
            loenty.Add(newLoan);

            foreach (Loanentity accountnum in loenty)
            {
                Console.WriteLine("The Account Was Added To The Loan Account List. Count:  " + loenty.Count);
                break;
            }
        }

        public void Close(Loanentity newLoan)
        {
            

            foreach (Loanentity accountnum in loenty)
            {
                loenty.Remove(newLoan);
                break;
            }

            Console.WriteLine("The Account Was Removed From The List. Count:  " + loenty.Count);
        }
    }
}
