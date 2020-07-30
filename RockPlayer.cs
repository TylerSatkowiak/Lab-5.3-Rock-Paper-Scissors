using System;
using System.Collections.Generic;
using System.Text;

namespace Roshambo
{
    class RockPlayer : Player
    {
        public RockPlayer()
        {
            Name = "Barnacle Boy";
        }
        //Value is ONLY generating 'Rock'
        public override Game GenerateRoshambo()
        {
            StoreValue = Game.rock;
            return Game.rock;
        }
    }
}
