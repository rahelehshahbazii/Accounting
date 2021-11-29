using Accounting.ViewModel.Customers;
using System.Collections.Generic;

namespace Accounting.DataLayer.Repositories
{
    public interface ICustomerRepository
    {
        List<Customers> GetAllCustomers();
        IEnumerable<Customers> GetCustomersByFilter(string parameter);
        List<ListCustomerViewModel> GetNamesCustomers(string filter = "");
        Customers GetCustomerById(int customerid);
        bool InsertCustomer(Customers customer);
        bool UpdateCustomer(Customers customer);
        bool DeleteCustomer(Customers customer);
        bool DeleteCustomer(int customerId);
        void Save();
        int GetCustomerIDByName(string name);
        string GetCustomerNameByID(int customerId);

        //List<Customers> GetAllCustomers();

        //IEnumerable<Customers> GetCustomersByFilter(string parameter);
        //List<ListCustomerViewModel> GetNamesCustomers(string filter = "");

        //Customers GetCustomerById(int customerid);
        //bool InsertCustomer(Customers customer);
        //bool UpdateCustomer(Customers customer);
        //bool DeleteCustomer(Customers customer);
        //bool DeleteCustomer(int customerId);
        //void Save();
        //int GetCustomerIDByName(string name);
        //string GetCustomerNameByID(int customerId);

    }
}
