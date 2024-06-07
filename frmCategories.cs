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
    public partial class frmCategories : Form
    {
        public frmCategories()
        {
            InitializeComponent();
        }
         categoriesBLL c = new categoriesBLL();
        categoriesDAL dal = new categoriesDAL();
        userDAL udal = new userDAL();
        private void btnAdd_Click(object sender, EventArgs e)
        {

            c.title = txtTitle.Text;
            c.description = txtDescription.Text;
            c.added_date = DateTime.Now;

            string loggedUser = frmLogin.loggedIn;
            userBLL usr = udal.getIDFromUsername(loggedUser);   

            c.added_by = usr.id;

            bool success = dal.Insert(c);

            if (success == true)
            {
                MessageBox.Show("New Category Inserted Succesfully.");
                Clear();

                DataTable dt = dal.Select();
                dgvCategories.DataSource = dt;
            }
            else 
            {
                MessageBox.Show("Failed to Insert New Category.");
            }
        }
        public void Clear()
        {
            txtCategoriesID.Text = "";
            txtDescription.Text = "";
            txtSearch.Text = "";
            txtTitle.Text = "";
        
        }

        private void frmCategories_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            dgvCategories.DataSource = dt;
        }

        private void dgvCategories_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int RowIndex = e.RowIndex;
            txtCategoriesID.Text = dgvCategories.Rows[RowIndex].Cells[0].Value.ToString();
            txtTitle.Text = dgvCategories.Rows[RowIndex].Cells[1].Value.ToString();
            txtDescription.Text = dgvCategories.Rows[RowIndex].Cells[2].Value.ToString();
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            c.id = int.Parse(txtCategoriesID.Text);
            c.title = txtTitle.Text;
            c.description = txtDescription.Text;
            c.added_date = DateTime.Now;

            string loggedUser = frmLogin.loggedIn;
            userBLL usr = udal.getIDFromUsername(loggedUser);

            c.added_by = usr.id;

            bool success = dal.Update(c);

            if (success)
            {

                MessageBox.Show("Category Update Successfully");
                Clear();

                DataTable dt = dal.Select();
                dgvCategories.DataSource= dt;
            }
            else
            {
                MessageBox.Show("Failed to Update");
            
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            c.id = int.Parse(txtCategoriesID.Text);

            bool success = dal.Delete(c);

            if (success)
            {
                MessageBox.Show("Category Deleted Successfully");
                Clear();

                DataTable dt = dal.Select();
                dgvCategories.DataSource= dt;
            }
            else
            {
                MessageBox.Show("Failed to Delete Category");
            }
        
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keywords = txtSearch.Text;

            if (keywords != null)
            {
                DataTable dt = dal.Search(keywords);
                dgvCategories.DataSource = dt;
            }
            else
            {
                DataTable dt = dal.Select();
                dgvCategories.DataSource = dt;
            }
        }

        private void dgvCategories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
