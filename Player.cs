using System;
using System.Collections.Generic;
using System.Text;

namespace Roshambo
{
    abstract class Player
    {
        //Generate rock here but also in Rock-only-player to Inherit
        public virtual Game GenerateRoshambo()
        {
            return Game.rock;
        }
        //Create StoreValue and Name to be created later.
        public Game StoreValue { get; set; }
        public string Name { get; set; }

    }
}
