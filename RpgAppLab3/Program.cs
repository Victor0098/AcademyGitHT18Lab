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

            if (command == "roll D15")
            {

                var dice = rnd.Next(15) + 1;
                Console.WriteLine($"Your dice roll is: {dice}");
            }

            if (command == "names")
            {
                var allNames = new[] { "Briana", "Ben", "David",
            "Dana", "Felicia", "Felix" };
                var randomIndex = rnd.Next(allNames.Length);
                Console.WriteLine(allNames[randomIndex]);
            }
            if (command == "D10")
                Console.WriteLine(rnd.Next(1,11));
            if (command == "D4")
                Console.WriteLine(rnd.Next(1,5));

            var allEquipment = new []{ "hammer", "terminator" };
            Console.ReadKey();
        }
    }
}
