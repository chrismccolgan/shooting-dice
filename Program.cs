﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ShootingDice
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player();
            player1.Name = "Bob";

            SmackTalkingPlayer smackTalker = new SmackTalkingPlayer();
            smackTalker.Name = "Sue Smacktalker";

            OneHigherPlayer oneHigher = new OneHigherPlayer();
            oneHigher.Name = "Wilma Onehigher";

            LargeDicePlayer large = new LargeDicePlayer();
            large.Name = "Bigun Rollsalot";

            HumanPlayer human = new HumanPlayer();
            human.Name = "Henry Human";

            CreativeSmackTalkingPlayer creative = new CreativeSmackTalkingPlayer();
            creative.Name = "Creative Conan";

            SoreLoserPlayer sore = new SoreLoserPlayer();
            sore.Name = "Sally Soreloser";

            UpperHalfPlayer upper = new UpperHalfPlayer();
            upper.Name = "Uffie Upperhalf";

            SoreLoserUpperHalfPlayer soreUpper = new SoreLoserUpperHalfPlayer();
            soreUpper.Name = "Stephen Soreupper";

            smackTalker.Play(player1);
            Console.WriteLine("-------------------");

            oneHigher.Play(player1);
            Console.WriteLine("-------------------");

            large.Play(smackTalker);
            Console.WriteLine("-------------------");

            human.Play(player1);
            Console.WriteLine("-------------------");

            creative.Play(smackTalker);
            Console.WriteLine("-------------------");

            sore.Play(player1);
            Console.WriteLine("-------------------");

            upper.Play(player1);
            Console.WriteLine("-------------------");

            soreUpper.Play(player1);
            Console.WriteLine("-------------------");

            List<Player> players = new List<Player>()
            {
                player1,
                smackTalker,
                oneHigher,
                large,
                human,
                creative,
                upper,
                sore,
                soreUpper
            };

            PlayMany(players);
        }

        static void PlayMany(List<Player> players)
        {
            Console.WriteLine();
            Console.WriteLine("Let's play a bunch of times, shall we?");

            // We "order" the players by a random number
            // This has the effect of shuffling them randomly
            Random randomNumberGenerator = new Random();
            List<Player> shuffledPlayers = players.OrderBy(p => randomNumberGenerator.Next()).ToList();

            // We are going to match players against each other
            // This means we need an even number of players
            int maxIndex = shuffledPlayers.Count;
            if (maxIndex % 2 != 0)
            {
                maxIndex = maxIndex - 1;
            }

            // Loop over the players 2 at a time
            for (int i = 0; i < maxIndex; i += 2)
            {
                Console.WriteLine("-------------------");

                // Make adjacent players play one another
                Player player1 = shuffledPlayers[i];
                Player player2 = shuffledPlayers[i + 1];
                player1.Play(player2);
            }
        }
    }
}