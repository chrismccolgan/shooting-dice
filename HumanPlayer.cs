using System;

namespace ShootingDice
{
    // A Player that prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {
        public override int Roll()
        {
            Console.Write("Please enter a number: ");
            return int.Parse(Console.ReadLine());
        }
    }
}