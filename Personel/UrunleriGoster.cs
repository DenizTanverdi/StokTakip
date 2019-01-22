using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using DAL;

namespace Personel
{
    public partial class UrunleriGoster : Form
    {

        BLL.BusinessLogicLayer bll;
        BLL2.BusinessLogicLayer bll2;
        string kayitTipi = Properties.Settings.Default["kayitTipi"].ToString();
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
            if (kayitTipi != "linq")
            {
                List<Urunler> urun = new List<Urunler>();

                urun = bll.urunAra(textBox1.Text);

                dataGridView1.DataSource = urun;
            }
            else
            {
                List<DALLinq.Urunler> urun = new List<DALLinq.Urunler>();

                urun = bll2.urunAra(textBox1.Text);

                dataGridView1.DataSource = urun;
            }
        }
 List<DAL.Urunler> u = new List<DAL.Urunler>();
        public void kayitgetir()
        {
           

            if (kayitTipi == "linq")
            {
               

                u = bll.UrunleriGetir();
                dataGridView1.DataSource = u;
            }
            else
            {

                List<DALLinq.Urunler> u = new List<DALLinq.Urunler>();
                bll2 = new BLL2.BusinessLogicLayer();
                u = bll2.Urunler();
                dataGridView1.DataSource = u;

            }







        }

        private void button2_Click(object sender, EventArgs e)
        {

            kayitgetir();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            saveFileurun.Title = "urun bilgileri kayıt";
            saveFileurun.Filter = "*.xml|*.xml";
            saveFileurun.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            XmlSerializer srl = new XmlSerializer(typeof(List<Urunler>));
            if (saveFileurun.ShowDialog() == DialogResult.OK)
            {
                TextWriter tw = new StreamWriter(saveFileurun.FileName);
                srl.Serialize(tw, u);
                tw.Close();
                MessageBox.Show("liste kaydedildi.");
            }
        }
    }
}
