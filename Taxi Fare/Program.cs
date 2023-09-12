using System;

namespace Taxi_Fare
{
    class Fare_Value 
    {
        static void Main(string[] args)
        {
            // Taking Inputs
            Console.WriteLine("Enter Seconds: ");
            int seconds = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Distance: ");
            double mileage = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Day or Night? ");
            var Time = Console.ReadLine();

            // Calculate Fare according to Time
            // Printing Fare Value & Convert to nearest 2 Deciamls                   
            double Fare = Convert.ToDouble(2 + 0.02 * seconds + 1.2 * mileage);

            if (Time == "N" || Time == "n" || Time == "Night" || Time == "night") 
            {       
                Fare *= 2;
                Console.WriteLine("-----------------------");
                Console.WriteLine("Trip Fare is: " + Fare.ToString("0.00") + " $");
                Console.WriteLine("-----------------------");
            }

            else if (Time =="D" || Time == "d" || Time == "Day" || Time == "day") 
            { 
                Fare *= 1;
                Console.WriteLine("-----------------------");
                Console.WriteLine("Trip Fare is: " + Fare.ToString("0.00") + " $");
                Console.WriteLine("-----------------------");
            }

            else 
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine("Invalid");
                Console.WriteLine("-----------------------");
            }

            Console.ReadKey();
        }

    }
}