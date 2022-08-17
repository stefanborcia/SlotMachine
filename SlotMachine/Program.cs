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

            UserInterface.DisplayWelcomeAndInfo();

            int credit = 0;
            bool succes = int.TryParse(Console.ReadLine(), out credit);
            if (!succes)
            {
                Console.WriteLine("Please enter a number ! ");
                succes = true;
            }

            bool betting = true;

            while (betting)
            {
                Random lineRandom = new Random();
                int cols = 3;
                int rows = 3;
                Console.WriteLine("-----");
                int[,] grid = new int[cols, rows];
                int winValue = 0;

                for (int i = 0; i < cols; i++)
                {
                    for (int j = 0; j < rows; j++)
                    {
                        grid[i, j] = lineRandom.Next(1, 5);
                        Console.Write(grid[i, j] + " ");
                    }
                    Console.WriteLine(" ");
                }
                //Check Horizontal Winings
                winValue = CalculateLineWinings(grid);

                if ( winValue > 0)
                {
                    credit = credit + winValue;
                    UserInterface.PrintLineWining(winValue);                   
                }
                //Check if he wins Jackpot 7-7-7 
                bool jackpot = CheckJackpotWin(grid);              
                //if (grid[0, 0] == 7 && grid[0, 1] == 7 && grid[0, 2] == 7)
                //{
                //    jackpot = true;
                //    credit = credit + 10;
                //}
                //if (grid[2, 0] == 7
                //    && grid[2, 1] == 7
                //    && grid[2, 2] == 7)
                //{
                //    jackpot = true;
                //    credit = credit + 10;
                //}
                //if (grid[1, 0] == 7 && grid[1, 1] == 7 && grid[1, 2] == 7)
                //{
                //    jackpot = true;
                //    credit = credit + 10;
                //}
                if (jackpot == true)
                {
                    UserInterface.PrintJackpotWin(winValue);  
                    credit = credit + 10;
                }
                credit--;
                UserInterface.YourBalanceIs(credit);

                //askind user to pres spacebar to spin
                if (Console.ReadKey(true).Key == ConsoleKey.Spacebar)
                {
                    betting = true;
                }
                else
                {
                    UserInterface.PressSpaceBar();
                    betting = false;
                }
                if (credit <= 0)
                {
                    UserInterface.OutOfMoneyOrPutMoreMoney();
                    string response = Console.ReadLine();
                    response = response.ToLower();
                    if (response == "y")
                    {
                        betting = true;
                        UserInterface.PlayAgainMessage();
                        int betAgain = Convert.ToInt32(Console.ReadLine());
                        credit = betAgain;
                    }
                    else
                    {
                        betting = false;
                        UserInterface.ByeByeMessage();
                    }
                }
            }
        }
        static int CalculateLineWinings(int[,] grid)
        {          
            if (grid[0, 0] == grid[0, 1] && grid[0, 1] == grid[0, 2])
            {
                return 3;
            }
            if (grid[1, 0] == grid[1, 1] && grid[1, 1] == grid[1, 2])
            {
                return  7;
            }
            if (grid[2, 0] == grid[2, 1] && grid[2, 1] == grid[2, 2])
            {
                return  5;
            }
            return 0;
        }           
        static bool CheckJackpotWin(int[,] grid)
        {

            if (grid[0, 0] == 7 && grid[0, 1] == 7 && grid[0, 2] == 7
                || grid[2, 0] == 7 && grid[2, 1] == 7 && grid[2, 2] == 7
                || grid[1, 0] == 7 && grid[1, 1] == 7 && grid[1, 2] == 7)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}

