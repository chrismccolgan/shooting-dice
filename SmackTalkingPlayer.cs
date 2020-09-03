using System;

namespace ShootingDice
{
    // A Player who shouts a taunt every time they roll dice
    public class SmackTalkingPlayer : Player
    {
        public string Taunt { get; set; }
        public override int Roll()
        {
            Console.WriteLine($"{Name}: {Taunt}");
            return new Random().Next(DiceSize) + 1;
        }
        public SmackTalkingPlayer()
        {
            Taunt = "Stupid called, it said it's you!";
        }
    }
}