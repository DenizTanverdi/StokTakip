using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Personel
{
    
    public partial class satisForm : Form
    {
        BusinessLogicLayer bll;
        public satisForm()
        {
            InitializeComponent();
        }
List<Satis> satis = new List<Satis>();
        private void satisForm_Load(object sender, EventArgs e)
        {
            bll = new BusinessLogicLayer();
            
            satis = bll.satis();
            dataGridView1.DataSource = satis;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            saveFilesatış.Title = "satış bilgileri kayıt";
            saveFilesatış.Filter = "*.xml|*.xml";
            saveFilesatış.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            XmlSerializer srl = new XmlSerializer(typeof(List<DAL.Satis>));
            if (saveFilesatış.ShowDialog() == DialogResult.OK)
            {
                TextWriter tw = new StreamWriter(saveFilesatış.FileName);
                srl.Serialize(tw, satis);
                tw.Close();
                MessageBox.Show("liste kaydedildi.");
            }
        }
    }
}
