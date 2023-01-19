// Trey Redd

using System;

namespace DiceTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Begins the program with the introduction and the user sets the number of rolls
            Console.WriteLine("Welcome to the dice throwing simulator!");
            Console.WriteLine("\n");
            Console.Write("How many dice rolls would you like to simulate? ");

            int numRolls = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n");
            // Calls the random number generator function
            Generator(numRolls);
        }


        static void Generator(int numRolls)
        {
            // generates random numbers for 2 dice rolls, adds them together, and holds them in an array
            Random r = new Random();
            int[] numGen = new int[6];
            int[] cast = new int[numRolls];

            for (int i = 0; i < numRolls; i++)
            {
                int roll = r.Next(1,7);
                int roll2 = r.Next(1,7);

                cast[i] = roll + roll2;
            }
            // calls the printer function to print the results
            Printer(cast, numRolls);
        }

        static void Printer(int[] cast, int numRolls)
        {
            // creates a new array for aggregating the generated array into counts for each result.
            int[] counter = new int[13];
            

            for (int i = 0; i < numRolls; i++)
            {
                for (int j = 1; j < 13; j++)
                {
                    if (cast[i] == j)
                    {
                        counter[j]++;
                    }
                }
            }

            Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \" * \" represents 1% of the total number of rolls.");
            Console.WriteLine("Total number of rolls = " + numRolls + ".");
            Console.WriteLine("\n");

            //print asterisks and number results

            for (int i = 2; i < 13; i++)
            {
                Console.Write(i + ": ");
                for (int j = 0; j < counter[i]; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
            // final signoff
            Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
            Console.WriteLine("\n\n");
            Console.WriteLine("NOTE: Due to rounding issues and the fact that you cannot print a partial asterisk, your total number of asterisks printed may not be " + numRolls + ".");

        }
    }
}