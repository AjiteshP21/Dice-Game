using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dice_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int NumberOfRounds = 10;
            const int DiceSides = 6;

            int playerPoints = 0;
            int enemyPoints = 0;

            Random random = new Random();

            for (int i = 0; i < NumberOfRounds; i++)
            {
                System.Console.WriteLine("Press Enter to Roll the Dice...");
                System.Console.ReadLine();

                int playerRoll = RollDice(random, DiceSides);
                int enemyRoll = RollDice(random, DiceSides);

                System.Console.ForegroundColor = ConsoleColor.Green;
                System.Console.WriteLine($"\nYou rolled a {playerRoll}");
                System.Console.ResetColor();

                System.Console.WriteLine("...");
                System.Threading.Thread.Sleep(1000);

                System.Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine($"Enemy AI rolled a {enemyRoll}");
                System.Console.ResetColor();

                if (playerRoll > enemyRoll)
                {
                    playerPoints++;
                    System.Console.ForegroundColor = ConsoleColor.Green;
                    System.Console.WriteLine("\nPlayer wins the round!");
                    System.Console.ResetColor();
                }
                else if (playerRoll < enemyRoll)
                {
                    enemyPoints++;
                    System.Console.ForegroundColor = ConsoleColor.Red;
                    System.Console.WriteLine("\nEnemy wins the round!");
                    System.Console.ResetColor();
                }
                else
                {
                    System.Console.ForegroundColor = ConsoleColor.Yellow;
                    System.Console.WriteLine("\nDraw!");
                    System.Console.ResetColor();
                }

                System.Console.ForegroundColor = ConsoleColor.Cyan;
                System.Console.WriteLine($"\nThe Score is now - Player: {playerPoints}. Enemy: {enemyPoints}.\n");
                System.Console.ResetColor();
            }

            DetermineWinner(playerPoints, enemyPoints);

            System.Console.ReadLine();
        }

        static int RollDice(Random random, int sides)
        {
            return random.Next(1, sides + 1);
        }

        static void DetermineWinner(int playerPoints, int enemyPoints)
        {
            if (playerPoints > enemyPoints)
            {
                System.Console.ForegroundColor = ConsoleColor.Green;
                System.Console.WriteLine("\nYou Win!");
                System.Console.ResetColor();
            }
            else if (playerPoints < enemyPoints)
            {
                System.Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine("\nYou Lose!");
                System.Console.ResetColor();
            }
            else
            {
                System.Console.ForegroundColor = ConsoleColor.Yellow;
                System.Console.WriteLine("\nIt's a Draw!");
                System.Console.ResetColor();
            }
        }
    }
}
