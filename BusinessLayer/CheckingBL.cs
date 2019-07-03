using System;
using CheckingEntity;
using CheckingDAL;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckingBL
{
    public class Checkingbl
    {
        Checkingdal checkdal = new Checkingdal();

        public void Create(Checkingentity newChecking)
        {
            checkdal.Create(newChecking);
        }

        public void Close(Checkingentity newChecking)
        {
            checkdal.Close(newChecking);
        }
    }
}
