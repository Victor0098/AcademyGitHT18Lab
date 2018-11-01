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
            Console.ReadKey();
        }
    }
}
