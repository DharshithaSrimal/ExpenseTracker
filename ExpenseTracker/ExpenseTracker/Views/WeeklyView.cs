using ExpenseTracker.CustomControls;
using ExpenseTracker.DataAccess;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using System.Data;

namespace ExpenseTracker.Views
{
    public partial class WeeklyView : Form
    {
        private GroupBox[] _groupBoxes;
        private ExpenseTrackerDataSet dbInfo;
        public ExpenseTrackerDataSet.TransactionDataTable TransactionList { get; set; }
        public WeeklyView(ExpenseTrackerDataSet dbInfo)
        {
            InitializeComponent();
            this.dbInfo = dbInfo;
            Text = Properties.Resources.WEEKLY_VIEW_TITLE;
            SetUpViewData();
        }
        private void dtpWeekEndingDate_ValueChanged(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(gboxWeekOptions);
            SetUpViewData();
        }

        private void SetUpViewData()
        {
            DateTime date = dtpWeekEndingDate.Value;
            int xStartPoint = 4;
            int yStartPoint = 65;
            _groupBoxes = new GroupBox[7];
            for (int i = 0; i < 7; i++)
            {
                xStartPoint += 6;
                GroupBox groupBox = new GroupBox();
                groupBox.Size = new Size(150, 375);
                groupBox.Location = new Point(xStartPoint, yStartPoint);
                //groupBox.Text = "GroupBox" + (i + 1).ToString();
                this.Controls.Add(groupBox);
                xStartPoint += groupBox.Width;
                _groupBoxes[i] = groupBox;
            }

            for (int i = 6; i >= 0; i--)
            {
                _groupBoxes[i].Text = date.ToString(CultureInfo.CurrentUICulture.DateTimeFormat.ShortDatePattern);

                WeeklyViewDay day = new WeeklyViewDay(GetExpensesOn(date));
                day.RefreshControls();
                day.Location = new Point(0, 19);

                date = date.AddDays(-1);
                _groupBoxes[i].Controls.Add(day);
            }
        }
        public List<ExpenseTrackerDataSet.TransactionRow> GetExpensesOn(DateTime date)
        {
            return dbInfo.Transaction.Where(t => t.Type == "Expense" &&
            t.DateTime.Year == date.Year && t.DateTime.Month == date.Month && t.DateTime.Day == date.Day).ToList();
        }

    }
}
