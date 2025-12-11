namespace oop_assignment_2_2025_78952.Models
{
    public class Q2_ExceptionHandlers
    {
        // ----------------------------------------------------
        // Q2.A: Divide two integers, handle DivideByZeroException
        // ----------------------------------------------------
        public string Divide(int num1, int num2)
        {
            try
            {
                int result = num1 / num2;
                return $"The result of {num1} divided by {num2} is: {result}";
            }
            catch (DivideByZeroException)
            {
                return "Cannot divide by 0";
            }
        }

        // ----------------------------------------------------
        // Q2.B: Convert string to int, handle FormatException
        // ----------------------------------------------------
        public string ConvertToInt(string input)
        {
            try
            {
                int number = int.Parse(input);
                return $"The integer value is: {number}";
            }
            catch (FormatException)
            {
                return "Invalid number entered";
            }
        }
        
        // ----------------------------------------------------
        // Q2.C: Register User, throw and catch ArgumentOutOfRangeException
        // ----------------------------------------------------
        public string RegisterUser(int age)
        {
            try
            {
                if (age < 18)
                {
                    throw new ArgumentOutOfRangeException("age", "Age must be 18 or older for registration.");
                }
                return "Registration successful";
            }
            catch (ArgumentOutOfRangeException)
            {
                return "User must be at least 18 to register";
            }
        }
    }
}