using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personel
{
    public partial class urunEkle : Form
    {
        public urunEkle()
        {
            InitializeComponent();
        }
        BLL.BusinessLogicLayer bll;
        private void Form1_Load(object sender, EventArgs e)
        {

            bll = new BLL.BusinessLogicLayer();
            List<Kategori> kategori = bll.KategoriGetir();

            cmbxKategori.DataSource = kategori;
            cmbxKategori.ValueMember = "ctId";
            cmbxKategori.DisplayMember = "KategoriAdi";
            bll = new BLL.BusinessLogicLayer();
            List<Tedarikci> tedarik = bll.TedarikciGetir();

            comboBox1.DataSource = tedarik;
            comboBox1.ValueMember = "tdId";
            comboBox1.DisplayMember = "tedarikciAdi";
            /*  foreach (var item in kategori)
              {
                  cmbxKategori.Items.Add(item.KategoriAdi);
                  cmbxKategori.ValueMember = item.KategoriAdi.ToString();
                  cmbxKategori.DisplayMember = item.ctId.ToString() ;

              }*/

            bll = new BLL.BusinessLogicLayer();
            List<Urunler> urun = bll.UrunleriGetir();

            comboBox2.DataSource = urun;
            comboBox2.ValueMember = "pId";
            comboBox2.DisplayMember = "UrunAdi";
        }

        private void cmbxKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = "";
            label1.Text = cmbxKategori.SelectedValue.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {//
            label1.Text = "";
            label1.Text = comboBox1.SelectedValue.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            bll = new BLL.BusinessLogicLayer();
            int a = bll.UrunEkle(textBox1.Text, Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text),Convert.ToInt32(comboBox2.SelectedValue), Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(cmbxKategori.SelectedValue));
            if (a != -1)
            {
                MessageBox.Show("urun eklendi.");

            }
            else
            {

                MessageBox.Show("Kayıt Başarısız.");

            }


        }
    }
}
