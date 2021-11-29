using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting.DataLayer;
using Accounting.DataLayer.Repositories;
using Accounting.DataLayer.Services;
using Accounting.DataLayer.Context;



namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            UnitOfWork db = new UnitOfWork();
            var list = db.CustomerRepository().GetAllCustomers();
                       
   // Accounting_DBEntities db=new Accounting_DBEntities();
            // ICustomerRepository customer = new CustomerRepository(db);
           // ICustomerRepository customer = new customerrepository(db);
          //// ICustomerRepository customer = new CustomerRepository(db); 
          // var list = customer.GetAllCustomers();
           // //Customers AddCustomer = new Customers()
           // //{
           // //    FullName = "علی محمدی",
           // //    CustomerImage = "NoPhoto",
           // //    Mobile = "09351212125"

           // //};
          
           // //customer.InsertCustomer(AddCustomer);
           // //customer.Save();
      }
    }
   
}

