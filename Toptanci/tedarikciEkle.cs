using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toptanci
{
    public partial class tedarikciEkle : Form
    {

        BLL.BusinessLogicLayer bll;
        public tedarikciEkle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            bll = new BLL.BusinessLogicLayer();
           int a= bll.TedarikciEkle(textBox1.Text,textBox2.Text,textBox3.Text,textBox4.Text,textBox5.Text);
            if (a != -1)
            {
                MessageBox.Show("Tedarikci eklendi.");

            }
            else
            {

                MessageBox.Show("Kayıt Başarısız.");

            }

        }
    }
}
