using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {

            InformationForUserWelcome();

            int credit = 0;
            bool succes = int.TryParse(Console.ReadLine(), out credit);
            if (!succes)
            {
                Console.WriteLine("Please enter a number ! ");
                succes = true;
            }
            Random lineRandom = new Random();
            int cols = 3;
            int rows = 3;
            bool betting = true;

            while (betting)
            {

                Console.WriteLine("-----");
                int[,] grid = new int[cols, rows];

                for (int i = 0; i < cols; i++)
                {
                    for (int j = 0; j < rows; j++)
                    {
                        grid[i, j] = lineRandom.Next(1, 5);
                        Console.Write(grid[i, j] + " ");
                    }
                    Console.WriteLine(" ");
                }
                bool win = false;
                int winValue = 0;
                //CheckMiddleLine(int[0,2],true, winValue);
                //Create if statements which check if the middle line is the same
                /*
                if (grid[0, 0] == grid[0, 1] && grid[0, 1] == grid[0, 2])
                {
                    win = true;
                    winValue = 7;
                }
                if (grid[1, 0] == grid[1, 1] && grid[1, 1] == grid[1, 2])
                {
                    win = true;
                    winValue = 3;
                }
                if (grid[2, 0] == grid[2, 1] && grid[2, 1] == grid[2, 2])
                {
                    win = true;
                    winValue = 5;
                }
                */

                // check if diagonally they are the same
                if (grid[0, 0] == grid[1, 1] && grid[1, 1] == grid[2, 2]
                    || grid[2, 0] == grid[1, 1] && grid[1, 1] == grid[0, 2])
                {
                    win = true;
                    winValue = 1;
                }
                if (win == true)
                {
                    credit = credit + winValue;
                    PrintLineWon(winValue);
                }
                //Check if he wins Jackpot 7-7-7 
                bool jackpot = false;
                if (grid[0, 0] == 7 && grid[0, 1] == 7 && grid[0, 2] == 7)
                {
                    jackpot = true;
                    credit = credit + 10;                   
                }
                if (grid[2, 0] == 7
                    && grid[2, 1] == 7
                    && grid[2, 2] == 7)
                {
                    jackpot = true;
                    credit = credit + 10;
                }
                if (grid[1, 0] == 7 && grid[1, 1] == 7 && grid[1, 2] == 7)
                {
                    jackpot = true;
                    credit = credit + 10;
                }
                if(jackpot == true)
                {
                    PrintJackpot(winValue);
                    credit = credit + 10;
                }
                credit--;
                BalanceCredit(credit);
                
                //askind user to pres spacebar to spin
                if (Console.ReadKey(true).Key == ConsoleKey.Spacebar)
                {
                    betting = true;
                }
                else
                {
                    PlayOnSpaceBar();
                    betting = true;
                }
                if (credit <= 0)
                {
                    NoMoreMoneyOrPlayAgain();
                    string response = Console.ReadLine();
                    response = response.ToLower();
                    if (response == "y")
                    {
                        betting = true;
                        PlayingAgainMessage();
                        int betAgain = Convert.ToInt32(Console.ReadLine());
                        credit = betAgain;
                    }
                    else
                    {
                        betting = false;
                        ByeByeMessage();
                    }
                }

            }
            static void PrintLineWon (int winValue)
            {
                Console.WriteLine("***********");
                Console.WriteLine($"You won {winValue}$");
                Console.WriteLine("***********");
            }
            static void PrintJackpot(int winValue)
            {
                Console.WriteLine("*********************************************");
                Console.WriteLine($" Congratulation !!!  Jackpot !!! You won {winValue}$");               
                Console.WriteLine("**********************************************");
            }
            static void BalanceCredit(int credit)
            {
                Console.WriteLine("-----");
                Console.WriteLine($"Your Balance is : {credit}$");
                Console.WriteLine("-----");
            }
            static void ByeByeMessage()
            {
                Console.WriteLine("Thank you for playing !");
                Console.WriteLine("Maybe next time more luck !");
            }
            static void PlayingAgainMessage()
            {
                Console.WriteLine("I wish you good luck !");
                Console.WriteLine("How much you would like to play this time ?");
            }
            static void PlayOnSpaceBar()
            {
                Console.WriteLine(" ");
                Console.WriteLine("You need to press the SpaceBar on keyboard to play");
            }
            static void InformationForUserWelcome()
            {
                Console.WriteLine("Welcome to the Slot Machine !!! Succes !!!");
                Console.WriteLine("Spin by pressing the SpaceBar on Keyboard");
                Console.WriteLine("Enter how much money you want to spend: $");
            }
            static void NoMoreMoneyOrPlayAgain()
            {
                Console.WriteLine("You are out of money ");
                Console.WriteLine("Would you like to add more money? Y or N ");
            }
            /*static void CheckMiddleLine(int[,]grid, bool win, int winValue)
            {
                if (grid[0, 0] == grid[0, 1] && grid[0, 1] == grid[0, 2])
                {
                    win = true;
                    winValue = 7;
                }
                if (grid[1, 0] == grid[1, 1] && grid[1, 1] == grid[1, 2])
                {
                    win = true;
                    winValue = 3;
                }
                if (grid[2, 0] == grid[2, 1] && grid[2, 1] == grid[2, 2])
                {
                    win = true;
                    winValue = 5;
                }
            }*/
        }
    }
}
