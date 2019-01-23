namespace MainForm
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ürünlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünBilgisiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tEDARİKÇİLERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toptancıGörüntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toptancıEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kATEGORİToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kATEGORİEKLEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sATIŞToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sATIŞYAPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşterilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriGörüntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriCariHesapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rAPORLARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporOluşturToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wEBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çIKIŞToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ürünlerToolStripMenuItem,
            this.tEDARİKÇİLERToolStripMenuItem,
            this.kATEGORİToolStripMenuItem,
            this.sATIŞToolStripMenuItem,
            this.müşterilerToolStripMenuItem,
            this.rAPORLARToolStripMenuItem,
            this.wEBToolStripMenuItem,
            this.çIKIŞToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 2;
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
            this.ürünEkleToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.ürünEkleToolStripMenuItem.Text = "ÜRÜN EKLE";
            this.ürünEkleToolStripMenuItem.Click += new System.EventHandler(this.ürünEkleToolStripMenuItem_Click);
            // 
            // ürünBilgisiToolStripMenuItem
            // 
            this.ürünBilgisiToolStripMenuItem.Name = "ürünBilgisiToolStripMenuItem";
            this.ürünBilgisiToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.ürünBilgisiToolStripMenuItem.Text = "ÜRÜNLERİ GÖSTER";
            this.ürünBilgisiToolStripMenuItem.Click += new System.EventHandler(this.ürünBilgisiToolStripMenuItem_Click);
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
            this.toptancıGörüntüleToolStripMenuItem.Click += new System.EventHandler(this.toptancıGörüntüleToolStripMenuItem_Click_1);
            // 
            // toptancıEkleToolStripMenuItem
            // 
            this.toptancıEkleToolStripMenuItem.Name = "toptancıEkleToolStripMenuItem";
            this.toptancıEkleToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.toptancıEkleToolStripMenuItem.Text = "TEDARİKÇİLERİ GÖRÜNTÜLE";
            this.toptancıEkleToolStripMenuItem.Click += new System.EventHandler(this.toptancıEkleToolStripMenuItem_Click);
            // 
            // kATEGORİToolStripMenuItem
            // 
            this.kATEGORİToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kATEGORİEKLEToolStripMenuItem});
            this.kATEGORİToolStripMenuItem.Name = "kATEGORİToolStripMenuItem";
            this.kATEGORİToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.kATEGORİToolStripMenuItem.Text = "KATEGORİ";
            // 
            // kATEGORİEKLEToolStripMenuItem
            // 
            this.kATEGORİEKLEToolStripMenuItem.Name = "kATEGORİEKLEToolStripMenuItem";
            this.kATEGORİEKLEToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.kATEGORİEKLEToolStripMenuItem.Text = "KATEGORİ EKLE VE GÖSTER";
            this.kATEGORİEKLEToolStripMenuItem.Click += new System.EventHandler(this.kATEGORİEKLEToolStripMenuItem_Click);
            // 
            // sATIŞToolStripMenuItem
            // 
            this.sATIŞToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sATIŞYAPToolStripMenuItem});
            this.sATIŞToolStripMenuItem.Name = "sATIŞToolStripMenuItem";
            this.sATIŞToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.sATIŞToolStripMenuItem.Text = "SİPARİŞ";
            // 
            // sATIŞYAPToolStripMenuItem
            // 
            this.sATIŞYAPToolStripMenuItem.Name = "sATIŞYAPToolStripMenuItem";
            this.sATIŞYAPToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.sATIŞYAPToolStripMenuItem.Text = "DETAY";
            this.sATIŞYAPToolStripMenuItem.Click += new System.EventHandler(this.sATIŞYAPToolStripMenuItem_Click);
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
            this.müşteriGörüntüleToolStripMenuItem.Click += new System.EventHandler(this.müşteriGörüntüleToolStripMenuItem_Click);
            // 
            // müşteriEkleToolStripMenuItem
            // 
            this.müşteriEkleToolStripMenuItem.Name = "müşteriEkleToolStripMenuItem";
            this.müşteriEkleToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.müşteriEkleToolStripMenuItem.Text = "MÜŞTERİ EKLE";
            this.müşteriEkleToolStripMenuItem.Click += new System.EventHandler(this.müşteriEkleToolStripMenuItem_Click);
            // 
            // müşteriCariHesapToolStripMenuItem
            // 
            this.müşteriCariHesapToolStripMenuItem.Name = "müşteriCariHesapToolStripMenuItem";
            this.müşteriCariHesapToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.müşteriCariHesapToolStripMenuItem.Text = "MÜŞTERİ CARİ HESAP";
            // 
            // rAPORLARToolStripMenuItem
            // 
            this.rAPORLARToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.raporOluşturToolStripMenuItem});
            this.rAPORLARToolStripMenuItem.Name = "rAPORLARToolStripMenuItem";
            this.rAPORLARToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.rAPORLARToolStripMenuItem.Text = "RAPORLAR";
            // 
            // raporOluşturToolStripMenuItem
            // 
            this.raporOluşturToolStripMenuItem.Name = "raporOluşturToolStripMenuItem";
            this.raporOluşturToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.raporOluşturToolStripMenuItem.Text = "EXCEL";
            // 
            // wEBToolStripMenuItem
            // 
            this.wEBToolStripMenuItem.Name = "wEBToolStripMenuItem";
            this.wEBToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.wEBToolStripMenuItem.Text = "WEB ";
            this.wEBToolStripMenuItem.Click += new System.EventHandler(this.wEBToolStripMenuItem_Click);
            // 
            // çIKIŞToolStripMenuItem
            // 
            this.çIKIŞToolStripMenuItem.Name = "çIKIŞToolStripMenuItem";
            this.çIKIŞToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.çIKIŞToolStripMenuItem.Text = "ÇIKIŞ";
            this.çIKIŞToolStripMenuItem.Click += new System.EventHandler(this.çIKIŞToolStripMenuItem_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(984, 24);
            this.menuStrip2.TabIndex = 4;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(807, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(858, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 662);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip2;
            this.Name = "Main";
            this.Text = "ANA SAYFA";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ürünlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünBilgisiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tEDARİKÇİLERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toptancıGörüntüleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toptancıEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kATEGORİToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kATEGORİEKLEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sATIŞToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sATIŞYAPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşterilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriGörüntüleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriCariHesapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rAPORLARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporOluşturToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wEBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çIKIŞToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}

