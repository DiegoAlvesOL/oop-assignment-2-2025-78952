// Arquivo: oop-assignment-2-2025-78952/ExamQuestions/ExamQuestion_1.cs
// (Você já tem um namespace para isso, vamos apenas garantir que o arquivo contenha o código completo)

using System;
using oop_assignment_2_2025_78952.Models;

namespace oop_assignment_2_2025_78952.ExamQuestions;

public static class ExamQuestion_1
{
    public static void Run()
    {
        Console.Clear();
        Console.WriteLine("=== Executando Questão 1 ===");
        
        // --- Questão 1.A: Mobile Validator (Regex) ---
        Console.WriteLine("\n--- 1.A: Validação de Celular Irlandês (Regex) ---");
        var mobileValidator = new Q1A_MobileValidator();
        string pattern = mobileValidator.GetRegexPattern();
        Console.WriteLine($"Padrão Regex Utilizado: {pattern}");

        // Exemplos de Teste (Match)
        TestMobileValidation("0831234567", mobileValidator);
        TestMobileValidation("0859876543", mobileValidator);
        TestMobileValidation("0891122334", mobileValidator);
        Console.WriteLine("\n--- Não-Matches Esperados ---");
        // Exemplos de Teste (Non-Match)
        TestMobileValidation("0812345678", mobileValidator); // Não começa com 083, 085, 089
        TestMobileValidation("083 1234567", mobileValidator); // Contém espaço
        TestMobileValidation("08312345678", mobileValidator); // Mais de 10 dígitos
        TestMobileValidation("1234567890", mobileValidator); // Início inválido

        // --- Questão 1.B: Discount Calculator (Refactoring) ---
        Console.WriteLine("\n--- 1.B: Cálculo de Desconto (Refatoração) ---");
        var discountCalculator = new Q1B_DiscountCalculator();

        // Exemplos de Níveis
        TestDiscountCalculation(1, discountCalculator);
        TestDiscountCalculation(2, discountCalculator);
        TestDiscountCalculation(3, discountCalculator);
        TestDiscountCalculation(4, discountCalculator);
        TestDiscountCalculation(5, discountCalculator);
        TestDiscountCalculation(0, discountCalculator); // Nível inválido/padrão
        
        Console.WriteLine("\nPressione Enter para voltar ao menu...");
        Console.ReadLine();
    }
    
    // Método auxiliar para 1.A
    private static void TestMobileValidation(string number, Q1A_MobileValidator validator)
    {
        bool isValid = validator.IsValidIrishMobile(number);
        string result = isValid ? "VÁLIDO" : "INVÁLIDO";
        Console.WriteLine($"Número: {number,-15} -> Resultado: {result}");
    }

    // Método auxiliar para 1.B
    private static void TestDiscountCalculation(int membershipLevel, Q1B_DiscountCalculator calculator)
    {
        int discount = calculator.GetDiscountPercentage(membershipLevel);
        Console.WriteLine($"Nível {membershipLevel} (Memb. Level): Desconto: {discount}%");
    }
}