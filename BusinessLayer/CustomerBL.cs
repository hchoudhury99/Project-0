using System;
using CustomerDAL;
using CustomerEntity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerBL
{
    public class Customerbl
    {
        Customerdal custdal = new Customerdal();
       
        public void Create (Customerentity newCustomer)
        {
            custdal.Create(newCustomer);
        }
    }
}
