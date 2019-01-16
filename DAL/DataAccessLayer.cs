using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{

    class DataAccessLayer
    {
        SqlConnection con;
        public DataAccessLayer()
        {
            // con = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);
            string adres = "Data Source=.;Initial Catalog=StokTakip;Integrated Security=True";
            con = new SqlConnection(adres);
        }
    }
}