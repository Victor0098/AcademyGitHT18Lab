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

            if (command == "roll D4")
            {
                Console.WriteLine("Its implemented :(");
            }
            else 
            Console.WriteLine("Again, What do you need?");
            var command2 = Console.ReadLine();

            if (command == "roll D4")
            {
                Console.WriteLine("Its not implemented :(");
            }
            Console.WriteLine("Again, Again What do you need?");
            var command3 = Console.ReadLine();

            if (command == "roll D4")
            {
                Console.WriteLine("Its maybe implemented :(");
            }

            Console.WriteLine();
            Console.WriteLine("Again, Again, Again, What do you need?");
            var command4 = Console.ReadLine();

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
