using System;
using TermEntity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermDAL
{
    public class Termdal
    {
        static List<Termentity> trmenty = new List<Termentity>();
        public void Create(Termentity newTerm)
        {
            trmenty.Add(newTerm);

            foreach (Termentity accountnum in trmenty)
            {
                Console.WriteLine("The Account Was Added To The Term Account List. Count:  " + trmenty.Count);
                break;
            }
        }

        public void Close(Termentity newTerm)
        {
            foreach (Termentity accountnum in trmenty)
            {
                trmenty.Remove(newTerm);
                break;
            }

            Console.WriteLine("The Account Was Removed From The List. Count:  " + trmenty.Count);
        }
    }
}
