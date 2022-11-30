using System;
using System.Linq;

namespace guessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Let's play a game!");
                Console.WriteLine("I'm thinking of a number between 1 and 1000!");
                Console.WriteLine("You have to guess the number!");
                Console.WriteLine("You have 10 attempts to guess the number that I'm thinking of!");
                Console.WriteLine("If you guess it you win, if you dont guess it in 10 attempts I win and you lose!");
                Random rnd = new Random();
                int nr;
                int x = rnd.Next(1, 10);
                int tries = 9;
                Console.WriteLine();
                Console.WriteLine("What is your first attempt?");
                do
                {
                    nr = Convert.ToInt32(Console.ReadLine());
                    if (nr == x && tries != 0)
                    {
                        Console.WriteLine("You guessed the correct number!");
                        Console.WriteLine($"The number I thought of is {x}!");
                        Console.WriteLine($"You only needed {10 - tries} attempts!");
                        Console.WriteLine("Congratulations!");
                    }
                    if (nr < x)
                    {
                        if (tries == 1)
                        {
                            Console.WriteLine($"Wrong! The number I'm thinking of is not {nr}!");
                            Console.WriteLine($"The number I'm thinking of is bigger than {nr}!");
                            Console.WriteLine("Try again!");
                            Console.WriteLine($"You have one more attempt to guess it!");
                            tries--;
                        }
                        else
                        {
                            Console.WriteLine($"Wrong! The number I'm thinking of is not {nr}!");
                            Console.WriteLine($"The number I'm thinking of is bigger than {nr}!");
                            Console.WriteLine("Try again!");
                            Console.WriteLine($"You have {tries} attempts to guess it!");
                            tries--;
                        }
                    }
                    if (nr > x)
                    {
                        if (tries == 1)
                        {
                            Console.WriteLine($"Wrong! The number I'm thinking of is not {nr}!");
                            Console.WriteLine($"The number I'm thinking of is less than {nr}!");
                            Console.WriteLine("Try again!");
                            Console.WriteLine($"You have one more attempt to guess it!");
                            tries--;
                        }
                        else
                        {
                            Console.WriteLine($"Wrong! The number I'm thinking of is not {nr}!");
                            Console.WriteLine($"The number I'm thinking of is less than {nr}!");
                            Console.WriteLine("Try again!");
                            Console.WriteLine($"You have {tries} attempts to guess it!");
                            tries--;
                        }
                    }
                }
                while (tries != 0);
                if (tries == 0)
                {
                    nr = Convert.ToInt32(Console.ReadLine());
                    if (nr != x)
                    {
                        Console.WriteLine($"Wrong! The number I'm thinking of is not {nr}!");
                        Console.WriteLine($"The number I thought of is {x}");
                        Console.WriteLine("You lost!");
                    }
                    else if (nr == x)
                    {
                        Console.WriteLine("You guessed the correct number!");
                        Console.WriteLine($"The number I thought of is {x}!");
                        Console.WriteLine($"You only needed {10 - tries} attempts!");
                        Console.WriteLine("Congratulations!");
                    }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("You have to type in a number between 1 and 1000");
            }
        }
    }
}
