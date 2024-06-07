using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TpProject.BLL;
using TpProject.DAL;

namespace TpProject.UI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
         loginBLL l = new loginBLL();
         loginDAL dal = new loginDAL();
        public static string loggedIn;

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]

        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]

        private static extern bool ReleaseCapture();

        private void frmLogin_Load_1(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            int radius = 30;

            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(this.Width - radius, 0, radius , radius , 270, 90);
            path.AddArc(this.Width - radius, this.Height - radius , radius, radius ,0,90);
            path.AddArc(0, this.Height - radius, radius, radius, 90, 90);

            this.Region = new Region(path);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            l.username = txtUsername.Text.Trim();
            l.password = txtPassword.Text.Trim();
            l.user_type = cmbUserType.Text.Trim();

            bool success = dal.LoginCheck(l);
            if (success == true)
            {
                MessageBox.Show("Login Successful");
                loggedIn = l.username;
                switch (l.user_type)
                {
                    case "Admin":
                        { 
                            frmAdmin admin = new frmAdmin();
                            admin.Show();
                            this.Hide();
                        }
                        break;

                    case "User":
                        {
                            frmUsersDashboard user = new frmUsersDashboard();
                            user.Show();
                            this.Hide();
                        }
                        break;

                    default:
                        {
                            MessageBox.Show("Invalid User Tyoe.");

                        }
                        break;
                }
            } 
            else
            {

                MessageBox.Show("Login Failed, Try Again");
            }
        }
    }
}
