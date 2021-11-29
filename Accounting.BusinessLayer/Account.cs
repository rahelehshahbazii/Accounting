using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting.ViewModel.Accounting;
using Accounting.DataLayer.Context;


namespace Accounting.BusinessLayer
{
   public class Account
    {
        public static ReportModel ReportFormMain()
        {
            ReportModel rp = new ReportModel();
            using (UnitOfWork db = new UnitOfWork())
            {
                DateTime startDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 01);
                DateTime endDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 30);

                var recive = db.AccountingRepository.Get(a => a.TypeID == 1 && a.DateTitle >= startDate && a.DateTitle <= endDate).Select(a => a.Amount).ToList();
                var pay = db.AccountingRepository.Get(a => a.TypeID == 2 && a.DateTitle >= startDate && a.DateTitle <= endDate).Select(a => a.Amount).ToList();

                rp.Recive = recive.Sum();
                rp.Pay = pay.Sum();
                rp.AccountReminder= (recive.Sum() - pay.Sum());
            }

            return rp;
        }
    }
}

