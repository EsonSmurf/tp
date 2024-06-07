namespace TpProject.UI
{
    partial class frmUsersDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsersDashboard));
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuButton = new System.Windows.Forms.PictureBox();
            this.HomeContainer = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.inventoryButton = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnSales = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonHome = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.transactions = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnAbout = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.HomeTimer = new System.Windows.Forms.Timer(this.components);
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.PnlFormLoader = new System.Windows.Forms.Panel();
            this.lblLoggedInUser = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sidebar.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
            this.HomeContainer.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.Transparent;
            this.sidebar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sidebar.BackgroundImage")));
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Controls.Add(this.HomeContainer);
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.panel5);
            this.sidebar.Controls.Add(this.panel4);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.ForeColor = System.Drawing.Color.White;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.MaximumSize = new System.Drawing.Size(210, 571);
            this.sidebar.MinimumSize = new System.Drawing.Size(64, 571);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(210, 571);
            this.sidebar.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.menuButton);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.panel2.Size = new System.Drawing.Size(242, 103);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Garamond", 12F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(66, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu";
            // 
            // menuButton
            // 
            this.menuButton.Image = ((System.Drawing.Image)(resources.GetObject("menuButton.Image")));
            this.menuButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menuButton.Location = new System.Drawing.Point(21, 29);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(31, 30);
            this.menuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menuButton.TabIndex = 0;
            this.menuButton.TabStop = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // HomeContainer
            // 
            this.HomeContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.HomeContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.HomeContainer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HomeContainer.BackgroundImage")));
            this.HomeContainer.Controls.Add(this.panel9);
            this.HomeContainer.Controls.Add(this.panel8);
            this.HomeContainer.Controls.Add(this.panel7);
            this.HomeContainer.Controls.Add(this.panel3);
            this.HomeContainer.Location = new System.Drawing.Point(3, 112);
            this.HomeContainer.MaximumSize = new System.Drawing.Size(225, 172);
            this.HomeContainer.MinimumSize = new System.Drawing.Size(225, 55);
            this.HomeContainer.Name = "HomeContainer";
            this.HomeContainer.Size = new System.Drawing.Size(225, 55);
            this.HomeContainer.TabIndex = 3;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.inventoryButton);
            this.panel9.Location = new System.Drawing.Point(4, 130);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.panel9.Size = new System.Drawing.Size(221, 42);
            this.panel9.TabIndex = 6;
            // 
            // inventoryButton
            // 
            this.inventoryButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.inventoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inventoryButton.Font = new System.Drawing.Font("Garamond", 12F);
            this.inventoryButton.ForeColor = System.Drawing.Color.White;
            this.inventoryButton.Image = ((System.Drawing.Image)(resources.GetObject("inventoryButton.Image")));
            this.inventoryButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inventoryButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.inventoryButton.Location = new System.Drawing.Point(-7, -13);
            this.inventoryButton.Name = "inventoryButton";
            this.inventoryButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.inventoryButton.Size = new System.Drawing.Size(252, 59);
            this.inventoryButton.TabIndex = 3;
            this.inventoryButton.Text = "            Inventory";
            this.inventoryButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inventoryButton.UseVisualStyleBackColor = false;
            this.inventoryButton.Click += new System.EventHandler(this.inventoryButton_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnSales);
            this.panel8.Location = new System.Drawing.Point(2, 92);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.panel8.Size = new System.Drawing.Size(221, 40);
            this.panel8.TabIndex = 5;
            // 
            // btnSales
            // 
            this.btnSales.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSales.Font = new System.Drawing.Font("Garamond", 12F);
            this.btnSales.ForeColor = System.Drawing.Color.White;
            this.btnSales.Image = ((System.Drawing.Image)(resources.GetObject("btnSales.Image")));
            this.btnSales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSales.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSales.Location = new System.Drawing.Point(-8, -9);
            this.btnSales.Name = "btnSales";
            this.btnSales.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnSales.Size = new System.Drawing.Size(252, 59);
            this.btnSales.TabIndex = 3;
            this.btnSales.Text = "             Sales";
            this.btnSales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSales.UseVisualStyleBackColor = false;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnPurchase);
            this.panel7.Location = new System.Drawing.Point(1, 58);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.panel7.Size = new System.Drawing.Size(221, 38);
            this.panel7.TabIndex = 4;
            // 
            // btnPurchase
            // 
            this.btnPurchase.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPurchase.Font = new System.Drawing.Font("Garamond", 12F);
            this.btnPurchase.ForeColor = System.Drawing.Color.White;
            this.btnPurchase.Image = ((System.Drawing.Image)(resources.GetObject("btnPurchase.Image")));
            this.btnPurchase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPurchase.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPurchase.Location = new System.Drawing.Point(-8, -9);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnPurchase.Size = new System.Drawing.Size(252, 52);
            this.btnPurchase.TabIndex = 3;
            this.btnPurchase.Text = "             Purchase";
            this.btnPurchase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPurchase.UseVisualStyleBackColor = false;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonHome);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.panel3.Size = new System.Drawing.Size(221, 49);
            this.panel3.TabIndex = 2;
            // 
            // buttonHome
            // 
            this.buttonHome.BackColor = System.Drawing.Color.Transparent;
            this.buttonHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonHome.BackgroundImage")));
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Font = new System.Drawing.Font("Garamond", 12F);
            this.buttonHome.ForeColor = System.Drawing.Color.White;
            this.buttonHome.Image = ((System.Drawing.Image)(resources.GetObject("buttonHome.Image")));
            this.buttonHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHome.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonHome.Location = new System.Drawing.Point(-8, -5);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonHome.Size = new System.Drawing.Size(252, 59);
            this.buttonHome.TabIndex = 3;
            this.buttonHome.Text = "            List";
            this.buttonHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHome.UseVisualStyleBackColor = false;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.transactions);
            this.panel1.Location = new System.Drawing.Point(3, 173);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.panel1.Size = new System.Drawing.Size(221, 49);
            this.panel1.TabIndex = 4;
            // 
            // transactions
            // 
            this.transactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transactions.Font = new System.Drawing.Font("Garamond", 12F);
            this.transactions.Image = ((System.Drawing.Image)(resources.GetObject("transactions.Image")));
            this.transactions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.transactions.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.transactions.Location = new System.Drawing.Point(-8, -5);
            this.transactions.Name = "transactions";
            this.transactions.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.transactions.Size = new System.Drawing.Size(235, 59);
            this.transactions.TabIndex = 3;
            this.transactions.Text = "            Transactions";
            this.transactions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.transactions.UseVisualStyleBackColor = true;
            this.transactions.Click += new System.EventHandler(this.transactions_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnAbout);
            this.panel5.Location = new System.Drawing.Point(3, 228);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.panel5.Size = new System.Drawing.Size(221, 49);
            this.panel5.TabIndex = 5;
            // 
            // btnAbout
            // 
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Garamond", 12F);
            this.btnAbout.Image = ((System.Drawing.Image)(resources.GetObject("btnAbout.Image")));
            this.btnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAbout.Location = new System.Drawing.Point(-8, -5);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnAbout.Size = new System.Drawing.Size(235, 59);
            this.btnAbout.TabIndex = 3;
            this.btnAbout.Text = "            About";
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnSettings);
            this.panel4.Location = new System.Drawing.Point(3, 283);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.panel4.Size = new System.Drawing.Size(221, 49);
            this.panel4.TabIndex = 5;
            // 
            // btnSettings
            // 
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Garamond", 12F);
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSettings.Location = new System.Drawing.Point(-8, -5);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnSettings.Size = new System.Drawing.Size(235, 59);
            this.btnSettings.TabIndex = 3;
            this.btnSettings.Text = "            Logout";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.UseVisualStyleBackColor = true;
            // 
            // HomeTimer
            // 
            this.HomeTimer.Interval = 10;
            this.HomeTimer.Tick += new System.EventHandler(this.HomeTimer_Tick);
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // PnlFormLoader
            // 
            this.PnlFormLoader.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlFormLoader.Location = new System.Drawing.Point(210, 33);
            this.PnlFormLoader.Name = "PnlFormLoader";
            this.PnlFormLoader.Size = new System.Drawing.Size(876, 535);
            this.PnlFormLoader.TabIndex = 5;
            // 
            // lblLoggedInUser
            // 
            this.lblLoggedInUser.AutoSize = true;
            this.lblLoggedInUser.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblLoggedInUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.lblLoggedInUser.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblLoggedInUser.Location = new System.Drawing.Point(1008, 11);
            this.lblLoggedInUser.Name = "lblLoggedInUser";
            this.lblLoggedInUser.Size = new System.Drawing.Size(78, 13);
            this.lblLoggedInUser.TabIndex = 6;
            this.lblLoggedInUser.Text = "Jayson Visnar";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 9.75F);
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(968, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 27);
            this.label2.TabIndex = 4;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // frmUsersDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 568);
            this.Controls.Add(this.lblLoggedInUser);
            this.Controls.Add(this.PnlFormLoader);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUsersDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserDashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmUsersDashboard_FormClosed);
            this.Load += new System.EventHandler(this.frmUsersDashboard_Load);
            this.sidebar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
            this.HomeContainer.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox menuButton;
        private System.Windows.Forms.Panel HomeContainer;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button inventoryButton;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button transactions;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Timer HomeTimer;
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.Panel PnlFormLoader;
        private System.Windows.Forms.Label lblLoggedInUser;
        private System.Windows.Forms.Label label2;
    }
}