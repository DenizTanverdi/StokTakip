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

namespace Personel
{
    public partial class kategori : Form
    {
        public kategori()
        {
            InitializeComponent();
        }


        BLL.BusinessLogicLayer bll;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bll = new BLL.BusinessLogicLayer();
                int a = bll.KategoriEkle(textBox1.Text);

                if (a != -1)
                {
                    MessageBox.Show("Ürün eklendi.");

                }
                else
                {

                    MessageBox.Show("Kayıt Başarısız.");

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Boş değer eklenemez!");

            }


        }
        

        private void button4_Click(object sender, EventArgs e)
        {

            List<Kategori> k = new List<Kategori>();

            k = bll.kategoriAra(textBox2.Text);

            dataGridView1.DataSource = k;

        }
   
        
        private void button3_Click(object sender, EventArgs e)
        {
            kayıtGetir();
        }
        List<Kategori> k = new List<Kategori>();
        public void kayıtGetir()
        {
            bll = new BLL.BusinessLogicLayer();

           

            k = bll.KategoriGetir();

            dataGridView1.DataSource = k;


        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();


        }

        private void button5_Click(object sender, EventArgs e)
        {
            saveFilekategori.Title = "kategori bilgileri kayıt";
            saveFilekategori.Filter = "*.xml|*.xml";
            saveFilekategori.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            XmlSerializer srl = new XmlSerializer(typeof(List<Kategori>));
            if (saveFilekategori.ShowDialog() == DialogResult.OK)
            {
                TextWriter tw = new StreamWriter(saveFilekategori.FileName);
                srl.Serialize(tw, k);
                tw.Close();
                MessageBox.Show("liste kaydedildi.");
            }
        }
    }
}
