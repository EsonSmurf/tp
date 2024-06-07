﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace TpProject.UI
{
    public partial class frmUsersDashboard : Form

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
        public frmUsersDashboard()
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
          //  User.FormBorderStyle = FormBorderStyle.None;
            //this.PnlFormLoader.Controls.Add();
            //User.Show();
        }
        public static string transactionType;
        private void frmUsersDashboard_Load(object sender, EventArgs e)
        {
            lblLoggedInUser.Text = frmLogin.loggedIn;
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            HomeTimer.Start();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
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
                    homeCollapsed = true;
                    HomeTimer.Stop();
                }
            }
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            transactionType = "Sales";
            frmPurchaseAndSales sales = new frmPurchaseAndSales();
       
            sales.Show();

           
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            transactionType = "Purchase";
            frmPurchaseAndSales purchase = new frmPurchaseAndSales();
            
           
            purchase.Show();
            


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

        private void frmUsersDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {

            frmLogin admin = new frmLogin();
            admin.Show();
            this.Hide();
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

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
