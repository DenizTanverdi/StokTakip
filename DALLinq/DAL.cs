using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.SqlClient;

namespace DALLinq
{
    public class DAL
    {
        DataClasses1DataContext db = new DataClasses1DataContext();

        public int LoginKontrol(User u)
        {
            var login = db.Users.FirstOrDefault(I => I.email == u.email && I.pasword == u.pasword);
            int ret = 0;
            if (login!=null)
            {
                ret = 1;
            }
            else
            {
                ret = -1;
            }
            ////
            return ret;

        }
        public List<Urunler> UrunGetir()
        {
            
            var urun = (from urn in db.Urunlers  select urn).ToList();
            
            return urun;
        }
        public List<Urunler> urunAra(string s)
        {
            var td = (from urn in db.Urunlers where SqlMethods.Like(urn.UrunAdi  ,  s+"%"  )select urn).ToList();


            return td;
        }


    }
}
