using System.Globalization;
using System.Text;

namespace oop_assignment_2_2025_78952.Models
{
    public class Q3_ProductRatingProcessor
    {

        private string topProductName = "None";
        private double topProductAverage = 0.0;


        public string GetTopProductName() => topProductName;


        public double GetTopProductAverage() => topProductAverage;
        

        public string ProcessRatings(List<(string Name, List<int> Ratings)> products)
        {
            var output = new StringBuilder();
            

            topProductName = "None";
            topProductAverage = -1.0;
            
            foreach (var product in products)
            {
                string name = product.Name;
                List<int> ratings = product.Ratings;
                
            
                if (ratings == null || ratings.Count == 0)
                {
            
                    output.AppendLine($"{name}: No ratings available");
                    continue; 
                }
                
                int totalRatingSum = 0;
                int ratingCount = 0;
                
                foreach (int rating in ratings)
                {
                    totalRatingSum += rating;
                    ratingCount++;
                }
                
                double averageRating = (double)totalRatingSum / ratingCount;
                
                if (averageRating > topProductAverage)
                {
                    topProductAverage = averageRating;
                    topProductName = name;
                }
                
                string formattedAverage = averageRating.ToString("N1", CultureInfo.InvariantCulture);

                output.AppendLine($"{name}: Average Rating = {formattedAverage}");
            }
            
            output.AppendLine();
            
            if (topProductAverage >= 0)
            {
                string formattedTopAverage = topProductAverage.ToString("N1", CultureInfo.InvariantCulture);
                output.AppendLine($"The best rated product is {topProductName} with an average rate of {formattedTopAverage}");
            }
            else
            {
                output.AppendLine("No product with valid ratings was found.");
            }

            return output.ToString();
        }
    }
}