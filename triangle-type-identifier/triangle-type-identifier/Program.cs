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
            Console.WriteLine("Enter the lengths of the three sides of the triangle:");

            // Prompt user for input
            double side1, side2, side3;
            try
            {
                Console.Write("Side 1: ");
                side1 = double.Parse(Console.ReadLine());

                Console.Write("Side 2: ");
                side2 = double.Parse(Console.ReadLine());

                Console.Write("Side 3: ");
                side3 = double.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter valid numeric values.");
                return; // Exit the program if input format is invalid
            }

            // Check triangle type
            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
            {
                Console.WriteLine("The lengths of the sides must be positive numbers.");
            }
            else if (side1 == side2 && side2 == side3)
            {
                Console.WriteLine("The triangle is Equilateral.");
            }
            else if (side1 == side2 || side1 == side3 || side2 == side3)
            {
                Console.WriteLine("The triangle is Isosceles.");
            }
            else
            {
                Console.WriteLine("The triangle is Scalene.");
            }
        }
    }
}

