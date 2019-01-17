using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
     
  public  class DataAccessLayer {
        SqlConnection con;
        public DataAccessLayer()
        {
            // con = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);
            string adres = "Data Source=SEM-BILGISAYAR;Initial Catalog=StokTakipD;User ID=test2;Password=test2";
            con = new SqlConnection(adres);
        }
        public int UrunKaydet(Urunler u)
        {
            int kayitSayisi = 0;
            string sql = "Insert into Urunler (UrunAdi,Adet,Fiyat,UstId,tdId,ctId)Values(@ad,@adet,@fiyat,@ustId,@tdId,@ctId)";

            kayitSayisi = con.Execute(sql, new { @ad = u.UrunAdi, @adet =u.Adet, @fiyat = u.Fiyat, @ustId = u.UstId, @tdId = u.tdId, @ctId = u.ctId});
            return kayitSayisi;
        }
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
        //List<Kategori> kategori = new List<Kategori> K();
        public  List<Kategori> KategoriGetir()
        {
           
           

            var ct = con.Query<Kategori>("Select * from kategori").ToList();
           
           
            return ct;
           
        }
    }

}
