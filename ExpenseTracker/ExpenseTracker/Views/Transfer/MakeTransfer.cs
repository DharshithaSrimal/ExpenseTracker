using System;
using System.Windows.Forms;

namespace ExpenseTracker.Views.Transfer
{
    public partial class MakeTransfer : Form
    {

        public MakeTransfer()
        {
            InitializeComponent();
            SetUpViewData();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            bool isValid = true;

            if (cboxFromAccount.SelectedIndex == cboxToAccount.SelectedIndex)
            {
                isValid = false;
                erpToAccount.SetError(cboxToAccount, Properties.Resources.TRANSFER_TO_SAME_ACCOUNT);
            }

            if (nudAmount.Value <= 0)
            {
                isValid = false;
                erpAmount.SetError(nudAmount, Properties.Resources.TRANSFER_INVALID_AMOUNT);
            }

            /*if (!_controller.IsSufficientFundsAvailable((int)cboxFromAccount.SelectedValue, nudAmount.Value))
            {
                isValid = false;
                erpAmount.SetError(nudAmount, Properties.Resources.TRANSFER_INSUFFICIENT_FUNDS);
            }

            if (isValid)
            {
                _controller.MakeTransfer(nudAmount.Value, (int)cboxFromAccount.SelectedValue,
                    (int)cboxToAccount.SelectedValue);
                this.Close();
                this.Dispose();
            }*/
        }

        private void SetUpViewData()
        {
           /* // setting up the form title
            this.Text = Properties.Resources.TRANSFER_VIEW_TITLE;
            // populate from account list
            cboxFromAccount.DataSource = _controller.GetFinancialAccountListBinding();
            cboxFromAccount.DisplayMember = Common.COMBOBOX_MEMEBER_KEY;
            cboxFromAccount.ValueMember = Common.COMBOBOX_MEMEBER_VALUE;
            cboxFromAccount.SelectedIndex = 0;
            // populate to account list
            cboxToAccount.DataSource = _controller.GetFinancialAccountListBinding();
            cboxToAccount.DisplayMember = Common.COMBOBOX_MEMEBER_KEY;
            cboxToAccount.ValueMember = Common.COMBOBOX_MEMEBER_VALUE;
            cboxToAccount.SelectedIndex = 1;
            // set max value to amount
            nudAmount.Maximum = decimal.MaxValue;*/
        }

        private void nudAmount_ValueChanged(object sender, EventArgs e)
        {
            erpAmount.Clear();
        }
    }
}
