using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
     
    class DataAccessLayer {
        SqlConnection con;
        public DataAccessLayer()
        {
            // con = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);
            string adres = "Data Source=.;Initial Catalog=StokTakip;Integrated Security=True";
            con = new SqlConnection(adres);
        }
        public int UrunKaydet(Urunler u)
        {
            int kayitSayisi = 0;
            string sql = "Insert into Urunler (UrunAdi,Adet,Fiyat,UstId,tdId,ctId)Values(@ad,@adet,@fiyat,@ustId,@tdId,@ctId)";

            kayitSayisi = con.Execute(sql, new { @ad = u.UrunAdi, @adet =u.Adet, @fiyat = u.Fiyat, @ustId = u.UstId, @tdId = u.tdId, @ctId = u.ctId});
            return kayitSayisi;
        }
        //
    }

}
