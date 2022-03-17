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

namespace ExpenseTracker.Views.Category
{
    public partial class ViewCategories : Form
    {
        private ExpenseTrackerDataSet dbInfo = new ExpenseTrackerDataSet();
        public ExpenseTrackerDataSet.CategoryDataTable CategoryList { get; set; }
        public ViewCategories()
        {
            InitializeComponent();
        }

        private void updateCategoryClick(object sender, EventArgs e)
        {
            if (this.dgvCategories.SelectedRows.Count > 0)
            {
                this.dbInfo.Category.AcceptChanges();
            }
        }

        private void deleteCategoryClick(object sender, EventArgs e)
        {
            if (this.dgvCategories.SelectedRows.Count > 0)
            {
                dgvCategories.Rows.RemoveAt(this.dgvCategories.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show(Properties.Resources.DELETE_REC_MSG,
                    Properties.Resources.DELETE_REC_TITLE,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void closeViewCategoryClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void categoriesViewLoad(object sender, EventArgs e)
        {
            this.dgvCategories.DataSource = CategoryList;
            this.dgvCategories.Columns["Id"].Visible = false;
        }
    }
}
