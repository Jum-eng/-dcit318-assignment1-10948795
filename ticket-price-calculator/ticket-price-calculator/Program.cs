using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace triangleTypeIdentifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age: ");
            int age;

            // Validate user input to ensure a non-negative integer
            while (!int.TryParse(Console.ReadLine(), out age) || age < 0)
            {
                Console.WriteLine("Invalid input. Please enter a non-negative age: ");
            }

            double originalPrice = 10.0;
            double discountedAmount = 7.0;// Original ticket price
            double discount = originalPrice - discountedAmount;

            
            // Discount amount (10 - 7)

            double ticketPrice;

            if (age >= 65 || age <= 12)
            {
                ticketPrice = originalPrice - discountedAmount;  //  discount for seniors/children
            }
            else
            {
                ticketPrice = originalPrice;  // No discount for regular adults
            }

            Console.WriteLine("Your ticket price is: GHC" + ticketPrice);

        }
    }
}
