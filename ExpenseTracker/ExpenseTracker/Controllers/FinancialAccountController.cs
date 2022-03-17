using ExpenseTracker.DataAccess;
using ExpenseTracker.DataAccess.Services;
using ExpenseTracker.Views.FinancialAccount;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseTracker.Controllers
{
    public class FinancialAccountController
    {
        private readonly ExpenseTrackerDataSet _dataset;
        private readonly FinancialAccountService _financialAccountService;

        public FinancialAccountController(ref ExpenseTrackerDataSet ds)
        {
            _dataset = ds;
            _financialAccountService = new FinancialAccountService(ref ds);
        }

        public void ShowAddNewView(FormClosedEventHandler eventHandler)
        {
            AddFinancialAccount addNewView = new AddFinancialAccount(this);
            addNewView.FormClosed += eventHandler;
            addNewView.ShowDialog();
        }

        public void SaveNew(string name, string color)
        {
            ExpenseTrackerDataSet.FinancialAccountRow row = _dataset.FinancialAccount.NewFinancialAccountRow();
            row.Name = name;
            row.Color = color;

            Task.Run(() => _financialAccountService.AddAsync(row));
        }

        public BindingSource GetAccountListBinding(string key, int? value, int? excludeId)
        {
            SortedDictionary<string, int> keyValuePairs = new SortedDictionary<string, int>();

            if (!string.IsNullOrEmpty(key) && value.HasValue)
            {
                keyValuePairs.Add(key, value.Value);
            }

            foreach (ExpenseTrackerDataSet.FinancialAccountRow row in _dataset.FinancialAccount.ToList())
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

    }
}
