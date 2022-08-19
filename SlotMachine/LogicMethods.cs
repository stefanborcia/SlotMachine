using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotMachine
{
    internal class LogicMethods


    {
        public static int[,] CreateGrid()
        {
            Random lineRandom = new Random();

            int[,] grid = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    grid[i, j] = lineRandom.Next(1, 5);
                    Console.Write(grid[i, j] + " ");
                }
                Console.WriteLine(" ");
            }
            return grid;
        }

        public static bool CheckJackpotWin(int[,] grid)
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
        public static int CalculateLineWinings(int[,] grid)
        {
            if (grid[0, 0] == grid[0, 1] && grid[0, 1] == grid[0, 2])
            {
                return 3;
            }
            if (grid[1, 0] == grid[1, 1] && grid[1, 1] == grid[1, 2])
            {
                return 7;
            }
            if (grid[2, 0] == grid[2, 1] && grid[2, 1] == grid[2, 2])
            {
                return 5;
            }
            return 0;
        }
        public static bool TryGetNumber(string message, out int credit)
        {
            Console.WriteLine(message);
            return int.TryParse(Console.ReadLine(), out credit);

        }
        public static int GetNumber()
        {
            int credit = 0;
            bool succes = TryGetNumber("How much money would you like to play: ", out credit);
            Console.WriteLine(" ");
            while (!succes)
            {
                succes = TryGetNumber("Please enter a valid number: ", out credit);
            }
            return credit;
        }
        public static bool ContinuePlaying(int credit)
        {
            UserInterface.AskNextRound();
            string response = Console.ReadLine();
            response = response.ToLower();
            if (response == "y")
            {               
                UserInterface.PlayAgainMessage();
                int betAgain = LogicMethods.GetNumber();
                credit = betAgain;
                return true;              
            }
            else
            {                
                UserInterface.ByeByeMessage();
                return false;
            }    
            
        }

    }
}
