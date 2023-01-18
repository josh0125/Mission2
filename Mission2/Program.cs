using System;

namespace Mission2
{
    class Program
    {
        public static void Main(string[] args)
        {
            string numberOfRolls = "";

            Console.WriteLine("Welcome to the dice throwing simulator!");
            Console.Write("How many dice rolls would you like to simulate? ");
            numberOfRolls = Console.ReadLine();

            Console.WriteLine("DICE ROLLING SIMULATION RESULTS.\nEach '*' represents 1 % of the total number of rolls.\nTotal number of rolls = " + numberOfRolls + "\n\n");

            RollDice(numberOfRolls);

        }
        static void RollDice(string dice)
        {
            int numberOfRolls = int.Parse(dice);

            int[] rolls = new int[13];

            for (int i = 0; i < numberOfRolls; i++)
            {
                Random rnd = new Random();
                int num1 = rnd.Next(1, 7);
                int num2 = rnd.Next(1, 7);
                int totalNum = num1 + num2;
                  
                rolls[totalNum] = rolls[totalNum] + 1;
            }


            PrintTotals(rolls, numberOfRolls);

        }

        static void PrintTotals(int[] rolls, int numberOfRolls)
        {
            for (int i = 2; i <= 12; i++)
            {
                Console.Write(i + ": " + rolls[i] + "  ");

                int roll = rolls[i] * 100;

                double stars = ((roll / numberOfRolls));

                Math.Round(stars);

                for (int ii = 2; ii < stars; ii++)
                {
                    Console.Write("*");
                }

                Console.Write("\n");
            }

            Console.Write("\nThank you for using the dice throwing simulator. Goodbye!");
        }

        }
}
