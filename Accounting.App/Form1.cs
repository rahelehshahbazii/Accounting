using Accounting.utility.Convertor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accounting.ViewModel.Accounting;
using Accounting.BusinessLayer;


namespace Accounting.App
{
    public partial class frmmNewAccounting : Form
    {
        public frmmNewAccounting()
        {
            InitializeComponent();
        }

        private void BtnCustomers_Click(object sender, EventArgs e)
        {
            frmCustomers frmCustomers = new frmCustomers();
            frmCustomers.ShowDialog();
        }

        private void BtnNewAccounting_Click(object sender, EventArgs e)
        {
            frmmNewAccountingg frmNewAccounting = new frmmNewAccountingg();
            frmNewAccounting.ShowDialog();

        }

        private void BtnReportPay_Click(object sender, EventArgs e)
        {

            FrmReport frmReport = new FrmReport();
            frmReport.TypeID = 2;
            frmReport.ShowDialog();
           


        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FrmReport frmReport = new FrmReport();
            frmReport.TypeID = 1;
            frmReport.ShowDialog();
        }

        private void frmmNewAccounting_Load(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin frmLogin = new FrmLogin();
            if (frmLogin.ShowDialog() == DialogResult.OK)
            {
                this.Show();
                lblDate.Text = DateConvertor.ToShamsi(DateTime.Now);
                lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
                Report();
            }
            else
            {
                Application.Exit();
            }

         void Report()
             {
               
                //For receive output of Report
                ReportModel report = Account.ReportFormMain();
                lblPay.Text = report.Pay.ToString("#,0");
                lblRecive.Text = report.Recive.ToString("#,0");
                lblAccountReminder.Text = report.AccountReminder.ToString("#,0");
             }
        }
        private void btnEditLogin_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.isedit = true;
            frmLogin.ShowDialog();
        }
    }
}
