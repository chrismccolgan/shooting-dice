using System;

namespace ShootingDice
{
    // A Player who always rolls in the upper half of their possible role and
    // who throws an exception when they lose to the other player
    public class SoreLoserUpperHalfPlayer : Player
    {
        public override int Roll()
        {
            return new Random().Next((DiceSize / 2), (DiceSize + 1));
        }
        public override void Play(Player other)
        {
            try
            {
                int myRoll = Roll();
                int otherRoll = other.Roll();

                Console.WriteLine($"{Name} rolls a {myRoll}");
                Console.WriteLine($"{other.Name} rolls a {otherRoll}");
                if (myRoll > otherRoll)
                {
                    Console.WriteLine($"{Name} Wins!");
                }
                else if (myRoll < otherRoll)
                {
                    throw new Exception();
                }
                else
                {
                    Console.WriteLine("It's a tie");
                }
            }
            catch
            {
                Console.WriteLine("Get the car. I'm leaving now.");
            }
        }
    }
}