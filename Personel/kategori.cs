using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        public void kayıtGetir()
        {

            List<Kategori> k = new List<Kategori>();

            k = bll.KategoriGetir();

            dataGridView1.DataSource = k;


        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();


        }
    }
}
