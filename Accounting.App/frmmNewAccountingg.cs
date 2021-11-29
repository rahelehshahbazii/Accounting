using Accounting.DataLayer.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValidationComponents;

namespace Accounting.App
{
    public partial class frmmNewAccountingg : Form
    {

        public int AccountID = 0;
        // UnitOfWork db = new UnitOfWork();
        private UnitOfWork db;
        public frmmNewAccountingg()
        {
            InitializeComponent();
        }

        private void frmmNewAccountingg_Load(object sender, EventArgs e)
        {
            db = new UnitOfWork();
            Dgcustomers.AutoGenerateColumns = false;
            Dgcustomers.DataSource = db.CustomerRepository().GetNamesCustomers();

            if (AccountID !=0 )
            {
                var account = db.AccountingRepository.GetById(AccountID);
                txtAmount.Text = account.Amount.ToString();
                txtdescription.Text = account.Description;
                txtname.Text = db.CustomerRepository().GetCustomerNameByID(account.CostomerID);

                if (account.TypeID == 1)
                {
                    rbreceive.Checked = true;
                }
                else
                {
                    rbpay.Checked = true;
                }
                                
                this.Text = "ویرایش";
                BtnSave.Text = "ویرایش";
                db.Dispose();
                }
        }

        private void txtfilter_TextChanged(object sender, EventArgs e)
        {
            Dgcustomers.AutoGenerateColumns = false;
            Dgcustomers.DataSource = db.CustomerRepository().GetNamesCustomers(txtfilter.Text);
        }

        private void Dgcustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtname.Text = Dgcustomers.CurrentRow.Cells[0].Value.ToString();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))

                if (rbpay.Checked || rbreceive.Checked)
                {

                    db = new UnitOfWork();
                    DataLayer.Accounting accounting = new DataLayer.Accounting();

                    accounting.Amount = Convert.ToInt32(txtAmount.Value.ToString());
                    accounting.CostomerID = db.CustomerRepository().GetCustomerIDByName(txtname.Text);
                    accounting.TypeID = (rbreceive.Checked) ? 1 : 2;
                    accounting.DateTitle = DateTime.Now;
                    accounting.Description = txtdescription.Text;

                    if (AccountID == 0)
                    {

                        db.AccountingRepository.Insert(accounting);
                        
                    }
                    else
                    {
                        accounting.ID = AccountID;
                        db.AccountingRepository.Update(accounting);
                    }
                    db.Save();
                    db.Dispose();
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    RtlMessageBox.Show("لطفا نوع تراکنش را انتخاب کنید");
                }
        }
    }
}