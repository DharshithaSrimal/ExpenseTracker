using ExpenseTracker.DataAccess;
using System;
using System.Windows.Forms;

namespace ExpenseTracker.Views.Transaction
{
    public partial class ViewTransactions : Form
    {
        private ExpenseTrackerDataSet dbInfo;
        public ExpenseTrackerDataSet.TransactionDataTable TransactionList { get; set; }
        public ViewTransactions(ExpenseTrackerDataSet dbInfo)
        {
            this.dbInfo = dbInfo;
            InitializeComponent();
        }

        private void transactionViewLoad(object sender, EventArgs e)
        {
            this.dgvTransactions.DataSource = TransactionList;
            this.dgvTransactions.Columns["Id"].ReadOnly = true;
            this.dgvTransactions.Columns["Amount"].ReadOnly = true;
        }

        private void closeViewTransctionClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDeleteTransaction(object sender, EventArgs e)
        {
            if (this.dgvTransactions.SelectedRows.Count > 0)
            {
                ExpenseTrackerDataSet.TransactionRow rowTransaction = this.dbInfo.Transaction.FindById(this.dgvTransactions.SelectedRows[0].Index + 1);
                ExpenseTrackerDataSet.FinancialAccountRow rowAccount = this.dbInfo.FinancialAccount.FindById(rowTransaction.FinancialAccount_Id);
                if (rowAccount.Balance - rowTransaction.Amount < 0)
                {
                    MessageBox.Show(Properties.Resources.TXN_ERR,
                    Properties.Resources.TNX_NA,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (rowTransaction.Type == Properties.Resources.INCOME_TYPE)
                    {
                        rowAccount.Balance = rowAccount.Balance - rowTransaction.Amount;
                    }
                    else 
                    {
                        rowAccount.Balance = rowAccount.Balance + rowTransaction.Amount;
                    }
                    dgvTransactions.Rows.RemoveAt(this.dgvTransactions.SelectedRows[0].Index);

                    this.dbInfo.Transaction.AcceptChanges();
                    this.dbInfo.FinancialAccount.AcceptChanges();
                }
               
            }
            else
            {
                MessageBox.Show(Properties.Resources.DELETE_REC_MSG,
                    Properties.Resources.DELETE_REC_TITLE,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdateTransaction(object sender, EventArgs e)
        {
            if (this.dgvTransactions.SelectedRows.Count > 0)
            {
                this.dbInfo.Transaction.AcceptChanges();
            }
        }

    }
}
