using ExpenseTracker.DataAccess;
using ExpenseTracker.Views;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ExpenseTracker.Controllers
{
    public class WeeklyViewController
    {
        private readonly ExpenseTrackerDataSet _dataset;

        public WeeklyViewController(ref ExpenseTrackerDataSet dataset)
        {
            _dataset = dataset;
        }

        public void ShowWeeklyView()
        {
            WeeklyView weeklyView = new WeeklyView(this);
            weeklyView.ShowDialog();
        }

        public List<ExpenseTrackerDataSet.TransactionRow> GetExpensesOn(DateTime date)
        {
            return _dataset.Transaction.Where(t => t.CategoryRow.Type == (int)CategoryType.Expense &&
            t.DateTime.Year == date.Year && t.DateTime.Month == date.Month && t.DateTime.Day == date.Day).ToList();
        }
    }
}
