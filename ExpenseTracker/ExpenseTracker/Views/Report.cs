
using ExpenseTracker.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ExpenseTracker.Views
{
    public partial class Report : Form
    {
        private ExpenseTrackerDataSet dbInfo;
        public const int ALL_ACCOUNTS_VALUE = -1;
        public const int ALL_RECORDS_VALUE = -1;

        public const string COMBOBOX_MEMEBER_KEY = "Key";
        public const string COMBOBOX_MEMEBER_VALUE = "Value";

        public Report()
        {
            InitializeComponent();
            SetUpViewData();
        }

        public Report(ExpenseTrackerDataSet dbInfo)
        {
            this.dbInfo = dbInfo;
            InitializeComponent();
            SetUpViewData();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            UpdateDataGridSource();
        }

        public void UpdateDataGridSource()
        {
            dataGridView.DataSource = UpdateFilterCriteria(
                (int)cboxSelectedAccount.SelectedValue,
                (int)cboxCategory.SelectedValue, dtpStartDate.Value, dtpEndDate.Value);
            dataGridView.Columns["AccountId"].Visible = false;
            dataGridView.Columns["CategoryId"].Visible = false;
        
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }
        }

        private void SetUpViewData()
        {
            // setting up financial accounts
            cboxSelectedAccount.DataSource = GetAccountListBinding(Properties.Resources.DASHBOARD_ALL_ACCOUNTS,
               ALL_ACCOUNTS_VALUE, null);
            cboxSelectedAccount.DisplayMember = COMBOBOX_MEMEBER_KEY;
            cboxSelectedAccount.ValueMember = COMBOBOX_MEMEBER_VALUE;
            cboxSelectedAccount.SelectedValue = ALL_RECORDS_VALUE;
            // setting up categories
            cboxCategory.DataSource = GetCategoryListBinding(null,
                Properties.Resources.REPORT_ALL_CATEGORIES, ALL_RECORDS_VALUE);
            cboxCategory.DisplayMember = COMBOBOX_MEMEBER_KEY;
            cboxCategory.ValueMember = COMBOBOX_MEMEBER_VALUE;
            cboxCategory.SelectedValue = ALL_RECORDS_VALUE;
        }

        public BindingSource GetAccountListBinding(string key, int? value, int? excludeId)
        {
            SortedDictionary<string, int> keyValuePairs = new SortedDictionary<string, int>();

            if (!string.IsNullOrEmpty(key) && value.HasValue)
            {
                keyValuePairs.Add(key, value.Value);
            }

            foreach (ExpenseTrackerDataSet.FinancialAccountRow row in dbInfo.FinancialAccount.ToList())
            {
                if (excludeId.HasValue)
                {
                    if (excludeId != row.Id)
                        keyValuePairs.Add(row.Name, row.Id);
                }
                else
                    keyValuePairs.Add(row.Name, row.Id);
            }

            return new BindingSource(keyValuePairs, null);
        }
        public BindingSource GetCategoryListBinding(CategoryType? type, string key, int? value)
        {
            SortedDictionary<string, int> keyValuePairs = new SortedDictionary<string, int>();

            if (!string.IsNullOrEmpty(key) && value.HasValue)
            {
                keyValuePairs.Add(key, value.Value);
            }

            foreach (ExpenseTrackerDataSet.CategoryRow row in dbInfo.Category.ToList())
            {
                if (!type.HasValue || row.Type == type.ToString())
                {
                    keyValuePairs.Add(row.Name, row.Id);
                }
            }

            return (keyValuePairs.Count > 0) ? new BindingSource(keyValuePairs, null) : null;
        }
        public object UpdateFilterCriteria(int accountId, int categoryId, DateTime startDate, DateTime endDate)
        {
            var filter = from t in dbInfo.Transaction
                         select new
                         {
                             t.Note,
                             t.Amount,
                             Account = t.FinancialAccountRow.Name,
                             AccountId = t.FinancialAccount_Id,
                             Category = t.CategoryRow.Name,
                             CategoryId = t.Category_Id,
                             t.DateTime
                         };
            if (accountId != ALL_ACCOUNTS_VALUE)
                filter = filter.Where(t => t.AccountId == accountId);
            if (categoryId != ALL_RECORDS_VALUE)
                filter = filter.Where(t => t.CategoryId == categoryId);
            filter = filter.Where(t => t.DateTime > startDate && t.DateTime < endDate);

            return filter.ToList();
        }
    }

}

