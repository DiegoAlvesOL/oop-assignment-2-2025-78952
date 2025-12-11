using System.Text.RegularExpressions;

namespace oop_assignment_2_2025_78952.Models
{
    public class Q1A_MobileValidator
    {
        // O regex:
        // ^(083|085|089) - Começa com 083, 085 ou 089
        // \d{7} - Seguido por exatamente 7 dígitos (totalizando 10)
        // $ - Termina (garante que não há mais caracteres, como espaços ou símbolos)
        private const string MobileRegexPattern = @"^(083|085|089)\d{7}$";

        public bool IsValidIrishMobile(string number)
        {
            if (string.IsNullOrWhiteSpace(number))
            {
                return false;
            }
            
            // Verifica se a string corresponde exatamente ao padrão Regex
            return Regex.IsMatch(number, MobileRegexPattern);
        }
        
        public string GetRegexPattern()
        {
            return MobileRegexPattern;
        }
    }
}