using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Musteriler
{
    public partial class müşteriEkle : Form
    {
        BLL.BusinessLogicLayer bll;


        public müşteriEkle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bll = new BLL.BusinessLogicLayer();
                int a = bll.MusteriEkle(textBox1.Text,textBox2.Text, textBox3.Text);

                if (a != -1)
                {
                    MessageBox.Show("Müşteri Eklendi.");

                }
                else
                {

                    MessageBox.Show("Kayıt Başarısız.");

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Boş Değer Eklenemez!");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
