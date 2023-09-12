using System;

namespace speed_ticket
{
    public class Code
    {
        static void Main(string[] args)
        {
            // Taking Inputs
            Console.WriteLine("Enter the Speed (KM/Hr)? ");
            int speed = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("In town or Outside the town? ");
            var area = Console.ReadLine();

            // Calc Penalty according to speed & area
            // In_town            
            if (area == "In" || area == "in")
            {
                if (speed <= 50 && speed >= 0)
                {
                    Console.WriteLine("--------------------");
                    Console.WriteLine("Penalty is 0$");
                    Console.WriteLine("--------------------");
                }

                else if (speed <= 60 && speed >= 51)
                {
                    Console.WriteLine("--------------------");
                    Console.WriteLine("Penalty is 60$");
                    Console.WriteLine("--------------------");
                }

                else if (speed <= 80 && speed >= 61)
                {
                    Console.WriteLine("--------------------");
                    Console.WriteLine("Penalty is 150$");
                    Console.WriteLine("--------------------");
                }

                else
                {
                    Console.WriteLine("--------------------");
                    Console.WriteLine("Penalty is 300$");
                    Console.WriteLine("--------------------");
                }
            }

            // Outsie_town
            if (area == "Out" || area == "out")
            {
                if (speed <= 80 && speed >= 0)
                {
                    Console.WriteLine("--------------------");
                    Console.WriteLine("Penalty is 0$");
                    Console.WriteLine("--------------------");
                }

                else if (speed <= 90 && speed >= 81)
                {
                    Console.WriteLine("--------------------");
                    Console.WriteLine("Penalty is 45$");
                    Console.WriteLine("--------------------");
                }

                else if (speed <= 120 && speed >= 91)
                {
                    Console.WriteLine("Penalty is 100$");
                    Console.WriteLine("--------------------");
                }

                else
                {
                    Console.WriteLine("--------------------");
                    Console.WriteLine("Penalty is 200$");
                    Console.WriteLine("--------------------");
                }            
            }

            Console.ReadKey();
        }
    }
  
}