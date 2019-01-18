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
            if (k)
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
        //urun bilgisi getirme
        public List<Urunler> UrunleriGetir()
        {
            return dal.UrunleriGetir();
        }

        //kategori getirme
        public List<Kategori> KategoriGetir()
        {
            return dal.KategoriGetir();
        }
        //kategori ekleme
        public int KategoriEkle(String adı)
        {
            int a = 0;
            Kategori k = new Kategori();
            if (!string.IsNullOrEmpty(adı))
            {
                k.KategoriAdi = adı;
                a = 1;
            }
            else
            {
                a = -1;
            }

            return a;

        }

        //tedarikçi getirme
        public List<Tedarikci> TedarikciGetir()
        {
            return dal.TedarikciGetir();
        }
        //tedarikçi ekleme
        public int TedarikciEkle(string ad, string ulke, string tel, string il, string ilce)
        {
            int a = 0;
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
            Urunler u = new Urunler();
            if (!string.IsNullOrEmpty(adı))
            {
                u.UrunAdi = adı;
                u.Adet = adet;
                u.Fiyat = fiyat;
                u.UstId = UstId;
                u.tdId = tdId;
                u.ctId = ctId;
                a = 1;
            }
            else
            {
                a = -1;
            }

            return a;

        }

        //tedarikciAra
        public List<Tedarikci> tedarikciAra(string s)
        {



            return dal.tedarikciAra(s);
        }
        //musteri getir
        public List<Musteriler> musteriGetir()
        {



            return dal.musteriGetir();
        }

        public List<Urunler> urunAra(string s)
        {



            return dal.urunAra(s);
        }
        public List<Satis> satis()
        {
            return dal.satis();
        }
    }
}
