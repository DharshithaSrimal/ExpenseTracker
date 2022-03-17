using ExpenseTracker.DataAccess;
using ExpenseTracker.Views;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ExpenseTracker.Controllers
{
    public class ReportController
    {
        private readonly ExpenseTrackerDataSet _dataset;

        private FinancialAccountController _financialAccountController;
        private CategoryController _categoryController;
        private PayeeController _payeeController;
        private EventController _eventController;

        public class ReportItem
        {
            public string Note;
            public decimal Amount;
            public string Account;
            //public int AccountId;
            public string Category;
            //public int CategoryId;
            public string Payee;
            //public int PayeeId;
            public string Event;
            //public int EventId;
            public DateTime DateTime;
        }

        public ReportController(ref ExpenseTrackerDataSet ds)
        {
            _dataset = ds;
            _financialAccountController = new FinancialAccountController(ref _dataset);
            _categoryController = new CategoryController(ref _dataset);
            _payeeController = new PayeeController(ref _dataset);
            _eventController = new EventController(ref _dataset);
        }

        public void ShowReportView()
        {
            Report report = new Report(this);
            report.ShowDialog();
        }

        public BindingSource GetAccountListBinding()
        {
            return _financialAccountController.GetAccountListBinding(
                Properties.Resources.DASHBOARD_ALL_ACCOUNTS,
                Common.ALL_ACCOUNTS_VALUE, null);
        }

        public BindingSource GetCategoryListBinding()
        {
            return _categoryController.GetCategoryListBinding(null,
                Properties.Resources.REPORT_ALL_CATEGORIES, Common.ALL_RECORDS_VALUE);
        }

        public BindingSource GetPayeeListBinding()
        {
            return _payeeController.GetPayeeListBinding(
                Properties.Resources.REPORT_ALL_PAYEES, Common.ALL_RECORDS_VALUE);
        }

        public BindingSource GetEventListBinging()
        {
            return _eventController.GetEventListBinding(
                Properties.Resources.REPORT_ALL_EVENTS, Common.ALL_RECORDS_VALUE);
        }

        public object UpdateFilterCriteria(int accountId, int categoryId, int payeeId,
            int eventId, DateTime startDate, DateTime endDate)
        {
            var filter = from t in _dataset.Transaction
                         select new
                         {
                             t.Note,
                             t.Amount,
                             Account = t.FinancialAccountRow.Name,
                             AccountId = t.FinancialAccount_Id,
                             Category = t.CategoryRow.Name,
                             CategoryId = t.Category_Id,
                             Payee = t.IsPayee_IdNull() ? null : t.PayeeRow.Name,
                             PayeeId = t.IsPayee_IdNull() ? 0 : t.Payee_Id,
                             Event = t.IsEvent_IdNull() ? null : t.EventRow.Name,
                             EventId = t.IsEvent_IdNull() ? 0 : t.Event_Id,
                             t.DateTime
                         };
            if (accountId != Common.ALL_ACCOUNTS_VALUE)
                filter = filter.Where(t => t.AccountId == accountId);
            if (categoryId != Common.ALL_RECORDS_VALUE)
                filter = filter.Where(t => t.CategoryId == categoryId);
            if (payeeId != Common.ALL_RECORDS_VALUE)
                filter = filter.Where(t => t.PayeeId == payeeId);
            if (eventId != Common.ALL_RECORDS_VALUE)
                filter = filter.Where(t => t.EventId == eventId);

            filter = filter.Where(t => t.DateTime > startDate && t.DateTime < endDate);

            return filter.ToList();
        }

    }
}
