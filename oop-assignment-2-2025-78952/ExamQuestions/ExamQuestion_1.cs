using oop_assignment_2_2025_78952.Models;

namespace oop_assignment_2_2025_78952.ExamQuestions;

public static class ExamQuestion_1
{
    public static void Run()
    {
        Console.Clear();
        // Output: Execute Question 1 (A and B)
        Console.WriteLine("=== Execute Question 1 (A and B) ===");
        
        // --- Questão 1.A: Mobile Validator (Regex) ---
        Console.WriteLine("\n--- 1.A: Irish Mobile Number Validator (Regex) ---");
        var mobileValidator = new Q1A_MobileValidator();
        string pattern = mobileValidator.GetRegexPattern();
        
        Console.WriteLine($"Regex Pattern Used: {pattern}");

        
        Console.WriteLine("\n--- Expected Matches ---");
        TestMobileValidation("0831234567", mobileValidator);
        TestMobileValidation("0859876543", mobileValidator);
        TestMobileValidation("0891122334", mobileValidator);
        
        // Output: Expected Not valid
        Console.WriteLine("\n--- Expected Not-Matches ---");
        TestMobileValidation("0812345678", mobileValidator); 
        TestMobileValidation("083 1234567", mobileValidator); 
        TestMobileValidation("08312345678", mobileValidator); 
        TestMobileValidation("1234567890", mobileValidator); 
        
        static void TestMobileValidation(string number, Q1A_MobileValidator validator)
        {
            bool isValid = validator.IsValidIrishMobile(number);
        
            string result = isValid ? "VALID" : "NOT VALID";
            Console.WriteLine($"Number: {number,-15} -> Result: {result}");
        }
        
        

        // --- Questão 1.B: Discount Calculator ---
        Console.WriteLine("\n--- 1.B: Discount Calculation (If/Else Refactoring) ---");
        var discountCalculator = new Q1B_DiscountCalculator();
        
        TestDiscountCalculation(1, discountCalculator);
        TestDiscountCalculation(2, discountCalculator);
        TestDiscountCalculation(3, discountCalculator);
        TestDiscountCalculation(4, discountCalculator);
        TestDiscountCalculation(5, discountCalculator);
        TestDiscountCalculation(0, discountCalculator); 
        
        
        Console.WriteLine("\nPress Enter to return to menu...");
        Console.ReadLine();
    }
    
    static void TestDiscountCalculation(int membershipLevel, Q1B_DiscountCalculator calculator)
    {
        int discount = calculator.GetDiscountPercentage(membershipLevel);
        
        Console.WriteLine($"Level {membershipLevel} (Memb. Level): Discount: {discount}%");
    }
}