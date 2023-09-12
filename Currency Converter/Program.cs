using System;
using System.ComponentModel.Design;

namespace CC
{
    public class Converter
    {
        static void Main(string[] args)
        {
            //-Taking-Inputs-Stage-//
//------------------------------------------------------------------------------//
            Console.WriteLine("Enter the amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the Currency: (GBP - USD - EUR)? ");
            var curr_now = Console.ReadLine();

            Console.WriteLine("Enter the Desired Currency: (GBP - USD - EUR)? ");
            var curr_des = Console.ReadLine();


            //-Conversion-Stage-//
//------------------------------------------------------------------------------//
            // USD/EUR //
            if (curr_now == "USD" && curr_des == "EUR")
            {
                double convert = 0.84 * amount;
                Console.WriteLine("------------------------------");
                Console.WriteLine("EUR/USD: " + convert.ToString("0.00"));
                Console.WriteLine("------------------------------");
            }

            // USD/GBP //
            if (curr_now == "USD" && curr_des == "GBP")
            {
                double convert = 0.72 * amount;
                Console.WriteLine("------------------------------");
                Console.WriteLine("GBP/USD: " + convert.ToString("0.00"));
                Console.WriteLine("------------------------------");
            }
//------------------------------------------------------------------------------//
            // EUR/USD //
            if (curr_now == "EUR" && curr_des == "USD")
            {
                double convert = 1.18 * amount;
                Console.WriteLine("------------------------------");
                Console.WriteLine("USD/EUR: " + convert.ToString("0.00"));
                Console.WriteLine("------------------------------");
            }

            // EUR/GBP //
            if (curr_now == "EUR" && curr_des == "GBP")
            {
                double convert = 0.86 * amount;
                Console.WriteLine("------------------------------");
                Console.WriteLine("GBP/EUR: " + convert.ToString("0.00"));
                Console.WriteLine("------------------------------");
            }
//------------------------------------------------------------------------------//
            // GBP/USD //
            if (curr_now == "GBP" && curr_des == "USD")
            {
                double convert = 1.38 * amount;
                Console.WriteLine("------------------------------");
                Console.WriteLine("USD/GBP: " + convert.ToString("0.00"));
                Console.WriteLine("------------------------------");
            }

            // GBP/EUR //
            if (curr_now == "GBP" && curr_des == "EUR")
            {
                double convert = 1.16 * amount;
                Console.WriteLine("------------------------------");
                Console.WriteLine("EUR/GBP: " + convert.ToString("0.00"));
                Console.WriteLine("------------------------------");
            }
//------------------------------------------------------------------------------//
            Console.ReadKey();
        }
    }
}