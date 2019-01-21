using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace Personel
{
    public partial class UrunleriGoster : Form
    {

        BLL.BusinessLogicLayer bll;
        BLL2.BusinessLogicLayer bll2;
        string kayitTipi = ConfigurationManager.AppSettings["kayitTipi"];
        public UrunleriGoster()
        {
            InitializeComponent();
        }


        DALLinq.DAL db;
        private void UrunleriGoster_Load(object sender, EventArgs e)
        {
            bll = new BLL.BusinessLogicLayer();
            kayitgetir();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Urunler> urun = new List<Urunler>();

            urun = bll.urunAra(textBox1.Text);

            dataGridView1.DataSource = urun;
        }

        public void kayitgetir()
        {
           

            if (kayitTipi != "linq")
            {
                List<DAL.Urunler> u = new List<DAL.Urunler>();

                u = bll.UrunleriGetir();
                dataGridView1.DataSource = u;
            }
            else
            {

                List<DALLinq.Urunler> u = new List<DALLinq.Urunler>();

                u = bll2.Urunler();
                dataGridView1.DataSource = u;

            }







        }

        private void button2_Click(object sender, EventArgs e)
        {


            kayitgetir();
        }
    }
}
