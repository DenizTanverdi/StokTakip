﻿using BLL;
using DAL;
using Musteriler;
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
        BusinessLogicLayer bll ;
        private void stokKontrolToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

      

        private void ürünBilgisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UrunleriGoster u = new UrunleriGoster();
            u.MdiParent = this;
            u.Show();


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
            Process.Start("www.github.com/DenizTanverdi/StokTakip");
        }

        private void ürünSayımToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void sATIŞYAPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            satisForm satis = new satisForm();
            satis.Show();
        }

        private void ürünEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            urunEkle urun = new urunEkle();
            urun.MdiParent = this;
            urun.Show();

        }
        private void toptancıGörüntüleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            tedarikciEkle T = new tedarikciEkle();
            T.MdiParent = this;
            T.Show();
            
        }

        private void Main_Load(object sender, EventArgs e)
        {
           /* bll = new BLL.BusinessLogicLayer();
            var menu =bll.menuGetir();
            foreach (var item in menu)
            {
                menuStrip2.Items.Add(item.MenuName);
            }*/


        }

        private void müşteriGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MusteriGoster m = new MusteriGoster();
            m.MdiParent = this;
            m.Show();


        }

        private void müşteriEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {

            müşteriEkle m = new müşteriEkle();
            m.MdiParent = this;
            m.Show();
        }

        private void kATEGORİEKLEToolStripMenuItem_Click(object sender, EventArgs e)
        {

            kategori k = new kategori();
            k.MdiParent = this;
            k.Show();

        }

        private void xMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            label1.Text = dt.ToLongTimeString();
            label2.Text = dt.ToLongDateString();

        }
    }
}
