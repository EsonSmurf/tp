using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TpProject.BLL;
using TpProject.DAL;

namespace TpProject.UI
{
    public partial class frmDeaCust : Form
    {
        public frmDeaCust()
        {
            InitializeComponent();
        }
        DeaCustBLL dc = new DeaCustBLL();
        DeaCustDAL dcDal = new DeaCustDAL();

        userDAL uDal = new userDAL();   
        private void btnAdd_Click(object sender, EventArgs e)
        {
            dc.type = cmbDeaCust.Text;
            dc.name = txtName.Text;
            dc.email = txtEmail.Text;
            dc.contact = txtContact.Text;
            dc.address = txtAddress.Text;   
            dc.added_date = DateTime.Now;

            string loggedUsr = frmLogin.loggedIn;
            userBLL usr = uDal.getIDFromUsername(loggedUsr);
            dc.added_by = usr.id;

            bool success = dcDal.Insert(dc);

            if (success == true)
            {
                MessageBox.Show("Dealer or Customer Added Successfully");
                Clear();

                DataTable dt = dcDal.Select();
                dgvDeaCust.DataSource = dt;
            }
            else 
            {
                MessageBox.Show("Failed to Add");
            }
        }
        public void Clear()
        {
            txtID.Text = "";
            txtEmail.Text = "";
            txtSearch.Text = "";
            txtName.Text = "";
            txtContact.Text = "";
            txtAddress.Text = "";
        }

        private void frmDeaCust_Load(object sender, EventArgs e)
        {

            DataTable dt = dcDal.Select();
            dgvDeaCust.DataSource = dt;
        }

        private void dgvDeaCust_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;

            txtID.Text = dgvDeaCust.Rows[rowIndex].Cells[0].Value.ToString();
            cmbDeaCust.Text = dgvDeaCust.Rows[rowIndex].Cells[1].Value.ToString();
            txtName.Text = dgvDeaCust.Rows[rowIndex].Cells[2].Value.ToString();
            txtEmail.Text = dgvDeaCust.Rows[rowIndex].Cells[3].Value.ToString();
            txtContact.Text = dgvDeaCust.Rows[rowIndex].Cells[4].Value.ToString();
            txtAddress.Text = dgvDeaCust.Rows[rowIndex].Cells[5].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dc.id = int.Parse(txtID.Text);
            dc.name = txtName.Text;
            dc.type = cmbDeaCust.Text;
            dc.email = txtEmail.Text;
            dc.contact = txtContact.Text;
            dc.address = txtAddress.Text;
            dc.added_date = DateTime.Now;

            string loggedUsr = frmLogin.loggedIn;
            userBLL usr = uDal.getIDFromUsername(loggedUsr);
            dc.added_by = usr.id;

            bool success = dcDal.Update(dc);
            if (success == true)
            {
                MessageBox.Show("Dealer or Customer Update Successfully");
                Clear();

                DataTable dt = dcDal.Select();
                dgvDeaCust.DataSource = dt;
            }

            else
            {
                MessageBox.Show("Failed to Update Dealer or Customer.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dc.id = int.Parse(txtID.Text);

            bool success = dcDal.Delete(dc);

            if (success == true)
            {
                MessageBox.Show("Dealer or Customer, Successfully Deleted.");
                Clear();
                DataTable dt = dcDal.Select();
                dgvDeaCust.DataSource = dt; 
            }
            else

            {

                MessageBox.Show("Failed to Delete");

            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;

            if (keyword!=null)
            {
                DataTable dt = dcDal.Search(keyword);
                dgvDeaCust.DataSource= dt;
            }
            else 
            {
                DataTable dt = dcDal.Select();
                dgvDeaCust.DataSource = dt;
            }
        }
    }
}
