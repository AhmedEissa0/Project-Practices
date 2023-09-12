using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalSeconds = Convert.ToInt32(Console.ReadLine());   //put and convert it to int.
            int minutes = totalSeconds / 60;                    // If totalSeconds / 60 has value of 2.90 it's parsed to int as 2. 
            int seconds = totalSeconds - minutes * 60;          // Extract seconds from minutes and total seconds
            string output = "";
            if (minutes < 10)

            {
                output += "0";                                  // Add leading 0 for single digit numbers.
            }

            output += minutes + ":";

            if (seconds < 10)
            {
                output += "0";                                  // Add leading 0 for single digit numbers.
            }

            output += seconds;
            Console.WriteLine(output);
            Console.ReadKey();

        }   

    }

}

