using Personel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void stokKontrolToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ürünEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            urunEkle urun = new urunEkle();
            urun.Show();
            
        }

        private void ürünBilgisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void toptancıGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Toptanci.goruntule g = new Toptanci.goruntule();
            g.Show();
        }
    }
}
