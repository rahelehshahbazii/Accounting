using Accounting.DataLayer;
using Accounting.DataLayer.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValidationComponents;



namespace Accounting.App
{
    public partial class frmAddOrEditCustomer : Form
    {

        public int customerid = 0;
        UnitOfWork db = new UnitOfWork();
        public frmAddOrEditCustomer()
        {
            InitializeComponent();
        }

        private void BtnAddPhoto_Click(object sender, EventArgs e)
        {

            OpenFileDialog openfile = new OpenFileDialog();
            if (openfile.ShowDialog() == DialogResult.OK)
            {

                OpenFileDialog openfile1 = new OpenFileDialog();
                pcCustomer.ImageLocation = openfile.FileName;
            }

        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {

                string imageName = Guid.NewGuid().ToString() + Path.GetExtension(pcCustomer.ImageLocation);
                                
                string path = Application.StartupPath + "/Images/";
              
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                pcCustomer.Image.Save(path + imageName);


                Customers customers = new Customers();
                customers.FullName = TxtName.Text;
                customers.Address = TxtAddress.Text;
                customers.Email = TxtEmail.Text;
                customers.Mobile = TxtMobile.Text;
                customers.CustomerImage = imageName;

                if (customerid == 0)
                {
                    db.CustomerRepository().InsertCustomer(customers);
                }
                else
                {
                    customers.CustomerID = customerid;
                    db.CustomerRepository().UpdateCustomer(customers);
                }

                db.CustomerRepository().Save();
                DialogResult = DialogResult.OK;
            }

        }
  
     private void frmAddOrEditCustomer_Load(object sender, EventArgs e)
        {
            if (customerid != 0)
            {
                this.Text = "ویرایش شخص";
                BtnSave.Text = "ویرایش";
                var customer = db.CustomerRepository().GetCustomerById(customerid);
                TxtEmail.Text = customer.Email;
                TxtAddress.Text = customer.Address;
                TxtMobile.Text = customer.Mobile;
                TxtName.Text = customer.FullName;
                pcCustomer.ImageLocation = Application.StartupPath + "/Images/" + customer.CustomerImage;
            }
        }

    }
  }

