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

            Console.WriteLine("Welcome to the Slot Machine !!! Succes !!!");
            Console.WriteLine("Spin by pressing the SpaceBar on Keyboard");
            Console.WriteLine("Enter how much money you want to spend: $");

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
                        grid[i, j] = lineRandom.Next(1, 8);
                        Console.Write(grid[i, j] + " ");
                    }
                    Console.WriteLine(" ");
                }
                bool win = false;
                int winValue = 0;
                //Create if statements which check if the middle line is the same
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

                
                // check if diagonally they are the same
                if (grid[0, 0] == grid[1, 1] && grid[1, 1] == grid[2, 2]
                    || grid[2, 0] == grid[1, 1] && grid[1, 1] == grid[0, 2])
                {
                    win = true;
                    winValue = 1;
                }
                if (win == true)
                {
                    Console.WriteLine("***********");
                    Console.WriteLine($"You won {winValue}$");
                    credit = credit + winValue;
                    Console.WriteLine("***********");
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
                    Console.WriteLine("*********************************************");
                    Console.WriteLine($" Congratulation !!!  Jackpot !!! You won {winValue}$");
                    credit = credit + 10;
                    Console.WriteLine("**********************************************");
                }
                credit--;
                Console.WriteLine("-----");
                Console.WriteLine($"Your Balance is : {credit}$");
                Console.WriteLine("-----");
                
                //askind user to pres spacebar to spin
                if (Console.ReadKey(true).Key == ConsoleKey.Spacebar)
                {
                    betting = true;
                }
                else
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("You need to press the SpaceBar on keyboard to play");
                    betting = true;
                }
                if (credit <= 0)
                {
                    Console.WriteLine("You are out of money ");
                    //ask to play again 
                    Console.WriteLine("Would you like to add more money? Y or N ");
                    string response = Console.ReadLine();

                    if (response != "n")
                    {
                        betting = true;
                        Console.WriteLine("I wish you good luck !");
                        Console.WriteLine("How much you would like to play this time ?");
                        int betAgain = Convert.ToInt32(Console.ReadLine());
                        credit = betAgain;
                    }
                    else
                    {
                        betting = false;
                        Console.WriteLine("Thank you for playing !");
                        Console.WriteLine("Maybe next time more luck !");
                    }
                }

            }

        }
    }
}
