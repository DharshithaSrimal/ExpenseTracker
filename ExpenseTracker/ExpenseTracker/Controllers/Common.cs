namespace ExpenseTracker.Controllers
{
    public class Common
    {
        public const int ALL_ACCOUNTS_VALUE = -1;
        public const int ALL_RECORDS_VALUE = -1;

        public const string COMBOBOX_MEMEBER_KEY = "Key";
        public const string COMBOBOX_MEMEBER_VALUE = "Value";

        public static string GetFormattedCurrency(decimal amount)
        {
            return string.Format("{0} {1}",
                Properties.Resources.CURRENCY_PREFIX,
                amount.ToString("#,##0.00"));
        }

    }
}
