// Arquivo: oop-assignment-2-2025-78952/Models/Q1B_DiscountCalculator.cs

using System;

namespace oop_assignment_2_2025_78952.Models
{
    public class Q1B_DiscountCalculator
    {
        // Refatoração usando o switch expression (limpo e legível)
        public int GetDiscountPercentage(int membershipLevel)
        {
            return membershipLevel switch
            {
                1 => 5,    // Nível 1: 5% de desconto
                2 => 10,   // Nível 2: 10% de desconto
                3 => 15,   // Nível 3: 15% de desconto
                4 => 20,   // Nível 4: 20% de desconto
                5 => 25,   // Nível 5: 25% de desconto
                _ => 0,    // Qualquer outro nível (incluindo 0 ou negativo): 0%
            };
        }
    }
}