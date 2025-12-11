using oop_assignment_2_2025_78952.Models;

namespace oop_assignment_2_2025_78952.ExamQuestions;

public static class ExamQuestion_2
{
    public static void Run()
    {
        Console.Clear();
        Console.WriteLine("=== Execute Question 2 (Exception Handling) ===");
        
        var exceptionHandler = new Q2_ExceptionHandlers();

        // ----------------------------------------------------
        // Q2.A: Divide by Zero
        // ----------------------------------------------------
        Console.WriteLine("\n--- 2.A: Divide by Zero Exception ---");
        
        int num1 = 10;
        int num2 = 5;
        Console.WriteLine($"Try: Divide({num1}, {num2})");
        Console.WriteLine($"Result: {exceptionHandler.Divide(num1, num2)}");

        // Example - invalid number  
        int num3 = 10;
        int num4 = 0;
        Console.WriteLine($"Try: Divide({num3}, {num4})");
        Console.WriteLine($"Result: {exceptionHandler.Divide(num3, num4)}");


        // -----------------------------------
        // Q2.B: String to Int Conversion
        // -----------------------------------
        Console.WriteLine("\n--- 2.B: String to Int Format Exception ---");
        
        // Example 1: Valid conversion
        string s1 = "123";
        Console.WriteLine($"Try: ConvertToInt(\"{s1}\")");
        Console.WriteLine($"Result: {exceptionHandler.ConvertToInt(s1)}");

        // Example 2: Invalid conversion
        string s2 = "abcd";
        Console.WriteLine($"Try: ConvertToInt(\"{s2}\")");
        Console.WriteLine($"Result: {exceptionHandler.ConvertToInt(s2)}");


        // -------------------------------------
        // Q2.C: Argument Out Of Range Exception
        // -------------------------------------
        Console.WriteLine("\n--- 2.C: Register User ArgumentOutOfRangeException ---");
        
        // Example 1: Valid age
        int age1 = 38;
        Console.WriteLine($"Try: RegisterUser({age1})");
        Console.WriteLine($"Result: {exceptionHandler.RegisterUser(age1)}");

        // Example 2: Invalid age
        int age2 = 15;
        Console.WriteLine($"Try: RegisterUser({age2})");
        Console.WriteLine($"Result: {exceptionHandler.RegisterUser(age2)}");
        
        Console.WriteLine("\nPress Enter for menu...");
        Console.ReadLine();
    }
}