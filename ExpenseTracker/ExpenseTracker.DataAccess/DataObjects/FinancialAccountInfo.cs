namespace ExpenseTracker.DataAccess.DataObjects
{
    public class FinancialAccountInfo
    {
        public int Id { get; set; }
        public string FinancialAccName { get; set; }
        public string FinancialAccColor { get; set; }
        public decimal Balance { get; set; }
    }
}
