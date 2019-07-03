using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerEntity
{
    public class Customerentity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id {get; set;}

        public Customerentity()
        {

        }

        public Customerentity(string firstname, string lastname, int id)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Id = id;
        }
    }
}
