using ExpenseTracker.DataAccess;
using ExpenseTracker.DataAccess.Services;
using ExpenseTracker.Views.Category;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseTracker.Controllers
{
    public class CategoryController
    {
        private readonly ExpenseTrackerDataSet _dataset;
        private readonly CategoryService _categoryService;

        public CategoryController(ref ExpenseTrackerDataSet ds)
        {
            _dataset = ds;
            _categoryService = new CategoryService(ref ds);
        }

        public void SaveNew(string name, int? type)
        {
            ExpenseTrackerDataSet.CategoryRow row = _dataset.Category.NewCategoryRow();
            row.Name = name;
            row.Type = type.Value;

            Task.Run(() => _categoryService.AddAsync(row));
        }

        public void ShowAddNewView(FormClosedEventHandler eventHandler)
        {
            AddCategory addCategory = new AddCategory(this);
            addCategory.FormClosed += eventHandler;
            addCategory.ShowDialog();
        }

        public BindingSource GetCategoryListBinding(CategoryType? type, string key, int? value)
        {
            SortedDictionary<string, int> keyValuePairs = new SortedDictionary<string, int>();

            if (!string.IsNullOrEmpty(key) && value.HasValue)
            {
                keyValuePairs.Add(key, value.Value);
            }

            foreach (ExpenseTrackerDataSet.CategoryRow row in _dataset.Category.ToList())
            {
                if (!type.HasValue || row.Type == (int)type.Value)
                {
                    keyValuePairs.Add(row.Name, row.Id);
                }
            }

            return (keyValuePairs.Count > 0) ? new BindingSource(keyValuePairs, null) : null;
        }

    }
}
