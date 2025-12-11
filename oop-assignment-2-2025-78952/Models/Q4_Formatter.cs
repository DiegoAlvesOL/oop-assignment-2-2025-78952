using System.Globalization;

namespace oop_assignment_2_2025_78952.Models
{
    public class Q4_Formatter
    {
        public string FormatToFiveDigits(int number)
        {
            return number.ToString("D5");
        }
        
        public string FormatCurrency(double price)
        {
            CultureInfo euroCulture = new CultureInfo("en-IE");

            return price.ToString("C2", euroCulture);
        }
    }
}