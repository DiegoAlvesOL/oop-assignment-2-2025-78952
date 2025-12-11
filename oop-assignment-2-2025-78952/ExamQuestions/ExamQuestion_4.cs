using oop_assignment_2_2025_78952.Models;

namespace oop_assignment_2_2025_78952.ExamQuestions;


public static class ExamQuestion_4
{
    public static void Run()
    {
        Console.Clear();
        Console.WriteLine("== Execute question 4 ===");

        var formatter = new Q4_Formatter();
        
        
        //Q4.A: 5 digits with leading zero
        Console.WriteLine("\n --- 4.A: Digits formatting with zero ---");

        int input1 = 42;
        string output1 = formatter.FormatToFiveDigits(input1);
        Console.WriteLine($"Input number is: {input1}");
        Console.WriteLine($"Result is: {output1}");
        
        int input2 = 012345;
        string output2 = formatter.FormatToFiveDigits(input2);
        Console.WriteLine($"Input number is: {input2}");
        Console.WriteLine($"Result is: {output2}");
        
        
        // Q4.B: Currency Formatting €1,234.50
        Console.WriteLine("\n--- 4.B: Currency Formatting (€1,234.50) ---");
        
        double price1 = 1234.5;
        string priceOutput1 = formatter.FormatCurrency(price1);
        Console.WriteLine($"Input price is: {price1}"); 
        Console.WriteLine($"Result: {priceOutput1}"); 
        
        double price2 = 5678.99;
        string priceOutput2 = formatter.FormatCurrency(price2);
        Console.WriteLine($"Input price is: {price2}"); 
        Console.WriteLine($"Result: {priceOutput2}");
        
        Console.WriteLine("\nPress Enter for menu..."); 
        Console.ReadLine();
    }
}