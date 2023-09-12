using System;

namespace GA
{
    public class Grades
    {
        static void Main(string[] args)
        {
            // Taking Inputs 
            Console.WriteLine("Enter your semester points: ");
            
            int G = Convert.ToInt32(Console.ReadLine());

            // Checking Final Grade

            // F Grade
            if (G <= 49) {
                Console.WriteLine("Your grade is: F");
            }

            // E Grade
            else if (G <= 59 && G >= 50)
            {
                Console.WriteLine("Your grade is: E");
            }

            // D Grade
            else if (G <= 69 && G >= 60)
            {
                Console.WriteLine("Your grade is: D");
            }

            // C Grade
            else if (G <= 79 && G >= 70)
            {
                Console.WriteLine("Your grade is: C");
            }

            // B Grade
            else if (G <= 89 && G >= 80)
            {
                Console.WriteLine("Your grade is: B");
            }

            // A Grade
            else { Console.WriteLine("Your grade is: A"); }

            Console.ReadKey();
        }
    }
}