using ExpenseTracker.CustomControls;
using ExpenseTracker.DataAccess;
using ExpenseTracker.Views;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseTracker.Controllers
{
    public class DashboardController
    {
        private ExpenseTrackerDataSet _dataset;
        private Dashboard _dashboardView;

        private TransactionController _transactionController;
        private FinancialAccountController _financialAccountController;
        private CategoryController _categoryController;
        private PayeeController _payeeController;
        private EventController _eventController;
        private ReportController _reportController;
        private WeeklyViewController _weeklyViewController;
        private TransferController _transferController;

        internal FormClosedEventHandler editTxnFormClosedEvent { get; set; }

        public DashboardController()
        {
            Task datasetLoader = Task.Run(() =>
            {
                _dataset = DataManager.GetDataSetInstance();
            });
            datasetLoader.Wait();

            _financialAccountController = new FinancialAccountController(ref _dataset);
            _categoryController = new CategoryController(ref _dataset);
            _payeeController = new PayeeController(ref _dataset);
            _eventController = new EventController(ref _dataset);
            _transactionController = new TransactionController(
                ref _dataset,
                _financialAccountController,
                _categoryController,
                _payeeController,
                _eventController);
            _reportController = new ReportController(ref _dataset);
            _weeklyViewController = new WeeklyViewController(ref _dataset);
            _transferController = new TransferController(ref _dataset,
                _financialAccountController,
                _transactionController);

            _dashboardView = new Dashboard(this);
        }

        public bool IsFundTransferAvailable()
        {
            return _dataset.FinancialAccount.Count > 2;
        }

        public void MakeTransfer(FormClosedEventHandler makeTransfer_FormClosed)
        {
            _transferController.ShowView(makeTransfer_FormClosed);
        }

        public void ShowWeeklyView()
        {
            _weeklyViewController.ShowWeeklyView();
        }

        public void AddNewEvent()
        {
            _eventController.ShowAddNewView();
        }

        public void ShowReport()
        {
            _reportController.ShowReportView();
        }

        public void AddNewFinancialAccount(FormClosedEventHandler eventHandler)
        {
            _financialAccountController.ShowAddNewView(eventHandler);
        }

        public void AddNewCategory(FormClosedEventHandler eventHandler)
        {
            _categoryController.ShowAddNewView(eventHandler);
        }

        public void AddNewTransaction(FormClosedEventHandler eventHandler)
        {
            _transactionController.ShowAddNewView(eventHandler);
        }

        public void ShowView()
        {
            _dashboardView.ShowDialog();
        }

        //public void SetUpData()
        //{
        //    ExpenseTrackerDataSet.TransactionRow row = _dataset.Transaction.NewTransactionRow();
        //    row.Amount = 98745.61m;
        //    row.Note = "Some note - text text text";
        //    row.DateTime = DateTime.Now;
        //    row.Category_Id = 1;
        //    row.FinancialAccount_Id = 1;

        //    TransactionService ts = new TransactionService(ref _dataset);

        //    Task.Run(() => ts.AddAsync(row));
        //}

        public BindingSource GetAccountListBinding()
        {
            return _financialAccountController.GetAccountListBinding(
                Properties.Resources.DASHBOARD_ALL_ACCOUNTS,
                Common.ALL_ACCOUNTS_VALUE, null);
        }

        public List<TransactionListItem> GetRecentTransactionListItems(int accountId, int limit)
        {
            List<ExpenseTrackerDataSet.TransactionRow> rows = _transactionController.GetRecentTransactions(accountId, limit);
            List<TransactionListItem> list = new List<TransactionListItem>();

            foreach (ExpenseTrackerDataSet.TransactionRow row in rows)
            {
                string formattedAmount = Common.GetFormattedCurrency(row.Amount);
                TransactionListItem item = new TransactionListItem(row, formattedAmount, _transactionController, this);
                list.Add(item);
            }

            return list;
        }

        public decimal GetBalance(int accountId)
        {
            return _transactionController.GetBalance(accountId);
        }

    }
}
