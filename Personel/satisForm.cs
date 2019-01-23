using BLL;
using DAL;
using Microsoft.Office.Interop.Excel;
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
using Excel = Microsoft.Office.Interop.Excel;

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

        private void button2_Click(object sender, EventArgs e)
        {
            Excel.Application exceldosya = new Excel.Application();

            exceldosya.Visible = true;
            object Missing = Type.Missing;
            Workbook calismakitabi = exceldosya.Workbooks.Add(Missing);
            Worksheet sheet1 = (Worksheet)calismakitabi.Sheets[1];
            int sutun = 1;
            int satir = 1;



            for (int j = 0; j < dataGridView1.ColumnCount; j++)
            {

                Range myrange = (Range)sheet1.Cells[satir, sutun + j];
                myrange.Value2 = dataGridView1.Columns[j].HeaderText;

            }

            satir++;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    Range myrange = (Range)sheet1.Cells[satir + i, sutun + j];
                    myrange.Value2 = dataGridView1[j, i].Value == null ? "" : dataGridView1[j, i].Value;
                    myrange.Select();
                }
            }



        }
    }
}
