using System;
using BusinessEntity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDAL
{
    public class Businessdal
    {
        static List<Businessentity> busenty = new List<Businessentity>();
        public void Create(Businessentity newBusiness)
        {
            busenty.Add(newBusiness);

            foreach (Businessentity accountnum in busenty)
            {
                Console.WriteLine("The Account Was Added To The Business Account List. Count:  " + busenty.Count);
                break;
            }
        }

        public void Close(Businessentity newBusiness)
        {
            

            foreach (Businessentity accountnum in busenty)
            {
                busenty.Remove(newBusiness);
                break;
            }

            Console.WriteLine("The Account Was Removed From The List. Count:  " + busenty.Count);
        }
    }
}
