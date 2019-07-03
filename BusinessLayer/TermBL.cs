using System;
using TermEntity;
using TermDAL;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermBL
{
    public class Termbl
    {
        Termdal trmdal = new Termdal();

        public void Create(Termentity newTerm)
        {
            trmdal.Create(newTerm);
        }

        public void Close(Termentity newTerm)
        {
            trmdal.Close(newTerm);
        }
    }
}
