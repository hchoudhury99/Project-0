using System;
using CustomerEntity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerDAL
{
    public class Customerdal
    {
        static List<Customerentity> customerentities = new List<Customerentity>();

        public void Create(Customerentity newCustomer)
        {
            customerentities.Add(newCustomer);
           
            foreach (Customerentity id in customerentities) 
            {
                Console.WriteLine("The Customer Was Added To The Customer List. Count:  " + customerentities.Count);
                break;
            }
        }
    }
}
