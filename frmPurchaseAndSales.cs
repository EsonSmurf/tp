using DGVPrinterHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using TpProject.BLL;
using TpProject.DAL;

namespace TpProject.UI
{
    public partial class frmPurchaseAndSales : Form
    {
        public frmPurchaseAndSales()
        {
            InitializeComponent();
        }
        DeaCustDAL dcDAL = new DeaCustDAL();
        productsDAL pDAL = new productsDAL();
        userDAL uDAL   = new userDAL();
        DataTable transactionDT = new DataTable();
        transactionDAL tDAL = new transactionDAL();
        transactionDetailDAL tdDAL = new transactionDetailDAL();

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmPurchaseAndSales_Load(object sender, EventArgs e)
        {
            string type = frmUsersDashboard.transactionType;

            lblTop.Text = type;

            transactionDT.Columns.Add("Product Name");
            transactionDT.Columns.Add("Rate");
            transactionDT.Columns.Add("Quantity");
            transactionDT.Columns.Add("Total");
        }

        private void txtDeaCustSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtDeaCustSearch.Text;

            if (keyword == "")
            {

                txtName.Text = "";
                txtEmail.Text = "";
                txtContact.Text = "";
                txtAddress.Text = "";
            }
            DeaCustBLL dc = dcDAL.SearchDealerCustomerForTransaction(keyword);

            txtName.Text = dc.name;
            txtEmail.Text = dc.email;
            txtContact.Text = dc.contact;
            txtAddress.Text = dc.address;

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;

            if (keyword == "")
            {
                txtProductName.Text = "";
                txtInventory.Text = "";
                txtRate.Text = "";
                txtQty.Text = "";
                return;
            
            }
            ProductsBLL p =pDAL.GetProductsForTransaction(keyword);

            txtProductName.Text = p.name;
            txtInventory.Text = p.qty.ToString();
            txtRate.Text= p.qty.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string productName = txtProductName.Text;
            decimal Rate = decimal.Parse(txtRate.Text);
            decimal Qty = decimal.Parse(txtQty.Text);

            decimal Total = Rate * Qty;

            decimal subTotal = decimal.Parse(txtSubTotal.Text);
            subTotal = subTotal + Total;
            if (productName == "")
            {
                MessageBox.Show("Select The Product First. Try Again. ");
            }
            else
            { 
            
                transactionDT.Rows.Add(productName, Rate, Qty, Total); 

                dgvAddedProducts.DataSource = transactionDT;
                txtSubTotal.Text = subTotal.ToString();

                txtSearch.Text = "";
                txtProductName.Text = "";
                txtInventory.Text = "0.00";
                txtRate.Text = "0.00";
                txtQty.Text = "0.00";
            }
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            string value = txtDiscount.Text;

            if (value == "")
            {
                MessageBox.Show("Please Add Discount First");
            }
            else
            {
                decimal subTotal = decimal.Parse(txtSubTotal.Text);
               decimal discount = decimal.Parse(txtDiscount.Text);
               decimal grandTotal = ((100-discount)/100) * subTotal;

                txtGrandTotal.Text = grandTotal.ToString();
            }
        }

        private void txtVat_TextChanged(object sender, EventArgs e)
        {
            string check = txtGrandTotal.Text;
            if (check == "")
            {
                MessageBox.Show("Calculate The Discount and Set The Grand Total First");
            }
            else
            { 
                decimal previousGT = decimal.Parse(txtGrandTotal.Text);
                decimal vat = decimal.Parse(txtVat.Text);
                decimal grandTotalWithVAT =((100+vat)/100) * previousGT;

                txtGrandTotal.Text = grandTotalWithVAT.ToString();
            }
        }

