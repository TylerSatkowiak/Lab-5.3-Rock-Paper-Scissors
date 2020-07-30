using System;
using System.Collections.Generic;
using System.Text;

namespace Roshambo
{
    class HumanPlayer : Player 
    {
        public override Game GenerateRoshambo()
        {
            //If user does not select R/P/S
            Console.Write("Rock, Paper, or Scissors? (R/P/S): ");
            string selection = Console.ReadLine().ToLower();
            if (selection != "r" && selection != "p" && selection != "s")
            {
                Console.WriteLine("Not a valid selection, please try again.");
                //Recursion
                return GenerateRoshambo();
            }
            //Store the human value and return that value.
            else if (selection == "r")
            {
                StoreValue = Game.rock;
                return Game.rock;
            }
            else if (selection == "p")
            {
                StoreValue = Game.paper;
                return Game.paper;
            }
            else
            {
                StoreValue = Game.scissors;
                return Game.scissors;
            }
        }
    }
}
