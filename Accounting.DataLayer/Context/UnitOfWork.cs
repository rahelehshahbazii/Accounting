using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting.DataLayer.Repositories;
using Accounting.DataLayer.Services;
using Accounting.DataLayer.Context;
namespace Accounting.DataLayer.Context
{
    public class UnitOfWork : IDisposable
    {

        Accounting_DBEntities db = new Accounting_DBEntities();

        private ICustomerRepository _CustomerRepository;

        private GenericRepository<Accounting> _accountingRepository;
        public GenericRepository<Accounting> AccountingRepository
        {

         get
            {
             
                if (_accountingRepository == null)
                {
                    _accountingRepository = new GenericRepository<Accounting>(db);
                }

                return _accountingRepository;
            }
        }

        public object LoginRepository()
        {
            throw new NotImplementedException();
        }

        private GenericRepository<Login> _loginRepository;

        public GenericRepository<Login> loginRepository
        {
            get
            {
                if (_loginRepository == null)
                {
                    _loginRepository = new GenericRepository<Login>(db);
                }
                return _loginRepository;
            }
        }


        public ICustomerRepository CustomerRepository()
                {
                    if (_CustomerRepository == null)
                    {
                        _CustomerRepository = new CustomerRepository(db);
                    }
                    return _CustomerRepository;
                }

           public void Dispose()
        {
            db.Dispose();
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
   
}











