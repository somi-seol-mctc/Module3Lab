using System;

namespace TacoBurritoLab ///organization
{
    class Program
    {
        static void Main(string[] args)
        {
            ///welcome msg
            Console.WriteLine("Welcome to the Taco & Burrito Decision Maker!");
            Console.Write("How hungry are you (1-10)? ");

            ///user input
            int hungerLevel = int.Parse(Console.ReadLine());

            ///output based on hunger level
            if (hungerLevel >= 8)
            {
                Console.WriteLine("You're super hungry! Order both tacos and burritos.");
            }
            else if (hungerLevel >= 5)
            {
                Console.WriteLine("You're moderately hungry. Go for tacos!");
            }
            else
            {
                Console.WriteLine("You're not that hungry. Opt for a burrito.");
            }

            string recommendation = (hungerLevel >= 5) ? "Tacos" : "Burrito";
            Console.WriteLine($"I recommend: {recommendation}");

            switch (hungerLevel)
            {
                case 10:
                    Console.WriteLine("You're a taco and burrito champion!");
                    break;
                case 7:
                case 8:
                    Console.WriteLine("Taco time!");
                    break;
                case 4:
                case 5:
                    Console.WriteLine("Burrito it is!");
                    break;
                default:
                    Console.WriteLine("Maybe just grab a snack.");
                    break;
            }
        }
    }
}