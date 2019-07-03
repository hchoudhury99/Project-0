using System;
using BusinessEntity;
using BusinessDAL;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessBL
{
    public class Businessbl
    {
        Businessdal busdal = new Businessdal();

        public void Create(Businessentity newBusiness)
        {
            busdal.Create(newBusiness);
        }

        public void Close(Businessentity newBusiness)
        {
            busdal.Close(newBusiness);
        }
    }
}
