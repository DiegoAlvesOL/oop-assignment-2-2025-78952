using System;
using oop_assignment_2_2025_78952.ExamQuestions; // <-- importa o namespace das questões

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=======================================");
            Console.WriteLine("         OOP Assignment - 78952        ");
            Console.WriteLine("=======================================");
            Console.WriteLine("Select the question to execute:");
            Console.WriteLine("1 - Question 1");
            Console.WriteLine("2 - Question 2");
            Console.WriteLine("3 - Question 3");
            Console.WriteLine("4 - Question 4");
            Console.WriteLine("5 - Question 5");
            Console.WriteLine("0 - Exit");
            Console.WriteLine("---------------------------------------");
            Console.Write("Your choice: ");

            string opcao = Console.ReadLine();

            if (opcao == "1")
            {
                ExamQuestion_1.Run();
            }
            // else if (opcao == "2")
            // {
            //     ExamQuestion_2.Run();
            // }
            // else if (opcao == "3")
            // {
            //     ExamQuestion_3.Run();
            // }
            // else if (opcao == "4")
            // {
            //     ExamQuestion_4.Run();
            // }
            // else if (opcao == "5")
            // {
            //     ExamQuestion_5.Run();
            // }
            else if (opcao == "0")
            {
                Console.WriteLine("Thank you for using this program...");
                return;
            }
            else
            {
                Console.WriteLine("Invalid choice, please try again.");
                Console.ReadLine();
            }
        }
    }
}