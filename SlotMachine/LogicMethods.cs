using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotMachine
{
    internal class LogicMethods


    {
        public static int[,] FillArrayRandom()
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
    }
}
