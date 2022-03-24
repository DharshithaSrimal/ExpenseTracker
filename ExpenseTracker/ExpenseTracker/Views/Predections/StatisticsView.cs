using ExpenseTracker.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseTracker.Views.Predections
{
    public partial class StatisticsView : Form
    {
        private ExpenseTrackerDataSet dbInfo;

        public StatisticsView(ExpenseTrackerDataSet dbInfo)
        {
            this.dbInfo = dbInfo;
            InitializeComponent();
        }

        private void statisticsViewOnLoad(object sender, EventArgs e)
        {
            cboxSelectedAccount.DataSource = this.dbInfo.FinancialAccount;
            cboxSelectedAccount.DisplayMember = "Name";
            cboxSelectedAccount.ValueMember = "Id";
        }

        private void loadStatisticsClick(object sender, EventArgs e)
        {
            var source = from T in this.dbInfo.Transaction.AsEnumerable()
                         join C in this.dbInfo.Category.AsEnumerable() on T.Field<int>("Category_Id") equals C.Field<int>("ID") into T1
                         from C in T1.DefaultIfEmpty()
                         join A in this.dbInfo.FinancialAccount.AsEnumerable() on T.Field<int>("FinancialAccount_Id") equals A.Field<int>("ID") into T2
                         from A in T2.DefaultIfEmpty()
                         select new
                         {
                             ID = T.Field<int>("Id"),
                             Type = T.Field<string>("Type"),
                             Name = C.Field<String>("Name"),
                             CatId = T.Field<int>("Category_Id"),
                             Amount = T.Field<decimal>("Amount"),
                             FA = T.Field<int>("FinancialAccount_Id"),
                             Balance = A.Field<decimal>("Balance")
                         };

            source = source.Where(x => x.FA == (cboxSelectedAccount.SelectedIndex + 1));
            var financialStatus = source.GroupBy(Tr => Tr.Type).Select(Group => new { Group.Key, Total = Group.Sum(Tr => Tr.Amount) });
            var income = financialStatus.Where(x => x.Key == Properties.Resources.INCOME_TYPE).ToList()[0];
            lblIncome.Text = income.Total.ToString();
            var expense = financialStatus.Where(x => x.Key == Properties.Resources.EXPENSE_TYPE).ToList()[0];
            lblExpense.Text = expense.Total.ToString();

            var incomeSource = source.Where(x => x.Type == Properties.Resources.INCOME_TYPE).ToList();
            var catListIncome = incomeSource.GroupBy(Tr => Tr.Name).Select(Group => new { Group.Key, Total = Group.Sum(Tr => Tr.Amount) });
            var incomeCat = catListIncome.OrderByDescending(Tr => Tr.Total).ToList()[0];
            lblCatIncMost.Text = incomeCat.Key.ToString();
            lblIncMost.Text = "Rs."+ incomeCat.Total.ToString();

            if (catListIncome.Count() > 1)
            {
                var incomeLeastCat = catListIncome.OrderBy(Tr => Tr.Total).ToList()[0];
                lblCatIncLeast.Text = incomeLeastCat.Key.ToString();
                lblIncLeast.Text = "Rs." + incomeLeastCat.Total.ToString();
            }
            
            var expenseSource = source.Where(x => x.Type == Properties.Resources.EXPENSE_TYPE).ToList();
            var catListExpense = expenseSource.GroupBy(Tr => Tr.Name).Select(Group => new { Group.Key, Total = Group.Sum(Tr => Tr.Amount) });
            var expenseCat = catListExpense.OrderByDescending(Tr => Tr.Total).ToList()[0];
            lblCatExpMost.Text = expenseCat.Key.ToString();
            lblExpMost.Text = "Rs." + expenseCat.Total.ToString();

            if (catListExpense.Count() > 1)
            {
                var expenseLeastCat = catListExpense.OrderBy(Tr => Tr.Total).ToList()[0];
                lblCatExpLeast.Text = expenseLeastCat.Key.ToString();
                lblExpLeast.Text = "Rs." + expenseLeastCat.Total.ToString();
            }
            lblBalance.Text = source.ToList()[0].Balance.ToString();
        }
    }
}
