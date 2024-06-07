using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using TpProject.BLL;
using TpProject.DAL;
using TpProject.UI;

namespace TpProject
{
    public partial class frmUsers : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
             int nLeft,
             int nTop,
             int nRight,
             int nBottom,
             int nWidthEllipse,
             int nHeightEllipse
            );
        public frmUsers()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        userBLL u = new userBLL();
        userDAL dal = new userDAL();
        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {

            DataTable dt = dal.Select();
            dgvUsers.DataSource = dt;

            btnAdd.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnAdd.Width, btnAdd.Height, 30, 30));
            btnDelete.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnDelete.Width, btnDelete.Height, 30, 30));
            btnUpdate.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnUpdate.Width, btnUpdate.Height, 30, 30));

           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           

            u.first_name = txtFirstName.Text;
            u.last_name = txtLastName.Text;
            u.email = txtEmail.Text;
            u.username = txtUsername.Text;
            u.password = txtPassword.Text;
            u.contact = txtContact.Text;
            u.address = txtAddress.Text;
            u.gender = cmbGender.Text;
            u.user_type = cmbUsertype.Text;
            u.added_date = DateTime.Now;

            string loggedUser = frmLogin.loggedIn;
            userBLL usr = dal.getIDFromUsername(loggedUser);

            u.added_by = usr.id;



            bool success = dal.Insert(u);
            if (success == true)
            {

                MessageBox.Show("User succesfully created.");
                clear();
            }
            else
            {
                MessageBox.Show("Failed to add new user");
            }

            DataTable dt = dal.Select();
            dgvUsers.DataSource = dt;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            u.id = Convert.ToInt32(txtID.Text);
            u.first_name = txtFirstName.Text;
            u.last_name = txtLastName.Text;
            u.email = txtEmail.Text;
            u.username = txtUsername.Text;
            u.password = txtPassword.Text;
            u.contact = txtContact.Text;
            u.address = txtAddress.Text;
            u.gender = cmbGender.Text;
            u.user_type = cmbUsertype.Text;
            u.added_date = DateTime.Now;
            u.added_by = 1;

            bool success = dal.Update(u);

            if (success == true)
            {

                MessageBox.Show("User succesfully updated.");
                clear();
            }
            else
            {
                MessageBox.Show("Failed to update user");
            }
            DataTable dt = dal.Select();
            dgvUsers.DataSource = dt;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            u.id = Convert.ToInt32(txtID.Text);

            bool success = dal.Delete(u);
            if (success == true)
            {

                MessageBox.Show("User succesfully deleted.");
                clear();
            }
            else
            {
                MessageBox.Show("Failed to delete user");
            }
            DataTable dt = dal.Select();
            dgvUsers.DataSource = dt;
        }

        private void btnAdd_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void pbImage_Click(object sender, EventArgs e)
        {

        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }
        private void clear()
        {
            txtID.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtAddress.Text = "";
            txtContact.Text = "";
            cmbGender.Text = "";
            cmbUsertype.Text = "";
            txtEmail.Text = "";




        }

        private void dgvUsers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtID.Text = dgvUsers.Rows[rowIndex].Cells[0].Value.ToString();
            txtFirstName.Text = dgvUsers.Rows[rowIndex].Cells[1].Value.ToString();
            txtLastName.Text = dgvUsers.Rows[rowIndex].Cells[2].Value.ToString();
            txtEmail.Text = dgvUsers.Rows[rowIndex].Cells[3].Value.ToString();
            txtUsername.Text = dgvUsers.Rows[rowIndex].Cells[4].Value.ToString();
            txtPassword.Text = dgvUsers.Rows[rowIndex].Cells[5].Value.ToString();
            txtContact.Text = dgvUsers.Rows[rowIndex].Cells[6].Value.ToString();
            txtAddress.Text = dgvUsers.Rows[rowIndex].Cells[7].Value.ToString();
            cmbGender.Text = dgvUsers.Rows[rowIndex].Cells[8].Value.ToString();
            cmbUsertype.Text = dgvUsers.Rows[rowIndex].Cells[9].Value.ToString();

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keywords =txtSearch.Text;

            if (keywords!=null)
            {
                DataTable dt = dal.Search(keywords);
                dgvUsers.DataSource = dt;
            }
            else
            {
                DataTable dt = dal.Select();
                dgvUsers.DataSource = dt;
            }
        }
    }

       
    }