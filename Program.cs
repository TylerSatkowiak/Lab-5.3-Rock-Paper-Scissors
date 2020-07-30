using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace Roshambo
{
    class Program
    {
        static Player GetBot()
        {
            //If the input is not a valid 1 or 2, repeat the question.
            string BotSelect = "";
            while (BotSelect != "1" && BotSelect != "2")
            {
                Console.WriteLine("Select an opponent: Mermaid Man (1) or Barnacle Boy(2)");
                BotSelect = Console.ReadLine();
            }
            if (BotSelect == "1")
            {
                Player bot1 = new RandomPlayer();
                return bot1;
            }
            else
            {
                Player bot2 = new RockPlayer();
                return bot2;
            }
        }

        public static string GetResults(Game human, Game computer)
        {
            //Compares the two inputs and returns the win/lose string
            if (human == Game.rock)
            {
                if (computer == Game.scissors)
                {
                    return "You win!";
                }
                else if (computer == Game.paper)
                {
                    return "You lose!";
                }
                else
                {
                    return "Tie!";
                }
            }

            else if(human == Game.paper)
            {
                if (computer == Game.rock)
                {
                    return "You win!";
                }
                else if (computer == Game.scissors)
                {
                    return "You lose!";
                }
                else
                {
                    return "Tie!";
                }
            }

            else
            {
                if (computer == Game.rock)
                {
                    return "You lose!";
                }
                else if (computer == Game.scissors)
                {
                    return "Tie!";
                }
                else
                {
                    return "You win!";
                }
            }
        }

        static bool Quit()
        {
            //Method called to quit or Go Again.
            Console.WriteLine("");
            Console.WriteLine("Play again?. 'N' to quit, any other key to continue.");
            string n = Console.ReadLine().ToLower();
            if (n == "n")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        static void Main()
        {
            Player human = new HumanPlayer();
            Player computer;

            Console.WriteLine("Let's play Rock Paper Scissors!");
            Console.WriteLine("Enter your user name:");
            string PlayerName = Console.ReadLine();

            computer = GetBot();

            do
            {
                human.GenerateRoshambo();
                computer.GenerateRoshambo();
                //Get the computer and human value and store it in StoreValue
                Console.WriteLine($"{PlayerName}: {human.StoreValue}");
                Console.WriteLine($"{computer.Name} : {computer.StoreValue}");

                //Send stored values into GetResults method.
                Console.WriteLine(GetResults(human.StoreValue, computer.StoreValue));
            }
            while (Quit());

        }
    }
}
