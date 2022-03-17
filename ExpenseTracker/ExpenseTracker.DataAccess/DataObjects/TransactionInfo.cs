using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker.DataAccess.DataObjects
{
    public class TransactionInfo
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public String Note { get; set; }
        public DateTime DateTime { get; set; }
        public string Type { get; set; }
        public object CategoryId { get; set; }
        public int FinancialAccountId { get; set; }
        public Boolean IsRecurring { get; set; }
        public DateTime RecurringUntil { get; set; }
        public int recurringTrs { get; set; }
        public decimal AccountBalance  {get; set; }
}
}
