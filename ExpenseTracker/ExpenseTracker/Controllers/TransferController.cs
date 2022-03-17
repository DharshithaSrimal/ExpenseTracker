using ExpenseTracker.DataAccess;
using ExpenseTracker.DataAccess.Services;
using ExpenseTracker.Views.Transfer;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseTracker.Controllers
{
    public class TransferController
    {
        private readonly ExpenseTrackerDataSet _dataset;
        private readonly TransactionService _transactionService;

        private readonly FinancialAccountController _accountController;
        private readonly TransactionController _transactionController;

        public TransferController(ref ExpenseTrackerDataSet ds,
            FinancialAccountController accountController,
            TransactionController transactionController)
        {
            _dataset = ds;

            _accountController = accountController;
            _transactionController = transactionController;

            _transactionService = new TransactionService(ref ds);
        }

        public void ShowView(FormClosedEventHandler eventHandler)
        {
            MakeTransfer transfer = new MakeTransfer(this);
            transfer.FormClosed += eventHandler;
            transfer.ShowDialog();
        }

        public void MakeTransfer(decimal amount, int fromId, int toId)
        {
            DateTime dateTime = DateTime.Now;

            // out transfer
            ExpenseTrackerDataSet.TransactionRow outTxn = _dataset.Transaction.NewTransactionRow();
            outTxn.Amount = amount;
            outTxn.FinancialAccount_Id = fromId;
            outTxn.Category_Id = 7;
            outTxn.DateTime = dateTime;
            outTxn.Note = "Fund Transfer";
            outTxn.SysGenerated = false;
            Task outTask = Task.Run(() => _transactionService.AddAsync(outTxn));

            // in transfer
            ExpenseTrackerDataSet.TransactionRow inTxn = _dataset.Transaction.NewTransactionRow();
            inTxn.Amount = amount;
            inTxn.FinancialAccount_Id = toId;
            inTxn.Category_Id = 6;
            inTxn.DateTime = dateTime;
            inTxn.Note = "Fund Transfer";
            inTxn.SysGenerated = false;
            outTask.Wait();
            Task.Run(() => _transactionService.AddAsync(inTxn));
        }

        public bool IsSufficientFundsAvailable(int fromId, decimal amount)
        {
            return _transactionController.GetBalance(fromId) >= amount;
        }

        public BindingSource GetFinancialAccountListBinding()
        {
            return _accountController.GetAccountListBinding(null, null, null);
        }

    }
}
