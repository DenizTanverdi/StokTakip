using DAL;
using DALLinq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BusinessLogicLayer
    {
        DataAccessLayer dal;
        DALLinq.DAL dll;
        
        public BusinessLogicLayer()
        {
            dal = new DataAccessLayer();
        }
        public int LoginKontrol(string email, string password)
        {
            int ret = 0;
            
               
                // bool kontrol = EmailKontrol(email);
                bool k = !(string.IsNullOrEmpty(password));
            if (k)
            {
                string kayitTipi = Properties.Settings1.Default["kayitTipi"].ToString();
                if (kayitTipi == "linq")
                {
                    Users u = new Users();
                    u.email = email;
                    u.pasword = password;
                    ret = dal.LoginKontrol(u);
                }
                else
                {
                    User u = new User();
                    dll = new DALLinq.DAL();
                    u.email = email;
                    u.pasword = password;
                   
                    ret = dll.LoginKontrol(u);
                }
            }
            else
            {
                ret = -1;
            }
            return ret;
        }


        public List<DALLinq.Urunler> Urunler()
        {


            return dll.UrunGetir();
        }
        //urun bilgisi getirme
        public List<DAL.Urunler> UrunleriGetir()
        {
            return dal.UrunleriGetir();
        }


        // musterigetirme

            public List<DAL.Musteriler> MusteriGetir()
        {

            return dal.musteriGetir();

        }


        //kategori getirme
        public List<DAL.Kategori> KategoriGetir()
        {
            return dal.KategoriGetir();

        }
        //kategori ekleme
        public int KategoriEkle(String adı)
        {
            int a = 0;
            DAL.Kategori k = new DAL.Kategori();
            if (!string.IsNullOrEmpty(adı))
            {
                k.KategoriAdi = adı;
                a = 1;
                dal.kategoriEkle(k);
            }
            else
            {
                a = -1;
            }

            return a;

        }
        public List<DAL.Kategori> kategoriAra(string s)
        {
            return dal.kategoriAra(s);
        }

        //tedarikçi getirme
        public List<DAL.Tedarikci> TedarikciGetir()
        {
            return dal.TedarikciGetir();
        }
        //tedarikçi ekleme
        public int TedarikciEkle(string ad, string ulke, string tel, string il, string ilce)
        {

            int a = 0;
            DAL.Tedarikci t = new DAL.Tedarikci();
            if (!string.IsNullOrEmpty(ad) && !string.IsNullOrEmpty(tel))
            {
                t.tedarikciAdi = ad;
                t.ulke = ulke;
                t.Tel = tel;
                t.il = il;
                t.ilce = ilce;
                a = 1;
                dal.TedarikciEkle(t);
            }
            //deniz
            else
            {
                a = -1;

            }
        
            return a;

        }

        //urun ekleme
        public int UrunEkle(String adı, int adet, int fiyat, int UstId, int tdId, int ctId)
        {
            int a = 0;
            DAL.Urunler u = new DAL.Urunler();
            if (!string.IsNullOrEmpty(adı))
            {
                u.UrunAdi = adı;
                u.Adet = adet;
                u.Fiyat = fiyat;
                u.UstId = UstId;
                u.tdId = tdId;
                u.ctId = ctId;
                a = 1;
                dal.UrunKaydet(u);
            }
            else
            {
                a = -1;
            }

            return a;

        }



        public int MusteriEkle(string ad, string city, string tel )
        {

            int a = 0;
            DAL.Musteriler m = new DAL.Musteriler();
            if (!string.IsNullOrEmpty(ad) && !string.IsNullOrEmpty(tel))
            {
                m.MusteriAdi = ad;
               m.city = city;
                m.Tel = tel;
                a = 1;
                dal.MusteriEkle(m);
            }
            
            else
            {
                a = -1;

            }

            return a;

        }

        //tedarikciAra
        public List<DAL.Tedarikci> tedarikciAra(string s)
        {



            return dal.tedarikciAra(s);
        }
        public List<DAL.Musteriler> musteriAra(string m)
        {

            return dal.musteriAra(m);
        }

        public List<DAL.Urunler> urunAra(string s)
        {
            
            return dal.urunAra(s);
        }
        public List<Satis> satis()
        {
            return dal.satis();
        }
        public List<MenuS> menuGetir()
        {



            return dal.menuGetir();
        }
    }
}
