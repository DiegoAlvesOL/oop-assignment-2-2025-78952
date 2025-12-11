using oop_assignment_2_2025_78952.Models;

namespace oop_assignment_2_2025_78952.ExamQuestions;

public static class ExamQuestion_5
{
    public static void Run()
    {
        Console.Clear();
        Console.WriteLine("=== Execute Question 5 (Time and Date) ===");
        
        var formatter = new Q5_DateTimeFormatter();
        
        // Q5.A: Format to dd/MM/yyyy
        Console.WriteLine("\n--- 5.A: Date Formatting (dd/MM/yyyy) ---");
        DateTime date1 = new DateTime(2025, 7, 4);
        string output1 = formatter.FormatDateSimple(date1);
        Console.WriteLine($"Original date is: {date1.ToShortDateString()}");
        Console.WriteLine($"Result: {output1}");


        
        // Q5.B: Current time in 12H format
        Console.WriteLine("\n--- 5.B: Current Time (12H AM/PM) ---");
        string output2 = formatter.GetCurrentTime12H();
        Console.WriteLine($"The computer clock time is:");
        Console.WriteLine($"Result: {output2}");


        
        
        // Q5.C: Parse and Reformat
        Console.WriteLine("\n--- 5.C: Parse String and Reformat ---");
        string inputDateString = "2025-11-30";
        string output3 = formatter.ParseAndFormatDate(inputDateString);
        Console.WriteLine($"Input string date is: {inputDateString}");
        Console.WriteLine($"Result: {output3}");
        
        Console.WriteLine("\nPress Enter for menu...");
        Console.ReadLine();
    }
}