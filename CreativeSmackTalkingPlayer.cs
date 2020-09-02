using System;
using System.Collections.Generic;

namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {
        public override int Roll()
        {
            List<string> insults = new List<string>()
            {
                "Oh yeah?",
                "You stink!",
                "Nobody likes a sore loser!",
                "Don't worry, I am a gracious winner."
            };

            int index = new Random().Next(0, insults.Count);
            string creativeTaunt = insults[index];
            Taunt = creativeTaunt;

            Console.WriteLine($"{Name}: {Taunt}");
            // Return a random number between 1 and DiceSize
            return new Random().Next(DiceSize) + 1;
        }
    }
}