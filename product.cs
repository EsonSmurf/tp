using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TpProject.BLL;
using TpProject.DAL;

namespace TpProject.UI
{
    public partial class frmProduct : Form
    {
        public frmProduct()
        {
            InitializeComponent();
        }

        categoriesDAL cdal = new categoriesDAL();
        ProductsBLL p = new ProductsBLL();
        productsDAL pdal = new productsDAL();
        userDAL udal = new userDAL();
        private void frmProduct_Load(object sender, EventArgs e)
        {
            DataTable categoriesDT = cdal.Select();

            cmbCategory.DataSource = categoriesDT;

            cmbCategory.DisplayMember = "title";
            cmbCategory.ValueMember = "title";

            DataTable dt = pdal.Select();
            dgvProduct.DataSource = dt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            p.name = txtName.Text;
            p.category = cmbCategory.Text;
            p.description = txtDescription.Text;
            p.rate = decimal.Parse(txtRate.Text);
            p.qty = 0;
            p.added_date = DateTime.Now;

            String loggedUsr = frmLogin.loggedIn;
            userBLL usr = udal.getIDFromUsername(loggedUsr);

            p.added_by = usr.id;
            bool success = pdal.Insert(p);

            if (success == true)
            {
                MessageBox.Show("Product Added Successfully");

                Clear();

                DataTable dt = pdal.Select();
                dgvProduct.DataSource = dt;
            }
            else 
            {
                MessageBox.Show("Failed to Add new Product");
            }
        }
        public void Clear()
        {
            txtProductD.Text = "";
            txtName.Text = "";
            txtDescription.Text = "";
            txtRate.Text = "";
            txtSearch.Text = "";

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvProduct_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtProductD.Text = dgvProduct.Rows[rowIndex].Cells[0].Value.ToString();
            txtName.Text = dgvProduct.Rows[rowIndex].Cells[1].Value.ToString();
            cmbCategory.Text = dgvProduct.Rows[rowIndex].Cells[2].Value.ToString();
            txtDescription.Text = dgvProduct.Rows[rowIndex].Cells[3].Value.ToString();
            txtRate.Text = dgvProduct.Rows[rowIndex].Cells[4].Value.ToString();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            p.id = int.Parse(txtProductD.Text);
            p.name = txtName.Text;
            p.category = cmbCategory.Text;
            p.description = txtDescription.Text;
            p.rate = decimal.Parse(txtRate.Text);
            p.added_date = DateTime.Now;

            String loggedUsr = frmLogin.loggedIn;
            userBLL usr = udal.getIDFromUsername(loggedUsr);

            p.added_by = usr.id;

            bool success = pdal.Update(p);

            if (success == true)
            {
                MessageBox.Show("Product Successfully Updated");
                Clear();

                DataTable dt = pdal.Select();
                dgvProduct.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Failed To Update");
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            p.id = int.Parse(txtProductD.Text);

            bool success = pdal.Delete(p);

            if (success == true)
            {
                MessageBox.Show("Successfully Deleted.");
                Clear();

                DataTable dt = pdal.Select();
                dgvProduct.DataSource= dt;


            }
            else
            {
                MessageBox.Show("Failed to Delete");
            }
        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keywords = txtSearch.Text;

            if (keywords != null)
            {
                DataTable dt = pdal.Search(keywords);
                dgvProduct.DataSource = dt;
            }
            else
            {
                DataTable dt = pdal.Select();
                dgvProduct.DataSource = dt;
            }
        }
    }
}
