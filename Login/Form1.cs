using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        BLL.BusinessLogicLayer bll;
        private void buttonGiris_Click(object sender, EventArgs e)
        {


            bll = new BLL.BusinessLogicLayer();
            if (bll.LoginKontrol(textBoxAdi.Text, textBoxSifre.Text) > 0)
            {
                /* this.Visible = false;
                 MainForm main = new MainForm();
                 main.Show();*/
                MessageBox.Show("Hoşgeldiniz");
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı");
            }
        }
    }
}
