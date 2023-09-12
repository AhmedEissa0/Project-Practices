using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace rockPaperScissorsGame
{
    public class Prep
    {
        private static string[] choice = { "rock", "paper", "scissors" };
        int myScore = 0;
        int compScore = 0;

        //-play-Method-//
//-------------------------------------------------------------------------------------------------------------------//
        public void Play()
        {

            //-myChoice-//
//---------------------------------------------------------------------//
            Console.WriteLine("Please enter your choice: ");
            var meCh = Console.ReadLine();

            //-generateCompChoice-//
//---------------------------------------------------------------------//
            string randomChoice = GetRandomChoice();

            static string GetRandomChoice()
            {
                Random random = new Random();
                int randomIndex = random.Next(0, choice.Length);       // Generates a random index
                return choice[randomIndex];                            // Returns the corresponding element
            }

            Console.WriteLine("Computer choice: " + randomChoice);

            //-Conditions-&-pointsMechanism-//
//---------------------------------------------------------------------//
            

            if ((meCh == choice[0] && randomChoice == choice[0])
             || (meCh == choice[1] && randomChoice == choice[1])
             || (meCh == choice[2] && randomChoice == choice[2]))
            {
                Console.WriteLine("---------------");
                Console.WriteLine("Draw");
                Console.WriteLine("---------------");
            }

            else if (meCh == choice[0] && randomChoice == choice[2]
              ||     meCh == choice[1] && randomChoice == choice[0])
            {
                myScore += 2;
                Console.WriteLine("---------------");
                Console.WriteLine("You Win!");
                Console.WriteLine("---------------");
            }

            else if (meCh != choice[0] && meCh != choice[1] && meCh != choice[2])
            {
                Console.WriteLine("Invalid Tool!");
            }

            else
            {
                compScore += 2;
                Console.WriteLine("---------------");
                Console.WriteLine("You Lose!");
                Console.WriteLine("---------------");
            }
            
            //-printing scores and reset if someone won the game-//
//---------------------------------------------------------------------//
            Console.WriteLine("my score is: " + myScore);
            Console.WriteLine("Comp score is " + compScore);
            Console.WriteLine("----------------------------------------------");

            if (myScore == 10)
            {
                Console.WriteLine("You win the Game!");
                myScore = 0;
                compScore = 0;
            }

            else if (compScore == 10) 
            {
                Console.WriteLine("Comp win the Game!");
                myScore = 0;
                compScore = 0;
            }
        }
    }
        
//-------------------------------------------------------------------------------------------------------------------//
            //-end-of-prep-class-&-Method-//

    


    class Mainn
    {
        static void Main(string[] args)
        {
            Prep prepobj = new Prep();
            var x = "";
            Console.WriteLine("-----------Welcome in RPS Game!-----------------");
            Console.WriteLine("#NOTE:if u reach 10 points first, u win!");
            Console.WriteLine("------------------------------------------------");


            do
            {
                prepobj.Play();
                Console.WriteLine("Do you want to play again? y/n");
                x = Console.ReadLine();
                Console.WriteLine("----------------------------------------------");

            } while (x == "y");
        }
    }
}