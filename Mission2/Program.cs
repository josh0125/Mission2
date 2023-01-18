using System;

namespace Mission2
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Declaring the String Variable to get the Input of Rolls
            string numberOfRolls = "";

            // Displaying Info and Getting Input
            Console.WriteLine("Welcome to the dice throwing simulator!");
            Console.Write("How many dice rolls would you like to simulate? ");
            numberOfRolls = Console.ReadLine();

            // Calling Roll Dice Function
            RollDice(numberOfRolls);

        }
        static void RollDice(string dice)
        {
            // Changing String to Int
            int numberOfRolls = int.Parse(dice);

            // Creating an Empty Array for Numbers
            int[] rolls = new int[13];

            // Loop to Get Roll of the Dice
            for (int i = 0; i < numberOfRolls; i++)
            {
                // Random Numbers for Dice from 1-6
                Random rnd = new Random();
                int num1 = rnd.Next(1, 7);
                int num2 = rnd.Next(1, 7);

                // Adding Numbers
                int totalNum = num1 + num2;
                  
                // Adding One to the Number that was Rolled
                rolls[totalNum] = rolls[totalNum] + 1;
            }

            // Calling Print Function and Passing Array of Rolls and numberOfRolls
            PrintTotals(rolls, numberOfRolls);

        }

        static void PrintTotals(int[] rolls, int numberOfRolls)
        {
            // Print Out with Number of Rolls
            Console.WriteLine("DICE ROLLING SIMULATION RESULTS.\nEach '*' represents 1 % of the total number of rolls.\nTotal number of rolls = " + numberOfRolls.ToString() + "\n\n");

            // Looping through the roll results
            for (int i = 2; i <= 12; i++)
            {
                // Print Each Result 2-12
                Console.Write(i + ": " + rolls[i] + "  ");

                // Calculating Roll Percentage
                int roll = rolls[i] * 100;
                double stars = ((roll / numberOfRolls));
                Math.Round(stars);

                // Loop through to Print Out Star Percentage
                for (int ii = 2; ii < stars; ii++)
                {
                    Console.Write("*");
                }

                // Add Line Between Numbers
                Console.Write("\n");
            }

            // Finish Printing
            Console.Write("\nThank you for using the dice throwing simulator. Goodbye!");
        }

        }
}
