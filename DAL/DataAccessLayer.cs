using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{

    public class DataAccessLayer
    {

        SqlConnection con;
        //constructure de baðlantý yapma
        public DataAccessLayer()
        {
            // con = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);
            string adres = "Data Source=SEM-BILGISAYAR;Initial Catalog=StokTakipD;User ID=test2;Password=test2";
            con = new SqlConnection(adres);
        }
        //user kontrol kýsmý
        public int LoginKontrol(Users u)
        {
            int kayitSayisi = 0;


            var user = con.Query<Users>("Select userid,email,islogin from Users where email=@email and pasword=@password", new { @email = u.email, @password = u.pasword });

            if (user.Count() > 0)
            {
                kayitSayisi = 1;

            }

            return kayitSayisi;


        }

        //urunler bilgisi çekme 
        public List<Urunler> UrunleriGetir()
        {
            var ct = con.Query<Urunler>("Select * from Urunler").ToList();

            return ct;

        }
        //urun ekleme
        public int UrunKaydet(Urunler u)
        {
            int kayitSayisi = 0;
            string sql = "Insert into Urunler (UrunAdi,Adet,Fiyat,UstId,tdId,ctId)Values(@ad,@adet,@fiyat,@ustId,@tdId,@ctId)";

            kayitSayisi = con.Execute(sql, new { @ad = u.UrunAdi, @adet = u.Adet, @fiyat = u.Fiyat, @ustId = u.UstId, @tdId = u.tdId, @ctId = u.ctId });

            return kayitSayisi;
            //deneme mesut murat
        }

        //kategori getirme  
        public List<Kategori> KategoriGetir()
        {
            var ct = con.Query<Kategori>("Select * from kategori").ToList();

            return ct;

        }
        //kategori ekleme
        public int kategoriEkle(Kategori k)
        {
            int kayitSayisi = 0;
            string sql = "Insert into Kategori (kategoriAdi) Values(@ad)";
            kayitSayisi = con.Execute(sql, new { @ad = k.KategoriAdi });

            return kayitSayisi;
        }
        //tedarikçi getirme
        public List<Tedarikci> TedarikciGetir()
        {
            var td = con.Query<Tedarikci>("Select * from tedarikci").ToList();


            return td;

        }
        //tedarikçi ekleme
        public int TedarikciEkle(Tedarikci t)
        {
            int kayitSayisi = 0;

            string sql = "Insert into Tedarikci (TedarikciAdi,ulke,tel,il,ilce)Values(@ad,@ulke,@tel,@il,@ilce)";
            kayitSayisi = con.Execute(sql, new { @ad = t.tedarikciAdi, @ulke = t.ulke, @tel = t.Tel, @il = t.il, @ilce = t.ilce });
            return kayitSayisi;
        }
        //tedarikci arama
        public List<Tedarikci> tedarikciAra(string s)
        {
            var td = con.Query<Tedarikci>("Select * from tedarikci where tedarikciAdi Like'%" + s + "'").ToList();


            return td;
        }

        public List<Musteriler> musteriGetir()
        {
            var td = con.Query<Musteriler>("Select * from musteriler ").ToList();


            return td;


        }
        public int MusteriEkle(Musteriler m)
        {
            int kayitSayisi = 0;

            string sql = "Insert into Musteri (name,city,tel)Values(@ad,@il,@tel)";
            kayitSayisi = con.Execute(sql, new { @ad = m.MusteriAdi, @il = m.city, @tel = m.Tel });
            return kayitSayisi;
        }
        //ürün arama
        public List<Urunler> urunAra(string s)
        {
            var td = con.Query<Urunler>("Select * from urunler where urunAdi Like'" + s + "%'").ToList();


            return td;
        }
        public  List<Satis> satis()
        {
            string sql = "Select m.name as MusteriAdi,m.city as Sehir,m.tel as Tel,p.CalisanAdý as calisanAdi,u.UrunAdi as urunAdi,d.fiyat,d.indirim,d.miktar from Musteri m inner join Siparis as s on m.mId=s.mId inner join Detay as d on s.sId=d.sId inner join Urunler u on d.pId=u.pId inner join Personel as p on p.calisanid=s.calisanId";
            var td = con.Query<Satis>(sql).ToList();
            //

            return td;
        }
    }

}
