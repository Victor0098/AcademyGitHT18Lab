﻿using System;

namespace RpgAppLab3
{
    class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            Console.WriteLine("What do you need?");
            var command = Console.ReadLine();
            if (command == "roll D20") Console.WriteLine("not implemented :(");
            if (command == "roll D8")
            {
                Console.WriteLine(rnd.Next(1, 8));
            }
            if (command == "names")
            {
                var allNames = new[] { "Briana", "Ben", "David",
            "Dana", "Felicia", "Felix" };
                var randomIndex = rnd.Next(allNames.Length);
                Console.WriteLine(allNames[randomIndex]);
            }
            Console.ReadKey();
        }
    }  
    internal class Dice
    {
        public int DiceNumbers { get; set; }
        public int numberOfDiceRounds { get; set; }
        

    }
}
