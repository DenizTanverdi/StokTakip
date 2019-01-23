using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL2
{

    public class BusinessLogicLayer
    {
        DALLinq.DAL dll=new DALLinq.DAL();
        public List<DALLinq.Urunler> Urunler()
        {


            return dll.UrunGetir();
        }

        public List<DALLinq.Urunler> urunAra(string s)
        {


            return dll.urunAra(s);
        }
    }
}