using System.Text.RegularExpressions;

namespace oop_assignment_2_2025_78952.Models
{
    public class Q1A_MobileValidator
    { 
        private const string MobileRegex = @"(083|085|089)\d{7}$";

        public bool IsValidIrishMobile(string number)
        {
            if (string.IsNullOrWhiteSpace(number))
            {
                return false;
            }
            
            return Regex.IsMatch(number, MobileRegex);
        }
        
        public string GetRegexPattern()
        {
            return MobileRegex;
        }
    }
}