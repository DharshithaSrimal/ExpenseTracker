using ExpenseTracker.DataAccess;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ExpenseTracker.CustomControls
{
    public partial class WeeklyViewDay : UserControl
    {
        private readonly List<ExpenseTrackerDataSet.TransactionRow> _transactions;

        public WeeklyViewDay(List<ExpenseTrackerDataSet.TransactionRow> transactions)
        {
            InitializeComponent();
            _transactions = transactions;
            SetUpViewData();
        }

        public void RefreshControls()
        {
            SetUpViewData();
        }

        private void SetUpViewData()
        {
            int ySpacer = 3;
            foreach (var item in _transactions)
            {
                WeeklyViewDayItem dayItem = new WeeklyViewDayItem(item);
                dayItem.Location = new Point(3, ySpacer);
                pnlExpenses.Controls.Add(dayItem);
                ySpacer += dayItem.Height + 3;
            }

            lblDayTotalExpense.Text = "Rs." + _transactions.Sum(t => t.Amount).ToString();
        }

    }
}
