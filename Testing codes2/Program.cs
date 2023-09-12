using System;

namespace CompanyChechkingModel
{
 //----------------------------------------------------------------------------------------------------------//
    
    public class Person
    {
        private string[] names = { "ahmed", "mohammed" };

        public void PersonCheck()   // method(Function) creation, "Method is a function inside the class"
        {
            Console.WriteLine("Welcome in our company!, What is your name?");
            var name = Console.ReadLine();

            if ( name == names[0] || name == names[1] )
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine("Welcome! " + name + " Have a nice day!");
                Console.WriteLine("-----------------------");
            }

            else
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine("You Cannot Access!");
                Console.WriteLine("-----------------------");
            }
        }
    }
//----------------------------------------------------------------------------------------------------------//
    class CompanyAccess
    {
        static void Main(string[] args)
        {
            Person PersonObj = new Person();  // Creating Object from the above class "Line 7"
            PersonObj.PersonCheck();          // dealing with the object created above "Line 37"
        }
    }
//----------------------------------------------------------------------------------------------------------//
}