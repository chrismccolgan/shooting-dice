using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who shouts a taunt every time they roll dice
    public class SmackTalkingPlayer : Player
    {
        public override int Roll()
        {
            Console.WriteLine($"{Name}: {Taunt}");
            // Return a random number between 1 and DiceSize
            return new Random().Next(DiceSize) + 1;
        }
        public SmackTalkingPlayer()
        {
            Taunt = "Stupid called, it said it's you!";
        }
    }
}