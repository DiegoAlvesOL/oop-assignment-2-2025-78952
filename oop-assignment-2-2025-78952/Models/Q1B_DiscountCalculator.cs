namespace oop_assignment_2_2025_78952.Models
{
    public class Q1B_DiscountCalculator
    {
        public int GetDiscountPercentage(int membershipLevel)
        {
            if (membershipLevel == 1)
            {
                return 5;
            }
            else if (membershipLevel == 2)
            {
                return 10;
            }
            else if (membershipLevel == 3)
            {
                return 15;
            }
            else if (membershipLevel == 4)
            {
                return 20;
            }
            else if (membershipLevel == 5)
            {
                return 25;
            }
            else
            { 
                return 0;
            }
        }
    }
}