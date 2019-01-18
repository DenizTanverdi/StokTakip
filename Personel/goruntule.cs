using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DAL;

namespace Toptanci_Goruntule
{

    
   
    public partial class goruntule : Form
    {

        BLL.BusinessLogicLayer bll;
        public goruntule()
        {
            InitializeComponent();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {


            bll = new BLL.BusinessLogicLayer();


        }


        public void kayitgetir()
        {
            List<Tedarikci> tedarikcis = new List<Tedarikci>();

            tedarikcis = bll.TedarikciGetir();
          
            dataGridView1.DataSource = tedarikcis;
           




        }

        private void button2_Click(object sender, EventArgs e)
        {
            kayitgetir();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Tedarikci> tedarikcis = new List<Tedarikci>();

            tedarikcis = bll.tedarikciAra(textBox1.Text);

            dataGridView1.DataSource = tedarikcis;

        }
        /// <summary>
        /// /
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
