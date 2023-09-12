using System;

namespace Kholy_Teacher
{
    public class Calculator
    {
        //-Functions-Preperation// 
        static void Summation ()
        {
            //-Taking Inputs-//
            int x, y;
            Console.WriteLine("Enter 1st num: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd num: ");
            y = Convert.ToInt32(Console.ReadLine());


            //-Result-//
            Console.WriteLine("---------------");
            Console.WriteLine("Result= " + (x + y));
            Console.WriteLine("---------------");

        }

        static void Subtraction()
        {
            //-Taking Inputs-//
            int x, y;
            Console.WriteLine("Enter 1st num: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd num: ");
            y = Convert.ToInt32(Console.ReadLine());


            //-Result-//
            Console.WriteLine("---------------");
            Console.WriteLine("Result= " + (x - y));
            Console.WriteLine("---------------");

        }

        static void Division()
        {
            //-Taking Inputs-//
            int x, y;
            Console.WriteLine("Enter 1st num: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd num: ");
            y = Convert.ToInt32(Console.ReadLine());


            //-Result-//
            Console.WriteLine("---------------");
            Console.WriteLine("Result= " + (x / y));
            Console.WriteLine("---------------");

        }

        static void Multiplcation()
        {
            //-Taking Inputs-//
            int x, y;
            Console.WriteLine("Enter 1st num: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd num: ");
            y = Convert.ToInt32(Console.ReadLine());


            //-Result-//
            Console.WriteLine("---------------");
            Console.WriteLine("Result= " + (x * y));
            Console.WriteLine("---------------");

        }

        static void Calcuator()
        {
            Console.WriteLine("Write the num process (1:+)(2:-)(3:/)(4:*)"); 

            int num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 1:
                    Summation();
                    break;

                case 2:
                    Subtraction();
                    break;

                case 3:
                    Division();
                    break;

                case 4:
                    Multiplcation();
                    break;
            }


        
        }

        //-Main-Fuction-//
        static void Main(string[] args)
        {
            //-Welcome-Message-//
            Console.WriteLine("--------------------------");
            Console.WriteLine("Welcome in Kholy Calculator");
            Console.WriteLine("--------------------------");
           
            //-Multiple-Processes-//
            var x = "";
            
            do
            {
                Calcuator();
                Console.WriteLine("Do you want another process? y/n");
                x = Console.ReadLine();

            } while (x == "y");            // loop execute at least 1 time in do while loop

            Console.WriteLine("--------------------------");
            Console.WriteLine("Thanks for using our service");
            Console.WriteLine("--------------------------");



            //while (condition)
            //{
            //}                            // condition must be true to execute in while loop

            Console.ReadKey();

        }
       
    }
}