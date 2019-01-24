using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALEntity1
{
    class Program
    {
        static void Main(string[] args)
        {
            StokTakipDEntities stk = new StokTakipDEntities();
            #region Users Ekleme
            //Users users = new Users();
            //users.email = "dd@gg.com";
            //users.pasword = "123123";
            //users.isLogin = true;
            //stk.Users.Add(users);
            //stk.SaveChanges();
            #endregion
            #region Join
            var res = from d in stk.Detay join s in stk.Siparis on d.sId equals s.sId join m in stk.Musteri on s.mId equals m.mId join u in stk.Urunler on d.pId equals u.pId select new { m.MusteriAdi,u.UrunAdi,d.miktar,d.fiyat,s.SiparisTarih };
            foreach (var item in res)
            {
                Console.WriteLine(item.MusteriAdi+" "+item.UrunAdi+" "+item.miktar+" "+item.fiyat+" "+item.SiparisTarih);
            }
            #endregion
            // Console.WriteLine("Hello World!");
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
