using ExpenseTracker.DataAccess;
using ExpenseTracker.DataAccess.DataObjects;
using ExpenseTracker.Views.Category;
using ExpenseTracker.Views.FinancialAccount;
using ExpenseTracker.Views.Predections;
using ExpenseTracker.Views.Transaction;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ExpenseTracker.Views
{
    public partial class Dashboard : Form
    {
        private CategoryInfo categoryData;
        private FinancialAccountInfo financialAccountData;
        private TransactionInfo transactionData;
        public ExpenseTrackerDataSet.TransactionDataTable TransactionList { get; set; }

        private ExpenseTrackerDataSet dbInfo = new ExpenseTrackerDataSet();

        public Dashboard()
        {
            InitializeComponent();
            SetUpViewData();
            TransactionList = this.dbInfo.Transaction;
        }

        private void btnReportView_Click(object sender, EventArgs e)
        {
            Report report = new Report(this.dbInfo);
            report.ShowDialog();
            report.Dispose();
        }

        private void btnWeeklyView_Click(object sender, EventArgs e)
        {
            WeeklyView weeklyView = new WeeklyView(this.dbInfo);
            weeklyView.ShowDialog();
            weeklyView.Dispose();
        }

        private void btnNewRecord_Click(object sender, EventArgs e)
        {
            int accountsCount = this.dbInfo.FinancialAccount.Rows.Count;
            int catCount = this.dbInfo.Category.Rows.Count;
            int recurringCount = 0;
            if ( catCount> 0 && accountsCount > 0)
            {
                AddTransaction addTransaction = new AddTransaction(dbInfo);
                addTransaction.ShowDialog();
                transactionData = addTransaction.TransactionData;
                addTransaction.Dispose();               
                if(transactionData != null)
                {
                    recurringCount = transactionData.recurringTrs;
                    for (int count = 0; count < recurringCount; count++)
                    {
                        ExpenseTrackerDataSet.TransactionRow rowTransaction = this.dbInfo.Transaction.NewTransactionRow();
                        rowTransaction.Id = dbInfo.Transaction.Rows.Count + 1;
                        rowTransaction.Amount = transactionData.Amount;
                        rowTransaction.Note = transactionData.Note;
                        rowTransaction.Category_Id = (int)transactionData.CategoryId;
                        rowTransaction.FinancialAccount_Id = transactionData.FinancialAccountId;
                        rowTransaction.DateTime = transactionData.DateTime;
                        rowTransaction.Type = transactionData.Type;
                        rowTransaction.IsRecurring = transactionData.IsRecurring;
                        rowTransaction.RecurringUnitl = transactionData.RecurringUntil;
                        rowTransaction.DateTime = transactionData.DateTime.AddDays(count);

                        this.dbInfo.Transaction.AddTransactionRow(rowTransaction);
                        this.dbInfo.Transaction.AcceptChanges();
                    }
                }
                
            }
            else if (catCount == 0)
            {
                MessageBox.Show(Properties.Resources.CAT_COUNT, 
                    Properties.Resources.TNX_NA, 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (accountsCount == 0)
            {
                MessageBox.Show(Properties.Resources.FA_COUNT,
                    Properties.Resources.TNX_NA,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SetUpViewData()
        {
            Dictionary<int, string> recordLimitPairs = new Dictionary<int, string>
            {
                { 10, "10" },
                { 25, "25" },
                { 50, "50" },
                { 100, "100" },
                { 500, "500" },
                { -1, Properties.Resources.DASHBOARD_SHOW_ALL }
            };
            // setting the form title
            this.Text = string.Format("{0} : {1}",
                Properties.Resources.PRODUCT_NAME, Properties.Resources.DASHBOARD_TITLE);
            // setting product name
            lblProductName.Text = Properties.Resources.PRODUCT_NAME;
            // setting the application version
            lblVersion.Text = string.Format("{0} {1}",
            Properties.Resources.VERSION, Properties.Settings.Default.Version);
            initialDataSetup();
        }

        private void addCategoriesClick(object sender, EventArgs e)
        {
            AddCategory addCategory = new AddCategory();
            addCategory.ShowDialog();
            categoryData = addCategory.CategoryData;
            addCategory.Dispose();
            if(categoryData != null)
            {
                ExpenseTrackerDataSet.CategoryRow rowCategory = this.dbInfo.Category.NewCategoryRow();
                rowCategory.Name = categoryData.CategoryName;
                rowCategory.Id = dbInfo.Category.Rows.Count + 1;
                rowCategory.Type = categoryData.CategoryType;
                this.dbInfo.Category.AddCategoryRow(rowCategory);
            }
        }

        private void viewCategoriesClick(object sender, EventArgs e)
        {
            ViewCategories viewCategories = new ViewCategories(dbInfo);
            viewCategories.CategoryList = this.dbInfo.Category;
            viewCategories.ShowDialog();
            viewCategories.Dispose();
        }
        private void viewFinancialAccountsClick(object sender, EventArgs e)
        {
            ViewFinancialAccounts viewFinancialAccount = new ViewFinancialAccounts(this.dbInfo);
            viewFinancialAccount.FinancialAccountList  = this.dbInfo.FinancialAccount;
            viewFinancialAccount.ShowDialog();
        }

        private void addFinancialAccountClick(object sender, EventArgs e)
        {
            AddFinancialAccount addNewView = new AddFinancialAccount();
            addNewView.ShowDialog();
            financialAccountData = addNewView.FinancialAccData;
            addNewView.Dispose();
            if(financialAccountData != null)
            {
                ExpenseTrackerDataSet.FinancialAccountRow row = this.dbInfo.FinancialAccount.NewFinancialAccountRow();
                row.Name = financialAccountData.FinancialAccName;
                row.Id = dbInfo.FinancialAccount.Rows.Count + 1;
                row.Color = financialAccountData.FinancialAccColor;
                row.Balance = financialAccountData.Balance;
                this.dbInfo.FinancialAccount.AddFinancialAccountRow(row);
            }
        }

        private void dashboardLoad(object sender, EventArgs e)
        {
            cboxSelectedAccount.DataSource = this.dbInfo.FinancialAccount;
            cboxSelectedAccount.DisplayMember  = "Name";
            cboxSelectedAccount.ValueMember = "Id";
        }

        private void viewTransactionsClick(object sender, EventArgs e)
        {
            var data = (from Transaction in dbInfo.Transaction.ToList()
                        join Category in dbInfo.Category.ToList()
                        on Transaction.Category_Id equals Category.Id
                        join FinancialAccount in dbInfo.FinancialAccount.ToList()
                        on Transaction.FinancialAccount_Id equals FinancialAccount.Id
                        select new
                        {
                            Transaction.Id,
                            Transaction.Amount,
                            Transaction.Note,
                            Category = Category.Name,
                            Transaction.DateTime,
                            Transaction.Type,
                            Recurring = Transaction.IsRecurring,
                            Transaction.RecurringUnitl,
                            Transaction.FinancialAccount_Id,
                            AccountName = FinancialAccount.Name 
                        }).ToList();
          
            this.dgvTransactions.DataSource = data.Where(filter => filter.FinancialAccount_Id == cboxSelectedAccount.SelectedIndex + 1).ToList();
            this.dgvTransactions.Columns["FinancialAccount_Id"].Visible = false;
        }

        private void updateTransactionClick(object sender, EventArgs e)
        {
            if (this.dgvTransactions.SelectedRows.Count > 0)
            {
                this.dbInfo.Transaction.AcceptChanges();
            }
        }

        private void btnDeleteTransactionClick(object sender, EventArgs e)
        {
            if (this.dgvTransactions.SelectedRows.Count > 0)
            {
                ExpenseTrackerDataSet.TransactionRow rowTransaction = this.dbInfo.Transaction.FindById(this.dgvTransactions.SelectedRows[0].Index+1);
                ExpenseTrackerDataSet.FinancialAccountRow rowAccount    = this.dbInfo.FinancialAccount.FindById(transactionData.FinancialAccountId);
                rowAccount.Balance = rowAccount.Balance - rowTransaction.Amount;
                dgvTransactions.Rows.RemoveAt(this.dgvTransactions.SelectedRows[0].Index);
                this.dbInfo.Transaction.AcceptChanges();
                this.dbInfo.FinancialAccount.AcceptChanges();
            }
            else
            {
                MessageBox.Show(Properties.Resources.DELETE_REC_MSG,
                    Properties.Resources.DELETE_REC_TITLE,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnViewAllTransactionClick(object sender, EventArgs e)
        {
            ViewTransactions viewTransactions = new ViewTransactions(this.dbInfo);
            viewTransactions.TransactionList = this.dbInfo.Transaction;
            viewTransactions.ShowDialog();
            viewTransactions.Dispose();
        }

        public void initialDataSetup() 
        {
            //Categories
            ExpenseTrackerDataSet.CategoryRow rowCategory1 = this.dbInfo.Category.NewCategoryRow();
            rowCategory1.Name = "Sales Income";
            rowCategory1.Id = 1;
            rowCategory1.Type = Properties.Resources.INCOME_TYPE;
            this.dbInfo.Category.AddCategoryRow(rowCategory1);

            ExpenseTrackerDataSet.CategoryRow rowCategory2 = this.dbInfo.Category.NewCategoryRow();
            rowCategory2.Name = "Freelance";
            rowCategory2.Id = 2;
            rowCategory2.Type = Properties.Resources.INCOME_TYPE;
            this.dbInfo.Category.AddCategoryRow(rowCategory2);

            ExpenseTrackerDataSet.CategoryRow rowCategory3 = this.dbInfo.Category.NewCategoryRow();
            rowCategory3.Name = "Food";
            rowCategory3.Id = 3;
            rowCategory3.Type = Properties.Resources.EXPENSE_TYPE;
            this.dbInfo.Category.AddCategoryRow(rowCategory3);

            ExpenseTrackerDataSet.CategoryRow rowCategory4 = this.dbInfo.Category.NewCategoryRow();
            rowCategory4.Name = "Travel";
            rowCategory4.Id = 4;
            rowCategory4.Type = Properties.Resources.EXPENSE_TYPE;
            this.dbInfo.Category.AddCategoryRow(rowCategory4);

            //Financial accounts
            ExpenseTrackerDataSet.FinancialAccountRow rowAccount1 = this.dbInfo.FinancialAccount.NewFinancialAccountRow();
            rowAccount1.Name = "Personal";
            rowAccount1.Id = 1;
            rowAccount1.Color = "Color [Transparent]";
            rowAccount1.Balance = 9000;
            this.dbInfo.FinancialAccount.AddFinancialAccountRow(rowAccount1);

            ExpenseTrackerDataSet.FinancialAccountRow rowAccount2 = this.dbInfo.FinancialAccount.NewFinancialAccountRow();
            rowAccount2.Name = "Business";
            rowAccount2.Id = 2;
            rowAccount2.Color = "Color [Transparent]";
            rowAccount2.Balance = 0;
            this.dbInfo.FinancialAccount.AddFinancialAccountRow(rowAccount2);

            //Transactions
            ExpenseTrackerDataSet.TransactionRow rowT1 = this.dbInfo.Transaction.NewTransactionRow();
            rowT1.Id = 1;
            rowT1.Amount = 10000;
            rowT1.Note = "Sales";
            rowT1.Category_Id = 1;
            rowT1.FinancialAccount_Id = 1;
            rowT1.DateTime = DateTime.Now;
            rowT1.Type = "Income";
            rowT1.IsRecurring = false;
            rowT1.RecurringUnitl = DateTime.Now;
            this.dbInfo.Transaction.AddTransactionRow(rowT1);

            ExpenseTrackerDataSet.TransactionRow rowT2 = this.dbInfo.Transaction.NewTransactionRow();
            rowT2.Id = 2;
            rowT2.Amount = 500;
            rowT2.Note = "Eating out";
            rowT2.Category_Id = 3;
            rowT2.FinancialAccount_Id = 1;
            rowT2.DateTime = DateTime.Now.AddDays(-1);
            rowT2.Type = "Expense";
            rowT2.IsRecurring = false;
            rowT2.RecurringUnitl = DateTime.Now.AddDays(-1);
            this.dbInfo.Transaction.AddTransactionRow(rowT2);

            ExpenseTrackerDataSet.TransactionRow rowT3 = this.dbInfo.Transaction.NewTransactionRow();
            rowT3.Id = 3;
            rowT3.Amount = 300;
            rowT3.Note = "Lunch";
            rowT3.Category_Id = 3;
            rowT3.FinancialAccount_Id = 1;
            rowT3.DateTime = DateTime.Now.AddDays(-1);
            rowT3.Type = "Expense";
            rowT3.IsRecurring = false;
            rowT3.RecurringUnitl = DateTime.Now.AddDays(-1);
            this.dbInfo.Transaction.AddTransactionRow(rowT3);

            ExpenseTrackerDataSet.TransactionRow rowT4 = this.dbInfo.Transaction.NewTransactionRow();
            rowT4.Id = 4;
            rowT4.Amount = 200;
            rowT4.Note = "Uber eats - Dinner";
            rowT4.Category_Id = 3;
            rowT4.FinancialAccount_Id = 1;
            rowT4.DateTime = DateTime.Now.AddDays(-2);
            rowT4.Type = "Expense";
            rowT4.IsRecurring = false;
            rowT4.RecurringUnitl = DateTime.Now.AddDays(-2);
            this.dbInfo.Transaction.AddTransactionRow(rowT4);

            ExpenseTrackerDataSet.TransactionRow rowT5 = this.dbInfo.Transaction.NewTransactionRow();
            rowT5.Id = 5;
            rowT5.Amount = 250;
            rowT5.Note = "Travel to Colombo";
            rowT5.Category_Id = 4;
            rowT5.FinancialAccount_Id = 1;
            rowT5.DateTime = DateTime.Now.AddDays(-3);
            rowT5.Type = "Expense";
            rowT5.IsRecurring = false;
            rowT5.RecurringUnitl = DateTime.Now.AddDays(-3);
            this.dbInfo.Transaction.AddTransactionRow(rowT5);
        }

        private void dailyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryBasedPredection predectionView = new CategoryBasedPredection(this.dbInfo);
            predectionView.ShowDialog();
            predectionView.Dispose();
        }

        private void statiticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatisticsView statView = new StatisticsView(this.dbInfo);
            statView.ShowDialog();
            statView.Dispose();
        }
    }
}
