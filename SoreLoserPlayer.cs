using System;

namespace ShootingDice
{
    // A Player that throws an exception when they lose to the other player
    // Where might you catch this exception?
    public class SoreLoserPlayer : Player
    {
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
                Console.WriteLine("This game is rigged!");
            }
        }
    }
}