using System;

namespace W3
{
    public class Q8
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = 0;
            
            for (y = 0; y <=12; y++) 
            {
                Console.WriteLine($"\n {x} * {y}= ");
                Console.WriteLine("\t"+ y * x);                  
            }

            Console.ReadKey();
        }
    }
}
    