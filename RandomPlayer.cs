using System;
using System.Collections.Generic;
using System.Text;

namespace Roshambo
{
    class RandomPlayer : Player
    {
        private static Random rand = new Random();
        //Name RandomPlayer - Mermaid Man
        public RandomPlayer()
        {
            Name = "Mermaid Man";
        }
        //Generate random value from enum
        public override Game GenerateRoshambo()
        {
            int result = rand.Next(0, 3);
            Game rps = (Game)result;
            StoreValue = rps;
            return rps;
        }
    }
}
