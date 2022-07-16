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
            int number = 0;
            bool succes = int.TryParse(Console.ReadLine(), out number);
            if (!succes)
            {
                Console.WriteLine("Please enter a number ! ");
                succes = true;
            }
            Console.WriteLine(" ");

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
                if (grid[0, 0] == grid[0, 1] && grid[0, 1] == grid[0, 2])
                {
                    Console.WriteLine($"Total win is: {number}$ ");
                    number = number + 7;
                }
                if (grid[1, 0] == grid[1, 1] && grid[1, 1] == grid[1, 2])
                {
                    Console.WriteLine($"Total win is: {number}$ ");
                    number = number + 10;
                }
                if (grid[2, 0] == grid[2, 1] && grid[2, 1] == grid[2, 2])
                {
                    Console.WriteLine($"Total win is: {number}$");
                    number = number + 5;
                }
                Console.WriteLine("-----");
                number--;
                Console.WriteLine($"You have credit: {number}$ ");

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
                if (number <= 0)
                {
                    Console.WriteLine("You are out of money ");
                    betting = false;
                }
            }

        }
    }
}