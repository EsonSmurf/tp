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
using TpProject.UI;

namespace TpProject
{
    public partial class frmAdmin : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
            (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipes

            );
        bool sidebarExpand;
        bool homeCollapsed;
        public static string transactionType;
        public frmAdmin()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            label2.Text = "";
            this.PnlFormLoader.Controls.Clear();
            frmUsers User = new frmUsers()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
            };
            User.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(User);
            User.Show();


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonHome_Click (   object sender, EventArgs e) {

         

            HomeTimer.Start();
            
        }
    
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void sidebarTimer_Click(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

      

        private void HomeTimer_Tick(object sender, EventArgs e)
        {
            if (homeCollapsed)
            {
                HomeContainer.Height += 10;
                if (HomeContainer.Height == HomeContainer.MaximumSize.Height)
                {
                    homeCollapsed = false;
                    HomeTimer.Stop();
                }

            }
            else
            { 
                HomeContainer.Height -= 10;
                if (HomeContainer.Height == HomeContainer.MinimumSize.Height) 
                {
                    homeCollapsed=true;
                    HomeTimer.Stop();
                }
            }
        }

        private void userButton_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            this.PnlFormLoader.Controls.Clear();
            frmUsers User = new frmUsers()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
            };
            User.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(User);

            User.Show();


        }

        private void categoryButton_Click(object sender, EventArgs e)
        {
            this.PnlFormLoader.Controls.Clear();
            frmCategories Category = new frmCategories()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
            };
            Category.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(Category);

            Category.Show();
        }

        private void invoicingButton_Click(object sender, EventArgs e)
        {
            this.PnlFormLoader.Controls.Clear();
            frmProduct Product = new frmProduct()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
            };
            Product.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(Product);

            Product.Show();
        }
        private void inventoryButton_Click(object sender, EventArgs e)
        {
            this.PnlFormLoader.Controls.Clear();
            frmInventory Inventory = new frmInventory()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
            };
            Inventory.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(Inventory);

            Inventory.Show();
        }

        private void frmAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLogin admin = new frmLogin();
            admin.Show();
            this.Hide();
        }

        private void frmAdminDashboard(object sender, EventArgs e)
        {
            lblLoggedInUser.Text = frmLogin.loggedIn;
        }

        private void transactions_Click(object sender, EventArgs e)
        {
            this.PnlFormLoader.Controls.Clear();
            frmTransactions Transaction = new frmTransactions()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
            };
            Transaction.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(Transaction);

            Transaction.Show();
        }

        private void PnlFormLoader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DeaCust_Click(object sender, EventArgs e)
        {
            this.PnlFormLoader.Controls.Clear();
            frmDeaCust DeaCust = new frmDeaCust()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
            };
            DeaCust.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(DeaCust);

            DeaCust.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblLoggedInUser_Click(object sender, EventArgs e)
        {

        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            
            transactionType = "Purchase";
            frmPurchaseAndSales purchase = new frmPurchaseAndSales();
            
           
            purchase.Show();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            transactionType = "Sales";
            frmPurchaseAndSales sales = new frmPurchaseAndSales();

            sales.Show();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();

            login.Show();
        }
    }
}
