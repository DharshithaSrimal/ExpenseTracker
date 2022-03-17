using ExpenseTracker.DataAccess;
using ExpenseTracker.DataAccess.Services;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ExpenseTracker.Controllers
{
    public class PayeeController
    {
        private readonly ExpenseTrackerDataSet _dataset;
        private readonly PayeeService _payeeService;

        public PayeeController(ref ExpenseTrackerDataSet ds)
        {
            _dataset = ds;
            _payeeService = new PayeeService(ref ds);
        }

        public BindingSource GetPayeeListBinding(string key, int? value)
        {
            SortedDictionary<string, int> keyValuePairs = new SortedDictionary<string, int>();

            if (!string.IsNullOrEmpty(key) && value.HasValue)
            {
                keyValuePairs.Add(key, value.Value);
            }

            foreach (ExpenseTrackerDataSet.PayeeRow row in _dataset.Payee.ToList())
            {
                keyValuePairs.Add(row.Name, row.Id);
            }

            return (keyValuePairs.Count > 0) ? new BindingSource(keyValuePairs, null) : null;
        }

        public int SaveNew(string name, string business, string contactNo, string address, string note)
        {
            ExpenseTrackerDataSet.PayeeRow payee = _dataset.Payee.NewPayeeRow();
            payee.Name = name;
            if (string.IsNullOrWhiteSpace(business))
                payee.Business = business;
            if (string.IsNullOrWhiteSpace(contactNo))
                payee.ContactNo = contactNo;
            if (string.IsNullOrWhiteSpace(address))
                payee.Address = address;
            if (string.IsNullOrWhiteSpace(note))
                payee.Note = note;

            return _payeeService.AddAsync(payee).Result;
        }

    }
}
