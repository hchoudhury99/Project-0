using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermEntity
{
    public class Termentity
    {
        public int AccountNum { get; set; }
        public int AccountBalance { get; set; }
        public string AccountType { get; set; }
        public int Age { get; set; }

        public Termentity ()
        {

        }

        public Termentity (int accountnum, int accountbalance, string accounttype, int age)
        {
            this.AccountNum = accountnum;
            this.AccountBalance = accountbalance;
            this.AccountType = accounttype;
            this.Age = age;
        }
    }
}
