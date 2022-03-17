using ExpenseTracker.DataAccess;
using ExpenseTracker.DataAccess.Services;
using ExpenseTracker.Views.Transaction;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseTracker.Controllers
{
    public class TransactionController
    {
        private readonly ExpenseTrackerDataSet _dataset;
        private readonly TransactionService _transactionService;

        private readonly FinancialAccountController _accountController;
        private readonly CategoryController _categoryController;
        private readonly PayeeController _payeeController;
        private readonly EventController _eventController;

        public TransactionController(
            ref ExpenseTrackerDataSet ds,
            FinancialAccountController accountController,
            CategoryController categoryController,
            PayeeController payeeController,
            EventController eventController)
        {
            _dataset = ds;
            _transactionService = new TransactionService(ref ds);
            _accountController = accountController;
            _categoryController = categoryController;
            _payeeController = payeeController;
            _eventController = eventController;
        }

        public void ShowAddNewView(FormClosedEventHandler eventHandler)
        {
            AddTransaction addNewView = new AddTransaction(this);
            addNewView.FormClosed += eventHandler;
            addNewView.ShowDialog();
        }

        public void ShowEditView(ExpenseTrackerDataSet.TransactionRow transaction,
            FormClosedEventHandler eventHandler)
        {
            EditTransaction editTransaction = new EditTransaction(this, transaction);
            editTransaction.FormClosed += eventHandler;
            editTransaction.ShowDialog();
        }

        public List<ExpenseTrackerDataSet.TransactionRow> GetRecentTransactions(int accountId, int limit)
        {
            List<ExpenseTrackerDataSet.TransactionRow> list = null;

            if (accountId != Common.ALL_ACCOUNTS_VALUE)
            {
                list = _dataset.Transaction
                    .Where(t => t.FinancialAccount_Id == accountId)
                    .OrderByDescending(t => t.DateTime)
                    .Take((limit != Common.ALL_RECORDS_VALUE) ? limit : int.MaxValue)
                    .ToList();
            }
            else
            {
                list = _dataset.Transaction
                    .OrderByDescending(t => t.DateTime)
                    .Take((limit != Common.ALL_RECORDS_VALUE) ? limit : int.MaxValue)
                    .ToList();
            }

            return list;
        }

        public decimal GetBalance(int accountId)
        {
            decimal balance, initial, income, expense;

            if (accountId == Common.ALL_ACCOUNTS_VALUE)
            {
                initial = _dataset.Transaction
                    .Where(t => t.CategoryRow.Type == (int)CategoryType.Initial)
                    .Sum(t => t.Amount);
                income = _dataset.Transaction
                    .Where(t => t.CategoryRow.Type == (int)CategoryType.Income)
                    .Sum(t => t.Amount);
                expense = _dataset.Transaction
                    .Where(t => t.CategoryRow.Type == (int)CategoryType.Expense)
                    .Sum(t => t.Amount);
                balance = initial + income - expense;
            }
            else
            {
                initial = _dataset.Transaction
                    .Where(t => t.FinancialAccount_Id == accountId)
                    .Where(t => t.CategoryRow.Type == (int)CategoryType.Initial)
                    .Sum(t => t.Amount);
                income = _dataset.Transaction
                    .Where(t => t.FinancialAccount_Id == accountId)
                    .Where(t => t.CategoryRow.Type == (int)CategoryType.Income)
                    .Sum(t => t.Amount);
                expense = _dataset.Transaction
                    .Where(t => t.FinancialAccount_Id == accountId)
                    .Where(t => t.CategoryRow.Type == (int)CategoryType.Expense)
                    .Sum(t => t.Amount);
                balance = initial + income - expense;
            }

            return balance;
        }

        public Task  SaveAsync(int id, decimal amount, string note, DateTime dateTime,
            int categoryId, int financialAccountId, string payeeName, string eventName)
        {
            return Task.Run(() => Save(id, amount, note, dateTime,
            categoryId, financialAccountId, payeeName, eventName));
        }

        public void Save(int id, decimal amount, string note, DateTime dateTime,
            int categoryId, int financialAccountId, string payeeName, string eventName)
        {
            int? payeeId, eventId;

            if (string.IsNullOrWhiteSpace(payeeName))
            {
                payeeId = null;
            }
            else
            {
                ExpenseTrackerDataSet.PayeeRow payee = _dataset.Payee.Where
                    (p => p.Name.Equals(payeeName)).FirstOrDefault();
                if (payee != null)
                {
                    payeeId = payee.Id;
                }
                else
                {
                    payeeId = _payeeController.SaveNew(payeeName, null, null, null, null);
                }
            }

            if (string.IsNullOrWhiteSpace(eventName))
            {
                eventId = null;
            }
            else
            {
                ExpenseTrackerDataSet.EventRow eventRow = _dataset.Event.Where
                    (e => e.Name.Equals(eventName)).FirstOrDefault();
                if (eventRow != null)
                {
                    eventId = eventRow.Id;
                }
                else
                {
                    eventId = _eventController.SaveNew(eventName, null, dateTime, null, null, null);
                }
            }

            ExpenseTrackerDataSet.TransactionRow row = _dataset.Transaction.FindById(id);
            row.Amount = amount;
            row.Note = note;
            row.DateTime = dateTime;
            row.Category_Id = categoryId;
            row.FinancialAccount_Id = financialAccountId;
            row.SysGenerated = false;
            if (payeeId.HasValue)
                row.Payee_Id = payeeId.Value;
            if (eventId.HasValue)
                row.Event_Id = eventId.Value;

            Task.Run(() => _transactionService.UpdateAsync(row));
        }

        private void SaveNew(decimal amount, string note, DateTime dateTime,
            int categoryId, int financialAccountId, string payeeName, string eventName)
        {
            int? payeeId, eventId;

            if (string.IsNullOrWhiteSpace(payeeName))
            {
                payeeId = null;
            }
            else
            {
                ExpenseTrackerDataSet.PayeeRow payee = _dataset.Payee.Where
                    (p => p.Name.Equals(payeeName)).FirstOrDefault();
                if (payee != null)
                {
                    payeeId = payee.Id;
                }
                else
                {
                    payeeId = _payeeController.SaveNew(payeeName, null, null, null, null);
                }
            }

            if (string.IsNullOrWhiteSpace(eventName))
            {
                eventId = null;
            }
            else
            {
                ExpenseTrackerDataSet.EventRow eventRow = _dataset.Event.Where
                    (e => e.Name.Equals(eventName)).FirstOrDefault();
                if (eventRow != null)
                {
                    eventId = eventRow.Id;
                }
                else
                {
                    eventId = _eventController.SaveNew(eventName, null, dateTime, null, null, null);
                }
            }

            ExpenseTrackerDataSet.TransactionRow row = _dataset.Transaction.NewTransactionRow();
            row.Amount = amount;
            row.Note = note;
            row.DateTime = dateTime;
            row.Category_Id = categoryId;
            row.FinancialAccount_Id = financialAccountId;
            row.SysGenerated = false;
            if (payeeId.HasValue)
                row.Payee_Id = payeeId.Value;
            if (eventId.HasValue)
                row.Event_Id = eventId.Value;

            Task.Run(() => _transactionService.AddAsync(row));
        }

        public Task SaveNewAsync(decimal amount, string note, DateTime dateTime,
            int categoryId, int financialAccountId, string payeeName, string eventName)
        {
            return Task.Run(() => SaveNew(amount, note, dateTime, categoryId, financialAccountId,
                payeeName, eventName));
        }

        public BindingSource GetFinancialAccountListBinding()
        {
            return _accountController.GetAccountListBinding(null, null, null);
        }

        public BindingSource GetCategoryListBinding(CategoryType type)
        {
            return _categoryController.GetCategoryListBinding(type, null, null);
        }

        public BindingSource GetPayeeListBinding()
        {
            return _payeeController.GetPayeeListBinding(null, null);
        }

        public BindingSource GetEventListBinding()
        {
            return _eventController.GetEventListBinding(null, null);
        }

    }
}
