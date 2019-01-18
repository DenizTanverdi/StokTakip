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
    public partial class UrunleriGoster : Form
    {

        BLL.BusinessLogicLayer bll;
        public UrunleriGoster()
        {
            InitializeComponent();
        }

     

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
            List<Urunler> urun = new List<Urunler>();

            urun = bll.UrunleriGetir();

            dataGridView1.DataSource = urun;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kayitgetir();
        }
    }
}
