using ExpenseTracker.DataAccess;
using System;
using System.Windows.Forms;

namespace ExpenseTracker.Views.Transaction
{
    public partial class EditTransaction : Form
    {
        private ExpenseTrackerDataSet.TransactionRow _transaction;

        public EditTransaction(ExpenseTrackerDataSet.TransactionRow transaction)
        {
            InitializeComponent();
            _transaction = transaction;
            SetUpViewData();
            SetData();
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
            categoryTypeCheckChanged();
        }

        private void categoryTypeCheckChanged()
        {
            DataAccess.CategoryType type = DataAccess.CategoryType.Income;
            if (rbtnExpense.Checked)
            {
                type = DataAccess.CategoryType.Expense;
            }

            /*cboxCategory.DataSource = _controller.GetCategoryListBinding(type);
            if (cboxCategory.DataSource != null)
            {
                cboxCategory.DisplayMember = Common.COMBOBOX_MEMEBER_KEY;
                cboxCategory.ValueMember = Common.COMBOBOX_MEMEBER_VALUE;
            }*/
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
                
            }
        }

        private void SetData()
        {
            /*cboxFinancialAccount.SelectedValue = _transaction.FinancialAccount_Id;
            // setting expense type selected
            switch (_transaction.CategoryRow.Type)
            {
                case (int)CategoryType.Income:
                    rbtnIncome.Checked = true;
                    break;
                case (int)CategoryType.Expense:
                    rbtnExpense.Checked = true;
                    break;
            }
            // setting category list
            categoryTypeCheckChanged();
            cboxCategory.SelectedValue = _transaction.CategoryRow.Id;
            tboxAmount.Text = _transaction.Amount.ToString();
            tboxNote.Text = _transaction.Note;
            dateTimePicker.Value = _transaction.DateTime;
            if (!_transaction.IsPayee_IdNull())
                cboxPayee.SelectedValue = _transaction.Payee_Id;
            if (!_transaction.IsEvent_IdNull())
                cboxEvent.SelectedValue = _transaction.Event_Id;*/
        }

        private void SetUpViewData()
        {
            /*tboxNote.TextChanged += TboxNote_TextChanged;

            // setting up the form title
            this.Text = Properties.Resources.TXN_EDIT;
            // setting up financial account
            cboxFinancialAccount.DataSource = _controller.GetFinancialAccountListBinding();
            cboxFinancialAccount.DisplayMember = Common.COMBOBOX_MEMEBER_KEY;
            cboxFinancialAccount.ValueMember = Common.COMBOBOX_MEMEBER_VALUE;
            // setting payee list
            cboxPayee.DataSource = _controller.GetPayeeListBinding();
            if (cboxPayee.DataSource != null)
            {
                cboxPayee.DisplayMember = Common.COMBOBOX_MEMEBER_KEY;
                cboxPayee.ValueMember = Common.COMBOBOX_MEMEBER_VALUE;
            }
            cboxPayee.SelectedValue = string.Empty;
            // setting event list
            cboxEvent.DataSource = _controller.GetEventListBinding();
            if (cboxEvent.DataSource != null)
            {
                cboxEvent.DisplayMember = Common.COMBOBOX_MEMEBER_KEY;
                cboxEvent.ValueMember = Common.COMBOBOX_MEMEBER_VALUE;
            }
            cboxEvent.SelectedValue = string.Empty;*/
        }

    }
}
