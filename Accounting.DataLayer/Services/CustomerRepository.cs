using Accounting.DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Accounting.ViewModel.Customers;

namespace Accounting.DataLayer.Services
{
    public class CustomerRepository: ICustomerRepository
    {
        // Accounting_DBEntities db=new Accounting_DBEntities;

        // for constructor injection : 
        Accounting_DBEntities db;
        public CustomerRepository(Accounting_DBEntities context)
        {
            db = context;
        }

        // for constructor injection : 

        public bool DeleteCustomer(Customers customer)
        {

            try
            {
                db.Entry(customer).State = EntityState.Deleted;
                return true;

            }
            catch
            {
                return false;
            }
        }

        public bool DeleteCustomer(int customerId)
        {

            var customer = GetCustomerById(customerId);
            DeleteCustomer(customer);
            return true;

        }

        public List<Customers> GetAllCustomers()
        {
            return db.Customers.ToList();
        }

        public IEnumerable<Customers> GetCustomersByFilter(string parameter)
        {
            return db.Customers.Where(c =>
            c.FullName.Contains(parameter) || c.Email.Contains(parameter) || c.Mobile.Contains(parameter)).ToList();
        }

        public List<ListCustomerViewModel> GetNamesCustomers(string filter = "")
        {
            if (filter == "")
            {
                return db.Customers.Select(c => new ListCustomerViewModel()
                {
                    CustomerID = c.CustomerID,
                    fullname = c.FullName
                }
                    )
                .ToList();
            }

            return db.Customers.Where(c => c.FullName.Contains(filter)).Select(c => new ListCustomerViewModel()
            {
                CustomerID = c.CustomerID,
                fullname = c.FullName

            }
                    )
                .ToList();
        }

        public Customers GetCustomerById(int customerid)
        {
            return db.Customers.Find(customerid);
        }

        public bool InsertCustomer(Customers customer)
        {
            try
            {
                db.Customers.Add(customer);
                return true;
            }
            catch
            {
                return false;
            }

        }
        public bool UpdateCustomer(Customers customer)
        {
            var local = db.Set<Customers>()
          .Local
          .FirstOrDefault(f => f.CustomerID == customer.CustomerID);
            if (local != null)
            {
                db.Entry(local).State = EntityState.Detached;
            }
            db.Entry(customer).State = EntityState.Modified;
            return true;
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public int GetCustomerIDByName(string name)
        {
            return db.Customers.First(c => c.FullName == name).CustomerID;
        }

        public string GetCustomerNameByID(int customerId)
        {
            return db.Customers.Find(customerId).FullName;
        }

      
      }

 
       

    }


