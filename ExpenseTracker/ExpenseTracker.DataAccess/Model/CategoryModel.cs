using ExpenseTracker.DataAccess;
using ExpenseTracker.DataAccess.DataObjects;
using System;

namespace ExpenseTracker.Model.Category
{
    public class CategoryModel
    {
        private ExpenseTrackerDataSet dbInfo = new ExpenseTrackerDataSet();
   
        public void saveCategory(CategoryInfo categoryData)
        {
            ExpenseTrackerDataSet.CategoryRow row = this.dbInfo.Category.NewCategoryRow();
            row.Name = categoryData.CategoryName;
            row.Id = dbInfo.Category.Rows.Count + 1;
            row.Type = categoryData.CategoryType;
            this.dbInfo.Category.AddCategoryRow(row);

        }
    }
}