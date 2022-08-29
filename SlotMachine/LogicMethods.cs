﻿using System;
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
            int[,] grid = new int[3, 3];
            Random lineRandom = new Random();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    grid[i, j] = lineRandom.Next(2, 8);
                }
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

        public static int ReadNumber()
        {
            int betCredit = 0;
            UserInterface.PrintAskBetMoney();
            UserInterface.PrintEmptyLine();            
           while ( betCredit <= 0)
            {
                int.TryParse(Console.ReadLine(), out betCredit);               
                if(betCredit < 1)
                {
                    Console.WriteLine("Please enter a valid number");
                }    
                
            }
            return betCredit;
        }
        public static bool ReadContinuePlaying()
        {
            UserInterface.AskNextRound();
            string response = Console.ReadLine();
            response = response.ToLower();
            if (response == "y")
            {               
                UserInterface.PlayAgainMessage();                
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
