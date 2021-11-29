using Accounting.DataLayer.Context;
using Accounting.utility.Convertor;
using Accounting.ViewModel.Customers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting.App
{
    public partial class FrmReport : Form
    {

        public int TypeID = 0;
        public FrmReport()
        {
            InitializeComponent();
        }


        private void FrmReport_Load(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                List<ListCustomerViewModel> ListItems = new List<ListCustomerViewModel>();
                ListItems.Add(new ListCustomerViewModel()
                {
                    CustomerID = 0,
                    fullname = "انتخاب کنید"
                });

                ListItems.AddRange(db.CustomerRepository().GetNamesCustomers());

                Cbcustomer.DataSource = ListItems;       //db.CustomerRepository().GetNamesCustomers();
                Cbcustomer.ValueMember = "CustomerID";
                Cbcustomer.DisplayMember = "FullName";
            }

            if (TypeID == 1)
            {
                this.Text = "گزارش دریافتی ها";
            }
            else
            {
                this.Text = "گزارش پرداختی ها";
            }
        }

        private void BtnFilter_Click(object sender, EventArgs e)
        {
            filter();
        }

        void filter()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                List<DataLayer.Accounting> result = new List<DataLayer.Accounting>();

                DateTime? startDate;
                DateTime? endDate;
              

                if ((int)Cbcustomer.SelectedValue != 0)
                {
                    int customerId = int.Parse(Cbcustomer.SelectedValue.ToString());
                     
                    result.AddRange(db.AccountingRepository.Get(a => a.TypeID == TypeID && a.CostomerID == customerId));
                }
                else
                {
                    result.AddRange(db.AccountingRepository.Get(a => a.TypeID == TypeID));
                }

                if (txtfromdate.Text != "    /  /")
                {
                    startDate = Convert.ToDateTime(txtfromdate.Text);

                    startDate = DateConvertor.ToMiladi(startDate.Value);
                    result = result.Where(r => r.DateTitle >= startDate.Value).ToList();
                }
                if (txttodate.Text != "    /  /")
                {
                    endDate = Convert.ToDateTime(txttodate.Text);
                    endDate = DateConvertor.ToMiladi(endDate.Value);
                    result = result.Where(r => r.DateTitle >= endDate.Value).ToList();
                }

                //درسته ولی تاریخها میلادی نشون دده می شن.

                //  var result = db.AccountingRepository.Get(a => a.TypeID == TypeID);
                //  DgReport.AutoGenerateColumns = false;
                //  DgReport.DataSource = result;

                // برای اینکه تاریخ ها شمسی بشن.
                //  var result = db.AccountingRepository.Get(a => a.TypeID == TypeID);

                DgReport.Rows.Clear();

                foreach (var accounting in result)
                {
                    string customerName = db.CustomerRepository().GetCustomerNameByID(accounting.CostomerID);
                    DgReport.Rows.Add(accounting.ID, customerName, accounting.Amount, accounting.DateTitle.ToShamsi(), accounting.Description);
                }
            }
        }
        //


        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            filter();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {

            if (DgReport.CurrentRow != null)
            {
                int id = int.Parse(DgReport.CurrentRow.Cells[0].Value.ToString());
                if (RtlMessageBox.Show("آیا از حذف مطمئتن هستید ؟", "هشدار", MessageBoxButtons.YesNo) ==
                    DialogResult.Yes)
                {
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        db.AccountingRepository.Delete(id);
                        db.Save();
                        filter();
                    }
                }
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (DgReport.CurrentRow != null)
            {
                int id = Convert.ToInt32((DgReport.CurrentRow.Cells[0].Value.ToString()));
                frmmNewAccountingg frmNew = new frmmNewAccountingg();
                frmNew.AccountID = id;
                if (frmNew.ShowDialog() == DialogResult.OK)
                {
                    filter();
                }


            }
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            DataTable dtPrint = new DataTable();
            dtPrint.Columns.Add("Customer");
            dtPrint.Columns.Add("Amount");
            dtPrint.Columns.Add("Date");
            dtPrint.Columns.Add("Description");
            foreach (DataGridViewRow item in DgReport.Rows)
            {
                dtPrint.Rows.Add(
                    item.Cells[0].Value.ToString(),
                    item.Cells[1].Value.ToString(),
                    item.Cells[2].Value.ToString(),
                    item.Cells[3].Value.ToString()
                    );
            }
            stiPrint.Load(Application.StartupPath + "/Report.mrt");
            stiPrint.RegData("DT", dtPrint);
            stiPrint.Show();
        }
    }
}