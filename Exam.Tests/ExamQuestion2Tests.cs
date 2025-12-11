using NUnit.Framework;
using oop_assignment_2_2025_78952.Models;

namespace Exam.Tests
{
    
    public class ExamQuestion1Tests
    {
        [Test]
        public void Q1A_Test_ValidNumbers_MustBeValid()
        {
            var validator = new Q1A_MobileValidator();
            
            Assert.That(validator.IsValidIrishMobile("0831234567"));
            Assert.That(validator.IsValidIrishMobile("0859876543"));
        }

        
        [Test]
        public void Q1A_Test_InvalidNumbers_MustBeNotValid()
        {
            var validator = new Q1A_MobileValidator();
            
            
            Assert.That(validator.IsValidIrishMobile("..."), Is.False);
            Assert.That(validator.IsValidIrishMobile("..."), Is.False);
            Assert.That(validator.IsValidIrishMobile("..."), Is.False);
        }

        
        // Q1.B: Discount Calculator Tests (If/Else Refactoring)
        
        
        [Test]
        public void Q1B_Test_AllLevels_ReturnCorrectPercentage()
        {
            var calculator = new Q1B_DiscountCalculator();
            
            Assert.That(calculator.GetDiscountPercentage(1), Is.EqualTo(5));
            
            
            Assert.That(calculator.GetDiscountPercentage(3), Is.EqualTo(15));
            
            Assert.That(calculator.GetDiscountPercentage(5), Is.EqualTo(25));
        }
        
        [Test]
        public void Q1B_Test_InvalidLevel_ReturnZeroDiscount()
        {
            var calculator = new Q1B_DiscountCalculator();
            Assert.That(calculator.GetDiscountPercentage(0), Is.EqualTo(0));
            Assert.That(calculator.GetDiscountPercentage(99), Is.EqualTo(0));
        }
    }
}