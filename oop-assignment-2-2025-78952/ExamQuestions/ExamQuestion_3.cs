using System.Collections.Generic;
using oop_assignment_2_2025_78952.Models;

namespace oop_assignment_2_2025_78952.ExamQuestions;

public static class ExamQuestion_3
{
    public static void Run()
    {
        Console.Clear();
        Console.WriteLine("=== Execute Question 3 (Product Rating Analysis) ===");
        
        var products = new List<(string Name, List<int> Ratings)>
        {
            ("Laptop", new List<int> { 5, 4, 4, 5, 3}),
            ("Headphones", new List<int> { 4, 3, 5 }),
            ("Keyboard", new List<int> { 5, 5, 5, 4 }),
            ("Mouse", new List<int> { 3, 3, 4 }),
            ("Monitor", new List<int> {}), 
            ("Webcam", null)
        };

        var processor = new Q3_ProductRatingProcessor();
        
        Console.WriteLine("\n--- Product Rating Details ---");
        
        string results = processor.ProcessRatings(products);
        Console.Write(results);
        
        Console.WriteLine("\nPress Enter for menu...");
        Console.ReadLine();
    }
}