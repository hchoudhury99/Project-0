using System;
using CheckingEntity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckingDAL
{
    public class Checkingdal
    {
        static List<Checkingentity> checkenty = new List<Checkingentity>();
        public void Create(Checkingentity newChecking)
        {
            checkenty.Add(newChecking);

            foreach (Checkingentity accountnum in checkenty)
            {
                Console.WriteLine("The Account Was Added To The Checking Account List. Count:  " + checkenty.Count);
                break;
            }
        }

        public void Close(Checkingentity newChecking) 
        {
            

            foreach (Checkingentity accountnum in checkenty)
            {
                checkenty.Remove(newChecking);
                break;
            }

            Console.WriteLine("The Account Was Removed From The List. Count:  " + checkenty.Count);
        }
    }
}
