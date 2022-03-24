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

namespace ExpenseTracker.Views.FinancialAccount
{
    public partial class ViewFinancialAccounts : Form
    {
        private ExpenseTrackerDataSet dbInfo;
        public ExpenseTrackerDataSet.FinancialAccountDataTable FinancialAccountList { get; set; }
        public ViewFinancialAccounts(ExpenseTrackerDataSet dbInfo)
        {
            this.dbInfo = dbInfo;
            InitializeComponent();
        }

        private void viewFinancialAccountsLoad(object sender, EventArgs e)
        {
            this.dgvFinancialAccounts.DataSource = FinancialAccountList;
            this.dgvFinancialAccounts.Columns["Id"].ReadOnly = true;
            this.dgvFinancialAccounts.Columns["Balance"].ReadOnly = true;
        }

        private void updateFinancialAccountClick(object sender, EventArgs e)
        {
            this.dbInfo.FinancialAccount.AcceptChanges();
        }

        private void deleteFinancialAccountClick(object sender, EventArgs e)
        {
            if (this.dgvFinancialAccounts.SelectedRows.Count > 0)
            {
                dgvFinancialAccounts.Rows.RemoveAt(this.dgvFinancialAccounts.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show(Properties.Resources.DELETE_REC_MSG,
                    Properties.Resources.DELETE_REC_TITLE,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void closeViewFinancialAccountsClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
