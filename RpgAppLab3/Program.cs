using System;

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

            if (command == "equipment")
            {
                Equipment eq = new Equipment();
                eq.Name = "plate";
                Console.WriteLine(eq.Name);
            }
            if (command == "names")
            {
                var allNames = new[] { "Briana", "Ben", "David",
                "Dana", "Felicia", "Felix", "Leonardo", "Amelie" };
                var randomIndex = rnd.Next(allNames.Length);
                Console.WriteLine(allNames[randomIndex]);
            }
            if (command == "D10")
                Console.WriteLine(rnd.Next(1,11));
            if (command == "D4")
                Console.WriteLine(rnd.Next(1,5));

            var allEquipment = new []{ "hammer", "terminator", "dragon" };
            Console.ReadKey();
        }
    }  
    internal class Dice
    {
        public int DiceNumbers { get; set; }
        public int numberOfDiceRounds { get; set; }
        

    }
}
