using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TpProject.DAL;

namespace TpProject.UI
{
    public partial class frmInventory : Form
    {
        public frmInventory()
        {
            InitializeComponent();
        }
        categoriesDAL cdal = new categoriesDAL();
        productsDAL pdal = new productsDAL();
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmInventory_Load(object sender, EventArgs e)
        {
            DataTable cDT = cdal.Select();

            cmbCategory.DataSource = cDT;

            cmbCategory.DisplayMember = "title";
            cmbCategory.ValueMember = "title";

            DataTable pdt = pdal.Select();
            dgvInventory.DataSource = pdt;
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string category = cmbCategory.Text;

            DataTable dt = pdal.DisplayProductByCategory(category);
            dgvInventory.DataSource= dt;
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            DataTable dt= pdal.Select();
            dgvInventory.DataSource = dt;
        }
    }
}
