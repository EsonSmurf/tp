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
    public partial class frmTransactions : Form
    {
        public frmTransactions()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        transactionDAL tdal = new transactionDAL();
        private void frmTransactions_Load(object sender, EventArgs e)
        {
            DataTable dt = tdal.DisplayAllTransaction();
            dgvTransactions.DataSource = dt;
        }

        private void cmbTransactionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string type = cmbTransactionType.Text;

            DataTable dt = tdal.DisplayTransactionByType(type);
            dgvTransactions.DataSource = dt;
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            DataTable dt = tdal.DisplayAllTransaction();
            dgvTransactions.DataSource = dt;
        }
    }
}