        private void txtPaidAmount_TextChanged(object sender, EventArgs e)
        {
            decimal grandTotal = decimal.Parse(txtGrandTotal.Text);
            decimal paidAmount = decimal.Parse(txtPaidAmount.Text);

            decimal returnAmount = paidAmount - grandTotal;

            txtReturnAmount.Text = returnAmount.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            transactionsBLL transaction = new transactionsBLL();

            transaction.type = lblTop.Text;

            string deaCustName = txtName.Text;

            DeaCustBLL dc = dcDAL.GetDeaCustIDFromName(deaCustName);

            transaction.dea_cust_id = dc.id;
            transaction.grandTotal = Math.Round(decimal.Parse(txtGrandTotal.Text),2);
            transaction.transaction_date = DateTime.Now;
            transaction.tax = decimal.Parse(txtVat.Text);
            transaction.discount = decimal.Parse(txtDiscount.Text);

            string username = frmLogin.loggedIn;

            userBLL u= uDAL.getIDFromUsername(username);

            transaction.added_by = u.id;
            transaction.transactionDetails = transactionDT;

            bool success = false;

            using (TransactionScope scope = new TransactionScope())
            {
                int transactionID = -1;

                bool w = tDAL.Insert_Transaction(transaction, out transactionID);

                for (int i = 0; i < transactionDT.Rows.Count; i++)
                {
                    transactionDetailBLL transactionDetail = new transactionDetailBLL();
                    string ProductName = transactionDT.Rows[i][0].ToString();

                    ProductsBLL p = pDAL.GetDeaProductIDFromName(ProductName);

                    transactionDetail.product_id = p.id;
                    transactionDetail.rate = decimal.Parse(transactionDT.Rows[i][1].ToString());
                    transactionDetail.qty = decimal.Parse(transactionDT.Rows[i][2].ToString());
                    transactionDetail.total = Math.Round(decimal.Parse(transactionDT.Rows[i][3].ToString()), 2);
                    transactionDetail.dea_cust_id = dc.id;
                    transactionDetail.added_date = DateTime.Now;
                    transactionDetail.added_by = u.id;

                    string transactionType = lblTop.Text;
                    bool x = false;
                    if (transactionType == "Purchase")
                    {
                        x = pDAL.IncreaseProduct(transactionDetail.product_id, transactionDetail.qty);
                    }
                    else if (transactionType == "Sales")
                    {

                        x = pDAL.DecreaseProduct(transactionDetail.product_id, transactionDetail.qty);
                    }

                    bool y = tdDAL.InsertTransactionDetail(transactionDetail);
                    success = w && x && y;
                }
                if (success == true)
                {

                    scope.Complete();

                    DGVPrinter printer = new DGVPrinter();

                    printer.Title = "\r\n\r\n INTUIT PRODUCT SYSTEM PVT, LTD.";
                    printer.SubTitle = "Bulacan, Philippines \r\n STI COLLEGE Balagtas ";
           
                    printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                    printer.PageNumbers = true;
                    printer.PageNumberInHeader = false;
                    printer.PorportionalColumns = true;
                    printer.HeaderCellAlignment = StringAlignment.Near;
                    printer.Footer = "Discount: " + txtDiscount.Text + "% \r\n " + "VAT: " + txtVat.Text + "%\r\n " + "Grand Total: " + "\r\n" + "All Rights Reserved. ";
                    printer.FooterSpacing = 15;
                    printer.PrintDataGridView(dgvAddedProducts);

                    MessageBox.Show("Transaction Completed Successfully");

                    dgvAddedProducts.DataSource = null;
                    dgvAddedProducts.Rows.Clear();

                    txtSearch.Text = "";
                    txtName.Text = "";
                    txtEmail.Text = "";
                    txtContact.Text = "";
                    txtAddress.Text = "";
                    txtDeaCustSearch.Text = "";
                    txtProductName.Text = "";
                    txtInventory.Text = "0";
                    txtRate.Text = "0";
                    txtQty.Text = "0";
                    txtSubTotal.Text = "0";
                    txtDiscount.Text = "0";
                    txtVat.Text = "0";
                    txtGrandTotal.Text = "0";
                    txtPaidAmount.Text = "0";
                    txtReturnAmount.Text = "0";
                }
                else
                {
                    MessageBox.Show("Transaction Failed");
                }
            
            
            }
        }
    }
}
