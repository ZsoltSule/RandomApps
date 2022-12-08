using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Random number = new Random();
            int rollFirst = 0;
            int rollSecond = 0;
            int attempts = 0;

            Console.WriteLine("Press enter to roll the dice.\n");

            while (rollFirst != rollSecond || (rollFirst == 0 && rollSecond == 0))
            {
                Console.ReadKey();
                rollFirst = number.Next(1, 7);
                rollSecond = number.Next(1, 7);

                Console.WriteLine($"You rolled {rollFirst} and {rollSecond}\n");
                attempts++;
            }

            Console.WriteLine($"It took you {attempts} attempts to roll two of a kind");
            Console.WriteLine($"You rolled {rollFirst} and {rollSecond}");
        }
    }
}