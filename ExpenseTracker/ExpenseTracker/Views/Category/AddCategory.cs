using ExpenseTracker.DataAccess;
using ExpenseTracker.DataAccess.DataObjects;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ExpenseTracker.Views.Category
{
    public partial class AddCategory : Form
    {
        public CategoryInfo CategoryData { get; set; }

        public AddCategory()
        {
            InitializeComponent();
            SetUpViewData();
        }

        private void TboxName_TextChanged(object sender, EventArgs e)
        {
            // clear the error associated
            errorProvider.SetError(tboxName, string.Empty);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(tboxName.Text))
            {
                isValid = false;
                errorProvider.SetError(tboxName, Properties.Resources.ADD_NAME_MANDATORY);
            }

            if (tboxName.Text.Length > 30)
            {
                isValid = false;
                errorProvider.SetError(tboxName, Properties.Resources.ADD_NAME_MAX_LENGTH);
            }
            if(cboxType.SelectedItem == null)
            {
                isValid = false;
                errorProvider.SetError(tboxName, Properties.Resources.ADD_TYPE_MANDATORY);
            }

            if (isValid)
            {
                this.CategoryData = new CategoryInfo();
                CategoryData.CategoryName = tboxName.Text;
                CategoryData.CategoryType = (string)cboxType.SelectedItem;
                this.Hide();
            }
        }

        private void SetUpViewData()
        {
            tboxName.TextChanged += TboxName_TextChanged;
            cboxType.SelectedIndex = 0;
        }

        private void btnCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
