using NUnit.Framework;
using oop_assignment_2_2025_78952.Models;

namespace Exam.Tests
{
    
    public class ExamQuestion3Tests
    {
        
        // Setup Data
        
        private List<(string Name, List<int> Ratings)> _sampleProducts;
        private Q3_ProductRatingProcessor _processor;
        
        [SetUp]
        public void Setup()
        {
            _processor = new Q3_ProductRatingProcessor();
            
            _sampleProducts = new List<(string Name, List<int> Ratings)>
            {
                ("Laptop", new List<int> { 5, 4, 4, 5, 3 }),
                ("Headphones", new List<int> { 4, 3, 5 }),
                ("Keyboard", new List<int> { 5, 5, 5, 4 }),
                ("EmptyProduct", new List<int> {}), 
                ("NullProduct", null)
            };
        }

        
        // Q3.1: Average Calculation and Output Format Tests
        
        [Test]
        public void Q3_Test_IndividualAverage_IsCalculatedAndFormattedCorrectly()
        {
        
            string results = _processor.ProcessRatings(_sampleProducts);
            
        
            Assert.That(results, Contains.Substring("Laptop: Average Rating = 4.2"));
            
        
            Assert.That(results, Contains.Substring("Keyboard: Average Rating = 4.8"));
        }

        
        // Q3.2: Highest Rated Product Test
        
        
        [Test]
        public void Q3_Test_TopProduct_IsCorrectlyIdentified()
        {
            _processor.ProcessRatings(_sampleProducts);
            
            
            Assert.That(_processor.GetTopProductName(), Is.EqualTo("Keyboard"));
            Assert.That(_processor.GetTopProductAverage(), Is.EqualTo(4.75).Within(0.001));
        }

        
        [Test]
        public void Q3_Test_FinalSummary_IsCorrect()
        {
            string results = _processor.ProcessRatings(_sampleProducts);
            
        
            Assert.That(results, Contains.Substring("The best rated product is Keyboard with an average rate of 4.8"));
        }
        
        // Q3.3: Handling Empty/Null Rating Lists Tests
        [Test]
        public void Q3_Test_EmptyRatings_DisplayNoRatingsMessage()
        {
            string results = _processor.ProcessRatings(_sampleProducts);
            Assert.That(results, Contains.Substring("EmptyProduct: No ratings available"));
        }
        
        
        [Test]
        public void Q3_Test_NullRatings_DisplayNoRatingsMessage()
        {
            string results = _processor.ProcessRatings(_sampleProducts);

            
            Assert.That(results, Contains.Substring("NullProduct: No ratings available"));
        }
    }
}