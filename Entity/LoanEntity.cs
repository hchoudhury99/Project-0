using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanEntity
{
    public class Loanentity
    {
        public int AccountNum { get; set; }
        public int AccountBalance { get; set; }
        public string AccountType { get; set; }

        public Loanentity()
        {

        }

        public Loanentity (int accountnum, int accountbalance, string accounttype)
        {
            this.AccountNum = accountnum;
            this.AccountBalance = accountbalance;
            this.AccountType = accounttype;
        }
    }
}
