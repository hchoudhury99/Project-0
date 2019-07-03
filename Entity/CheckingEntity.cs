using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckingEntity
{
    public class Checkingentity
    {
        public int AccountNum { get; set; }
        public int AccountBalance { get; set; }
        public string AccountType { get; set; }
        public double Interest { get; set; }


        public Checkingentity()
        {

        }

        public Checkingentity(int accountnum, int accountbalance, string accounttype, double interest)
        {
            this.AccountNum = accountnum;
            this.AccountBalance = accountbalance;
            this.AccountType = accounttype;
            this.Interest = interest;
        }
    }
}
