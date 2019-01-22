using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personel
{
    
    public partial class satisForm : Form
    {
        BusinessLogicLayer bll;
        public satisForm()
        {
            InitializeComponent();
        }

        private void satisForm_Load(object sender, EventArgs e)
        {
            bll = new BusinessLogicLayer();
            List<Satis> satis = new List<Satis>();
            satis = bll.satis();
            dataGridView1.DataSource = satis;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
