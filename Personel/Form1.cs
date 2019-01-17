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
    public partial class Form1 : Form
    {
        public Form1()
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


        }

        private void cmbxKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = "";
            label1.Text = cmbxKategori.SelectedValue.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = "";
            label1.Text = comboBox1.SelectedValue.ToString();
        }
    }
}
