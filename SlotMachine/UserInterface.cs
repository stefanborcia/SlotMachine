using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotMachine
{
    internal class UserInterface
    {
        public static void DisplayWelcomeAndInfo()
        {
            Console.WriteLine("Welcome to the Slot Machine !!! Success !!!");
            Console.WriteLine("Spin by pressing the SpaceBar on Keyboard");
            Console.WriteLine("-----");
        }
        public static void PrintBalance (int pluralCredit)
        {
            Console.WriteLine("-----");
            Console.WriteLine($"Your Balance is : {pluralCredit}$");
            Console.WriteLine("-----");
            
        }
        public static void PrintPressSpaceBar()
        {
            Console.WriteLine("-----");
            Console.WriteLine("Press SpaceBar To Spin");            
        }
        public static void PrintLineWining(int winValue)
        {
            Console.WriteLine("***********");
            Console.WriteLine($"You won {winValue}$");
            Console.WriteLine("***********");
        }
        public static void PrintJackpotWin(int winValue)
        {
            Console.WriteLine("*********************************************");
            Console.WriteLine($" Congratulation !!!  Jackpot !!! You won {winValue}$");
            Console.WriteLine("**********************************************");

        }
        public static void ByeByeMessage()
        {
            Console.WriteLine("Thank you for playing !");
            Console.WriteLine("Maybe next time more luck !");
        }
        public static void PlayAgainMessage()
        {
            Console.WriteLine("We wish you best of luck !");
        }
        public static void AskNextRound()
        {
            Console.WriteLine("You are out of money ");
            Console.WriteLine("Would you like to add more money? Y or N ");
        }
        public static void PressSpaceBar()
        {
            Console.WriteLine("-----");
            Console.WriteLine("You need to press the SpaceBar on keyboard to play");
        }
        public static void PrintRandomNumbers(int[,] grid)
        {
           
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    Console.Write(grid[i,j] + " ");
                }
                Console.WriteLine(" ");
            }
            
            
        }
        public static void PrintEmptyLine()
        {
            Console.WriteLine(" ");
        }
        public static int ReadNumber()
        {
            int betCredit = 0;
            Console.WriteLine("How much money you would like to play ?");
            int.TryParse(Console.ReadLine(), out betCredit);
            if (betCredit < 1)
            {
                Console.WriteLine("Please enter a valid number");
            }
            return betCredit;
        }
    }
}
