﻿namespace MainForm
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ürünlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünBilgisiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stokKontrolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stoklarıGösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünSayımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşterilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriGörüntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriCariHesapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tEDARİKÇİLERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toptancıGörüntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toptancıEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rAPORLARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporOluşturToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kATEGORİToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çIKIŞToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sOAPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kATEGORİEKLEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kATEGORİLERİGÖSTERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.menuStrip1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(691, 64);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ürünlerToolStripMenuItem,
            this.tEDARİKÇİLERToolStripMenuItem,
            this.kATEGORİToolStripMenuItem,
            this.stokKontrolToolStripMenuItem,
            this.müşterilerToolStripMenuItem,
            this.rAPORLARToolStripMenuItem,
            this.çIKIŞToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 26);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(685, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ürünlerToolStripMenuItem
            // 
            this.ürünlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ürünEkleToolStripMenuItem,
            this.ürünBilgisiToolStripMenuItem});
            this.ürünlerToolStripMenuItem.ForeColor = System.Drawing.SystemColors.MenuText;
            this.ürünlerToolStripMenuItem.Name = "ürünlerToolStripMenuItem";
            this.ürünlerToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.ürünlerToolStripMenuItem.Text = "ÜRÜNLER";
            // 
            // ürünEkleToolStripMenuItem
            // 
            this.ürünEkleToolStripMenuItem.Name = "ürünEkleToolStripMenuItem";
            this.ürünEkleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ürünEkleToolStripMenuItem.Text = "ÜRÜN EKLE";
            this.ürünEkleToolStripMenuItem.Click += new System.EventHandler(this.ürünEkleToolStripMenuItem_Click);
            // 
            // ürünBilgisiToolStripMenuItem
            // 
            this.ürünBilgisiToolStripMenuItem.Name = "ürünBilgisiToolStripMenuItem";
            this.ürünBilgisiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ürünBilgisiToolStripMenuItem.Text = "ÜRÜNLERİ GÖSTER";
            this.ürünBilgisiToolStripMenuItem.Click += new System.EventHandler(this.ürünBilgisiToolStripMenuItem_Click);
            // 
            // stokKontrolToolStripMenuItem
            // 
            this.stokKontrolToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stoklarıGösterToolStripMenuItem,
            this.ürünSayımToolStripMenuItem});
            this.stokKontrolToolStripMenuItem.ForeColor = System.Drawing.SystemColors.MenuText;
            this.stokKontrolToolStripMenuItem.Name = "stokKontrolToolStripMenuItem";
            this.stokKontrolToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.stokKontrolToolStripMenuItem.Text = "STOK KONTROL";
            this.stokKontrolToolStripMenuItem.Click += new System.EventHandler(this.stokKontrolToolStripMenuItem_Click);
            // 
            // stoklarıGösterToolStripMenuItem
            // 
            this.stoklarıGösterToolStripMenuItem.Name = "stoklarıGösterToolStripMenuItem";
            this.stoklarıGösterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.stoklarıGösterToolStripMenuItem.Text = "STOKLARI GÖSTER";
            // 
            // ürünSayımToolStripMenuItem
            // 
            this.ürünSayımToolStripMenuItem.Name = "ürünSayımToolStripMenuItem";
            this.ürünSayımToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ürünSayımToolStripMenuItem.Text = "ÜRÜN SAYIMI";
            // 
            // müşterilerToolStripMenuItem
            // 
            this.müşterilerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşteriGörüntüleToolStripMenuItem,
            this.müşteriEkleToolStripMenuItem,
            this.müşteriCariHesapToolStripMenuItem});
            this.müşterilerToolStripMenuItem.Name = "müşterilerToolStripMenuItem";
            this.müşterilerToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.müşterilerToolStripMenuItem.Text = "MÜŞTERİLER";
            // 
            // müşteriGörüntüleToolStripMenuItem
            // 
            this.müşteriGörüntüleToolStripMenuItem.Name = "müşteriGörüntüleToolStripMenuItem";
            this.müşteriGörüntüleToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.müşteriGörüntüleToolStripMenuItem.Text = "MÜŞTERİ GÖRÜNTÜLE";
            // 
            // müşteriEkleToolStripMenuItem
            // 
            this.müşteriEkleToolStripMenuItem.Name = "müşteriEkleToolStripMenuItem";
            this.müşteriEkleToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.müşteriEkleToolStripMenuItem.Text = "MÜŞTERİ EKLE";
            // 
            // müşteriCariHesapToolStripMenuItem
            // 
            this.müşteriCariHesapToolStripMenuItem.Name = "müşteriCariHesapToolStripMenuItem";
            this.müşteriCariHesapToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.müşteriCariHesapToolStripMenuItem.Text = "MÜŞTERİ CARİ HESAP";
            // 
            // tEDARİKÇİLERToolStripMenuItem
            // 
            this.tEDARİKÇİLERToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toptancıGörüntüleToolStripMenuItem,
            this.toptancıEkleToolStripMenuItem});
            this.tEDARİKÇİLERToolStripMenuItem.Name = "tEDARİKÇİLERToolStripMenuItem";
            this.tEDARİKÇİLERToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.tEDARİKÇİLERToolStripMenuItem.Text = "TEDARİKÇİLER";
            // 
            // toptancıGörüntüleToolStripMenuItem
            // 
            this.toptancıGörüntüleToolStripMenuItem.Name = "toptancıGörüntüleToolStripMenuItem";
            this.toptancıGörüntüleToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.toptancıGörüntüleToolStripMenuItem.Text = "TEDARİKÇİ EKLE";
            this.toptancıGörüntüleToolStripMenuItem.Click += new System.EventHandler(this.toptancıGörüntüleToolStripMenuItem_Click);
            // 
            // toptancıEkleToolStripMenuItem
            // 
            this.toptancıEkleToolStripMenuItem.Name = "toptancıEkleToolStripMenuItem";
            this.toptancıEkleToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.toptancıEkleToolStripMenuItem.Text = "TEDARİKÇİLERİ GÖRÜNTÜLE";
            this.toptancıEkleToolStripMenuItem.Click += new System.EventHandler(this.toptancıEkleToolStripMenuItem_Click);
            // 
            // rAPORLARToolStripMenuItem
            // 
            this.rAPORLARToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.raporOluşturToolStripMenuItem,
            this.xMLToolStripMenuItem,
            this.jSONToolStripMenuItem,
            this.sOAPToolStripMenuItem});
            this.rAPORLARToolStripMenuItem.Name = "rAPORLARToolStripMenuItem";
            this.rAPORLARToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.rAPORLARToolStripMenuItem.Text = "RAPORLAR";
            // 
            // raporOluşturToolStripMenuItem
            // 
            this.raporOluşturToolStripMenuItem.Name = "raporOluşturToolStripMenuItem";
            this.raporOluşturToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.raporOluşturToolStripMenuItem.Text = "EXCEL";
            // 
            // kATEGORİToolStripMenuItem
            // 
            this.kATEGORİToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kATEGORİEKLEToolStripMenuItem,
            this.kATEGORİLERİGÖSTERToolStripMenuItem});
            this.kATEGORİToolStripMenuItem.Name = "kATEGORİToolStripMenuItem";
            this.kATEGORİToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.kATEGORİToolStripMenuItem.Text = "KATEGORİ";
            // 
            // çIKIŞToolStripMenuItem
            // 
            this.çIKIŞToolStripMenuItem.Name = "çIKIŞToolStripMenuItem";
            this.çIKIŞToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.çIKIŞToolStripMenuItem.Text = "ÇIKIŞ";
            this.çIKIŞToolStripMenuItem.Click += new System.EventHandler(this.çIKIŞToolStripMenuItem_Click);
            // 
            // xMLToolStripMenuItem
            // 
            this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            this.xMLToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.xMLToolStripMenuItem.Text = "XML";
            // 
            // jSONToolStripMenuItem
            // 
            this.jSONToolStripMenuItem.Name = "jSONToolStripMenuItem";
            this.jSONToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.jSONToolStripMenuItem.Text = "JSON";
            // 
            // sOAPToolStripMenuItem
            // 
            this.sOAPToolStripMenuItem.Name = "sOAPToolStripMenuItem";
            this.sOAPToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sOAPToolStripMenuItem.Text = "SOAP";
            // 
            // kATEGORİEKLEToolStripMenuItem
            // 
            this.kATEGORİEKLEToolStripMenuItem.Name = "kATEGORİEKLEToolStripMenuItem";
            this.kATEGORİEKLEToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.kATEGORİEKLEToolStripMenuItem.Text = "KATEGORİ EKLE";
            // 
            // kATEGORİLERİGÖSTERToolStripMenuItem
            // 
            this.kATEGORİLERİGÖSTERToolStripMenuItem.Name = "kATEGORİLERİGÖSTERToolStripMenuItem";
            this.kATEGORİLERİGÖSTERToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.kATEGORİLERİGÖSTERToolStripMenuItem.Text = "KATEGORİLERİ GÖSTER";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.groupBox1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ürünlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stokKontrolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşterilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünBilgisiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stoklarıGösterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünSayımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriGörüntüleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriCariHesapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tEDARİKÇİLERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toptancıGörüntüleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toptancıEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rAPORLARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporOluşturToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kATEGORİToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kATEGORİEKLEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kATEGORİLERİGÖSTERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jSONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sOAPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çIKIŞToolStripMenuItem;
    }
}

