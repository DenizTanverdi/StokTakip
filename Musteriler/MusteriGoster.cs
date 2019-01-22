using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using DAL;

namespace Musteriler
{
    public partial class MusteriGoster : Form
    {

        BLL.BusinessLogicLayer bll;

        public MusteriGoster()
        {
            InitializeComponent();
        }

        private void MusteriGoster_Load(object sender, EventArgs e)
        {


            List<DAL.Musteriler> m = new List<DAL.Musteriler>();
            bll = new BLL.BusinessLogicLayer();
            m = bll.MusteriGetir();
            dataGridView1.DataSource = m;


        }
 List<DAL.Musteriler> m = new List<DAL.Musteriler>();
        public void kayitGetir()
        {

           
            bll = new BLL.BusinessLogicLayer();
            m = bll.MusteriGetir();
            dataGridView1.DataSource = m;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            kayitGetir();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            List<DAL.Musteriler> urun = new List<DAL.Musteriler>();

            urun = bll.musteriAra(textBox1.Text);

            dataGridView1.DataSource = urun;




        }

        private void button3_Click(object sender, EventArgs e)
        {
            saveFileMüşteri.Title = "urun bilgileri kayıt";
            saveFileMüşteri.Filter = "*.xml|*.xml";
            saveFileMüşteri.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            XmlSerializer srl = new XmlSerializer(typeof(List<DAL.Musteriler>));
            if (saveFileMüşteri.ShowDialog() == DialogResult.OK)
            {
                TextWriter tw = new StreamWriter(saveFileMüşteri.FileName);
                srl.Serialize(tw, m);
                tw.Close();
                MessageBox.Show("liste kaydedildi.");
            }


        }
    }
}
