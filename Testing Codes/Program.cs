using System;

namespace testingcodes
{
    class Champ
    {
        static void Main(string[] args)
        {
            string str = "readability";
            
            for (int i = 0; i < str.Length; i++) 
            { 
                string charToString = str[i] + "";

                if ("ab".Contains(charToString)) 
                {
                    Console.WriteLine(charToString);                    
                }

            }


            Console.ReadKey();
        }

    }
}