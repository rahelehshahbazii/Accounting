using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accounting.DataLayer;
using Accounting.DataLayer.Context;

namespace Accounting.App
{
    public partial class frmCustomers : Form
    {

       
        public frmCustomers()
        {
            InitializeComponent();
        }

        private void frmCustomers_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        void BindGrid()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                DgCustomers.AutoGenerateColumns = false;
                DgCustomers.DataSource = db.CustomerRepository().GetAllCustomers();
            }
        }

        private void BtnRefreshCustomer_Click(object sender, EventArgs e)
        {
            txtfilter.Text = "";
            BindGrid();
        }
        private void txtfilter_TextChanged(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {


                DgCustomers.DataSource = db.CustomerRepository().GetCustomersByFilter(txtfilter.Text);
            }
        }

        private void BtnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (DgCustomers.CurrentRow != null)
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    string name = DgCustomers.CurrentRow.Cells[1].Value.ToString();
                    if (RtlMessageBox.Show($"آیا از حذف {name} مطمئن هستید ؟", "توجه", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        int customerId = int.Parse(DgCustomers.CurrentRow.Cells[0].Value.ToString());
                        db.CustomerRepository().DeleteCustomer(customerId);
                        db.CustomerRepository().Save();
                        BindGrid();
                    }
                    else
                    {
                        RtlMessageBox.Show("لطفا شخصی را انتخاب کنید");
                    }
                }
            }
        }

        private void BtnAddNew_Click(object sender, EventArgs e)
        {
            frmAddOrEditCustomer frmAdd = new frmAddOrEditCustomer();
            if( frmAdd.ShowDialog()==DialogResult.OK)
            {
                BindGrid();
            }
            
        }

        private void BtnEditCustomer_Click(object sender, EventArgs e)
        {
                if (DgCustomers.CurrentRow != null)
                {
                    int customerId = int.Parse(DgCustomers.CurrentRow.Cells[0].Value.ToString());

                    frmAddOrEditCustomer frmaddoredit = new frmAddOrEditCustomer();
                    frmaddoredit.customerid = customerId;

                    if (frmaddoredit.ShowDialog() == DialogResult.OK)
                    {
                        BindGrid();
                    }
                }
            }
        }
    }
    