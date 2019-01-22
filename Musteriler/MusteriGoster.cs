using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace Musteriler
{
    public partial class MusteriGoster : Form
    {

        BLL.BusinessLogicLayer bll;

        public MusteriGoster()
        {
            InitializeComponent();
        }

        private void MusteriGoster_Load(object sender, EventArgs e)
        {


            List<DAL.Musteriler> m = new List<DAL.Musteriler>();
            bll = new BLL.BusinessLogicLayer();
            m = bll.MusteriGetir();
            dataGridView1.DataSource = m;


        }

        public void kayitGetir()
        {

            List<DAL.Musteriler> m = new List<DAL.Musteriler>();
            bll = new BLL.BusinessLogicLayer();
            m = bll.MusteriGetir();
            dataGridView1.DataSource = m;

        }

    }
}
