using ExpenseTracker.DataAccess;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ExpenseTracker.CustomControls
{
    public partial class WeeklyViewDayItem : UserControl
    {

        #region Runtime Injected Methods

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        #endregion

        ExpenseTrackerDataSet.TransactionRow _transaction;

        public WeeklyViewDayItem(ExpenseTrackerDataSet.TransactionRow transaction)
        {
            InitializeComponent();
            _transaction = transaction;
            // setting the rounded corners
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            SetUpViewData();
        }

        private void SetUpViewData()
        {
            lblCategory.Text = _transaction.CategoryRow.Name;
            lblNote.Text = _transaction.Note;
            //lblAmount.Text = Common.GetFormattedCurrency(_transaction.Amount);
            this.BackColor = Color.FromName(_transaction.FinancialAccountRow.Color);
        }
    }
}
