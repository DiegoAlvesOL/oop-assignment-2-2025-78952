// File: oop-assignment-2-2025-78952/Models/Q5_DateTimeFormatter.cs

using System;
using System.Globalization;

namespace oop_assignment_2_2025_78952.Models
{
    public class Q5_DateTimeFormatter
    {
        // Q5.A: Format DateTime to dd/MM/yyyy
        public string FormatDateSimple(DateTime date)
        {
            return date.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
        }

        
        // Q5.B: Get current time in 12-hour format with AM/PM (e.g., 02:15 PM)
        public string GetCurrentTime12H()
        {
            
            DateTime now = DateTime.Now;
            
            return now.ToString("hh:mm tt", new CultureInfo("en-GB"));
        }
        
        
        // Q5.C: Parse string "yyyy-MM-dd" and format to "day of week, day month year"
        public string ParseAndFormatDate(string dateString)
        {
            DateTime parsedDate = DateTime.ParseExact(dateString, "yyyy-MM-dd", CultureInfo.InvariantCulture);
            return parsedDate.ToString("dddd, dd MMMM yyyy", new CultureInfo("en-GB"));
        }
    }
}