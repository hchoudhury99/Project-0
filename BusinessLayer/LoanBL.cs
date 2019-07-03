using System;
using LoanEntity;
using LoanDAL;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanBL
{
    public class Loanbl
    {
        Loandal lodal = new Loandal();

        public void Create(Loanentity newLoan)
        {
            lodal.Create(newLoan);
        }

        public void Close(Loanentity newLoan)
        {
            lodal.Close(newLoan);
        }
    }
}
