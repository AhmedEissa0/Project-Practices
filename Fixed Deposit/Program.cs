using System;

namespace Fixed_Deposit
{       
    public class Code1
    {
        static void Main(string[] args)
        {
            // Taking Inputs
            Console.WriteLine("Enter the Investment amount: ");
            double P = Convert.ToDouble (Console.ReadLine());

            Console.WriteLine("Enter rate of interest/year: ");
            double r = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter years of investment: ");
            double n = Convert.ToDouble(Console.ReadLine());

            //Calcualte total Investment
            double a1 = 1 + (r / 100);
            double A = Convert.ToDouble(Math.Pow(a1,n));
            A *= P;

            Console.WriteLine("-------------------------");
            Console.WriteLine("Total Investment: " + A.ToString("0.00") + " $");
            Console.WriteLine("-------------------------");
            Console.ReadKey();
        }
    }
}