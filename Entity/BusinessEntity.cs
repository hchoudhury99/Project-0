using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntity
{
    public class Businessentity
    {
        public int AccountNum { get; set; }
        public int AccountBalance { get; set; }
        public string AccountType { get; set; }

        public Businessentity ()
        {

        }

        public Businessentity (int accountnumber, int accountbalance, string accounttype)
        {
            this.AccountBalance = accountnumber;
            this.AccountBalance = accountbalance;
            this.AccountType = accounttype;
        }
    }
}
