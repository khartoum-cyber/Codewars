
using System.Globalization;

namespace Dollars_and_Cents
{
    internal class Kata
    {
        public static string FormatMoney(double amount) => amount.ToString("C", CultureInfo.CreateSpecificCulture("en-US")).Replace(",", "");
    }
}
