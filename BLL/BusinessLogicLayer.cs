using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BusinessLogicLayer
    {
        DataAccessLayer dal;
        public BusinessLogicLayer()
        {
            dal = new DataAccessLayer();
        }
        public int LoginKontrol(string email, string password)
        {
            int ret = 0;
            Users u = new Users();
           // bool kontrol = EmailKontrol(email);
            bool k = !(string.IsNullOrEmpty(password));
            if ( k)
            {
                u.email = email;
                u.pasword = password;
                ret = dal.LoginKontrol(u);
            }
            else
            {
                ret = -1;
            }

            return ret;
        }
        public List<Kategori> KategoriGetir()
        {
            return dal.KategoriGetir();
        }
        public List<Tedarikci> TedarikciGetir()
        {
            return dal.TedarikciGetir();
        }
        public int TedarikciEkle(string ad,string ulke,string tel,string il,string ilce)
        {
            int a=0;
            Tedarikci t = new Tedarikci();
            if (!string.IsNullOrEmpty(ad) && !string.IsNullOrEmpty(tel))
            {

                t.tedarikciAdi = ad;
                t.ulke = ulke;
                t.Tel = tel;
                t.il = il;
                t.ilce = ilce;
                a = 1;

            }
            //deniz
            else {
                a = -1;
                
            }
            return a;
           
        }
    }
}
