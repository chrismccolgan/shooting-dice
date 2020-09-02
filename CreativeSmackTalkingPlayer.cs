using System;
using System.Collections.Generic;

namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {
        public CreativeSmackTalkingPlayer()
        {
            List<string> insults = new List<string>()
            {
                "Oh yeah? ",
                "You stink! ",
                "Nobody likes a sore loser! ",
                "Don't worry, I am a gracious winner. "
            };

            int index = new Random().Next(0, insults.Count);
            string creativeTaunt = insults[index];
            Taunt = creativeTaunt;
        }
    }
}