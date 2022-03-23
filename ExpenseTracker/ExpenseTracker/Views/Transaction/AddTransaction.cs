using ExpenseTracker.DataAccess;
using ExpenseTracker.DataAccess.DataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ExpenseTracker.Views.Transaction
{
    public partial class AddTransaction : Form
    {
       
        public TransactionInfo TransactionData { get; set; }

        private ExpenseTrackerDataSet dbInfo;
        public ExpenseTrackerDataSet.CategoryDataTable CategoryList { get; set; }

        public AddTransaction(ExpenseTrackerDataSet dbInfo)
        {
            InitializeComponent();
            this.dbInfo = dbInfo;
        }

        private void TboxNote_TextChanged(object sender, EventArgs e)
        {
            // clear the error associated
            errProviderNote.SetError(tboxNote, string.Empty);
        }

        private void tboxAmount_TextChanged(object sender, EventArgs e)
        {
            // clear the error associated
            errProviderAmount.SetError(tboxAmount, string.Empty);
        }

        private void radioboxType_CheckedChanged(object sender, EventArgs e)
        {
            //categoryTypeCheckChanged();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            decimal amount;

            if (string.IsNullOrWhiteSpace(tboxAmount.Text))
            {
                isValid = false;
                errProviderAmount.SetError(tboxAmount, Properties.Resources.ADD_AMOUNT_INVALID);
            }

            if (!decimal.TryParse(tboxAmount.Text, out amount))
            {
                isValid = false;
                errProviderAmount.SetError(tboxAmount, Properties.Resources.ADD_AMOUNT_INVALID);
            }

            if (string.IsNullOrWhiteSpace(tboxNote.Text))
            {
                isValid = false;
                errProviderNote.SetError(tboxNote, Properties.Resources.ADD_NAME_MANDATORY);
            }

            if (tboxNote.Text.Length > 50)
            {
                isValid = false;
                errProviderNote.SetError(tboxNote, Properties.Resources.ADD_NOTE_MAX_LENGTH);
            }

            if (cboxCategory.SelectedValue == null) isValid = false;
            if (cboxFinancialAccount.SelectedValue == null) isValid = false;

            if (isValid)
            {
                decimal accBalance = 0;
                this.TransactionData = new TransactionInfo();
                TransactionData.Amount = Convert.ToDecimal(tboxAmount.Text);
                TransactionData.Note = tboxNote.Text;
                TransactionData.DateTime = dateTimePicker.Value;
                TransactionData.CategoryId = cboxCategory.SelectedValue;
                TransactionData.FinancialAccountId = (int)cboxFinancialAccount.SelectedValue;
                TransactionData.recurringTrs = (int)(dtpUntillThisDate.Value - dateTimePicker.Value).TotalDays + 1;
                ExpenseTrackerDataSet.FinancialAccountRow rowAccount = this.dbInfo.FinancialAccount.FindById(TransactionData.FinancialAccountId);
                accBalance = rowAccount.Balance;
                TransactionData.DateTime = dateTimePicker.Value;
                if (rbtnExpense.Checked)
                {
                    TransactionData.Type = Properties.Resources.EXPENSE_TYPE;
                    TransactionData.AccountBalance = accBalance - (TransactionData.Amount* TransactionData.recurringTrs);
                }
                else if (rbtnIncome.Checked)
                {
                    TransactionData.Type = Properties.Resources.INCOME_TYPE;
                    TransactionData.AccountBalance = accBalance + (TransactionData.Amount * TransactionData.recurringTrs);
                }
                if (rbtnOneTime.Checked)
                {
                    TransactionData.IsRecurring = false;
                    TransactionData.RecurringUntil = dateTimePicker.Value;
                }
                else if (rbtnRecurring.Checked)
                {
                    TransactionData.IsRecurring = true;
                    TransactionData.RecurringUntil = dtpUntillThisDate.Value;
                }
                
                if (TransactionData.AccountBalance < 0)
                {
                    TransactionData = null;
                    MessageBox.Show(Properties.Resources.TXN_ERR,
                    Properties.Resources.TNX_NA,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (TransactionData.AccountBalance > 0)
                {
                    rowAccount.Balance = TransactionData.AccountBalance;
                    this.dbInfo.FinancialAccount.AcceptChanges();
                    this.Hide();
                }
                
            }
        }
      
        private void addTransactionsLoad(object sender, EventArgs e)
        {
            if (this.dbInfo.Category.Rows.Count > 0)
            {
                cboxCategory.DataSource     = this.dbInfo.Category;
                cboxCategory.DisplayMember  = "Name";
                cboxCategory.ValueMember    = "Id";
                cboxCategory.SelectedIndex  = 0;
            }
            if (this.dbInfo.FinancialAccount.Rows.Count > 0)
            {
                cboxFinancialAccount.DataSource     = this.dbInfo.FinancialAccount;
                cboxFinancialAccount.DisplayMember  = "Name";
                cboxFinancialAccount.ValueMember    = "Id";
            }

            rbtnOneTime.Checked     = true;
            rbtnRecurring.Checked   = false;
            gboxHowLong.Enabled     = false;
        }

        private void btnCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void categorySelectedhanged(object sender, EventArgs e)
        {
            if (cboxCategory.SelectedValue != null)
            {
                int catId = (int)cboxCategory.SelectedIndex + 1;
                String catType = null;
                ExpenseTrackerDataSet.CategoryRow rowCategory = this.dbInfo.Category.FindById(catId);
                catType = rowCategory.Type;
                if (catType == "Expense")
                {
                    rbtnExpense.Enabled = false;
                    rbtnExpense.Checked = true;
                    rbtnIncome.Enabled = false;
                    rbtnIncome.Checked = false;
                }
                else if (catType == "Income")
                {
                    rbtnExpense.Enabled = false;
                    rbtnExpense.Checked = false;
                    rbtnIncome.Enabled = false;
                    rbtnIncome.Checked = true;
                }
            }
        }

        private void rbtnRecurringChanged(object sender, EventArgs e)
        {
            if (rbtnRecurring.Checked)
            {
                gboxHowLong.Enabled = true;
            }
            else
            {
                gboxHowLong.Enabled = false;
            }
        }
    }
}
