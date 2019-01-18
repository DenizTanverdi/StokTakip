using Personel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Toptanci;

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
            urun.MdiParent = this;
            urun.Show();
            
        }

        private void ürünBilgisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void toptancıGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
       
        }

        private void çIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
          Application.Exit();
        }

        private void toptancıEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            goruntule g = new goruntule();
            g.MdiParent = this;
            g.Show();
        }

        private void wEBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("www.google.com");
        }
    }
}
