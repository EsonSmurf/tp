namespace TpProject
{
    partial class frmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.HomeTimer = new System.Windows.Forms.Timer(this.components);
            this.PnlFormLoader = new System.Windows.Forms.Panel();
            this.lblLoggedInUser = new System.Windows.Forms.Label();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuButton = new System.Windows.Forms.PictureBox();
            this.HomeContainer = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.inventoryButton = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.productButton = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.categoryButton = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.userButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonHome = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.transactions = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.DeaCust = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.btnSales = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.sidebar.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
            this.HomeContainer.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Click);
            // 
            // HomeTimer
            // 
            this.HomeTimer.Interval = 10;
            this.HomeTimer.Tick += new System.EventHandler(this.HomeTimer_Tick);
            // 
            // PnlFormLoader
            // 
            resources.ApplyResources(this.PnlFormLoader, "PnlFormLoader");
            this.PnlFormLoader.Name = "PnlFormLoader";
            this.PnlFormLoader.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlFormLoader_Paint);
            // 
            // lblLoggedInUser
            // 
            resources.ApplyResources(this.lblLoggedInUser, "lblLoggedInUser");
            this.lblLoggedInUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.lblLoggedInUser.Name = "lblLoggedInUser";
            this.lblLoggedInUser.Click += new System.EventHandler(this.lblLoggedInUser_Click);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.sidebar, "sidebar");
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Controls.Add(this.HomeContainer);
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.panel11);
            this.sidebar.Controls.Add(this.panel10);
            this.sidebar.Controls.Add(this.panel12);
            this.sidebar.Controls.Add(this.panel4);
            this.sidebar.ForeColor = System.Drawing.Color.White;
            this.sidebar.Name = "sidebar";
            this.sidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.menuButton);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // menuButton
            // 
            resources.ApplyResources(this.menuButton, "menuButton");
            this.menuButton.Name = "menuButton";
            this.menuButton.TabStop = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // HomeContainer
            // 
            resources.ApplyResources(this.HomeContainer, "HomeContainer");
            this.HomeContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.HomeContainer.Controls.Add(this.panel9);
            this.HomeContainer.Controls.Add(this.panel8);
            this.HomeContainer.Controls.Add(this.panel7);
            this.HomeContainer.Controls.Add(this.panel6);
            this.HomeContainer.Controls.Add(this.panel3);
            this.HomeContainer.Name = "HomeContainer";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.inventoryButton);
            resources.ApplyResources(this.panel9, "panel9");
            this.panel9.Name = "panel9";
            // 
            // inventoryButton
            // 
            this.inventoryButton.BackColor = System.Drawing.Color.MidnightBlue;
            resources.ApplyResources(this.inventoryButton, "inventoryButton");
            this.inventoryButton.ForeColor = System.Drawing.Color.White;
            this.inventoryButton.Name = "inventoryButton";
            this.inventoryButton.UseVisualStyleBackColor = false;
            this.inventoryButton.Click += new System.EventHandler(this.inventoryButton_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.productButton);
            resources.ApplyResources(this.panel8, "panel8");
            this.panel8.Name = "panel8";
            // 
            // productButton
            // 
            this.productButton.BackColor = System.Drawing.Color.MidnightBlue;
            resources.ApplyResources(this.productButton, "productButton");
            this.productButton.ForeColor = System.Drawing.Color.White;
            this.productButton.Name = "productButton";
            this.productButton.UseVisualStyleBackColor = false;
            this.productButton.Click += new System.EventHandler(this.invoicingButton_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.categoryButton);
            resources.ApplyResources(this.panel7, "panel7");
            this.panel7.Name = "panel7";
            // 
            // categoryButton
            // 
            this.categoryButton.BackColor = System.Drawing.Color.MidnightBlue;
            resources.ApplyResources(this.categoryButton, "categoryButton");
            this.categoryButton.ForeColor = System.Drawing.Color.White;
            this.categoryButton.Name = "categoryButton";
            this.categoryButton.UseVisualStyleBackColor = false;
            this.categoryButton.Click += new System.EventHandler(this.categoryButton_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.userButton);
            resources.ApplyResources(this.panel6, "panel6");
            this.panel6.Name = "panel6";
            // 
            // userButton
            // 
            this.userButton.BackColor = System.Drawing.Color.MidnightBlue;
            resources.ApplyResources(this.userButton, "userButton");
            this.userButton.ForeColor = System.Drawing.Color.White;
            this.userButton.Name = "userButton";
            this.userButton.UseVisualStyleBackColor = false;
            this.userButton.Click += new System.EventHandler(this.userButton_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonHome);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // buttonHome
            // 
            this.buttonHome.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.buttonHome, "buttonHome");
            this.buttonHome.ForeColor = System.Drawing.Color.White;
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.UseVisualStyleBackColor = false;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.transactions);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // transactions
            // 
            resources.ApplyResources(this.transactions, "transactions");
            this.transactions.Name = "transactions";
            this.transactions.UseVisualStyleBackColor = true;
            this.transactions.Click += new System.EventHandler(this.transactions_Click);
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.DeaCust);
            resources.ApplyResources(this.panel11, "panel11");
            this.panel11.Name = "panel11";
            // 
            // DeaCust
            // 
            resources.ApplyResources(this.DeaCust, "DeaCust");
            this.DeaCust.Name = "DeaCust";
            this.DeaCust.UseVisualStyleBackColor = true;
            this.DeaCust.Click += new System.EventHandler(this.DeaCust_Click);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.btnPurchase);
            resources.ApplyResources(this.panel10, "panel10");
            this.panel10.Name = "panel10";
            // 
            // btnPurchase
            // 
            resources.ApplyResources(this.btnPurchase, "btnPurchase");
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.UseVisualStyleBackColor = true;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.btnSales);
            resources.ApplyResources(this.panel12, "panel12");
            this.panel12.Name = "panel12";
            // 
            // btnSales
            // 
            resources.ApplyResources(this.btnSales, "btnSales");
            this.btnSales.Name = "btnSales";
            this.btnSales.UseVisualStyleBackColor = true;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnSettings);
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // btnSettings
            // 
            resources.ApplyResources(this.btnSettings, "btnSettings");
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // frmAdmin
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblLoggedInUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PnlFormLoader);
            this.Controls.Add(this.sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdmin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAdmin_FormClosed);
            this.Load += new System.EventHandler(this.frmAdminDashboard);
            this.sidebar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
            this.HomeContainer.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button transactions;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox menuButton;
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.Panel HomeContainer;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button inventoryButton;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button productButton;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button categoryButton;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button userButton;
        private System.Windows.Forms.Timer HomeTimer;
        private System.Windows.Forms.Panel PnlFormLoader;
        private System.Windows.Forms.Label lblLoggedInUser;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button DeaCust;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Label label2;
    }
}

