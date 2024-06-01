using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace gradeCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter a numerical grade between 0 and 100:");
                string? input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Input cannot be null or empty. Please enter a valid numerical grade.");
                    continue;
                }

                try
                {
                    int grade = int.Parse(input);

                    if (grade < 0 || grade > 100)
                    {
                        Console.WriteLine("Please enter a grade between 0 and 100.");
                        continue;
                    }

                    string letterGrade;

                    if (grade >= 90)
                    {
                        letterGrade = "A";
                    }
                    else if (grade >= 80)
                    {
                        letterGrade = "B";
                    }
                    else if (grade >= 70)
                    {
                        letterGrade = "C";
                    }
                    else if (grade >= 60)
                    {
                        letterGrade = "D";
                    }
                    else
                    {
                        letterGrade = "F";
                    }

                    Console.WriteLine("The letter grade is: " + letterGrade);
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a numerical grade.");
                }
            }
        }
    }
}

