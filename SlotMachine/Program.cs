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

            int credit = LogicMethods.GetNumber();

            bool betting = true;

            while (betting)
            {
                int winValue = 0;

                int[,] grid = LogicMethods.CreateGrid();

                winValue = LogicMethods.CalculateLineWinings(grid);

                if (winValue > 0)
                {
                    credit = credit + winValue;
                    UserInterface.PrintLineWining(winValue);
                }
                //Check if he wins Jackpot 7-7-7 
                bool jackpot = LogicMethods.CheckJackpotWin(grid);

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
                if (credit <= 5)
                {
                    
                   betting = LogicMethods.ContinuePlaying(credit); 

                    //UserInterface.AskNextRound();
                    //string response = Console.ReadLine();
                    //response = response.ToLower();
                    //if (response == "y")
                    //{
                    //    betting = true;
                    //    UserInterface.PlayAgainMessage();
                    //    int betAgain = Convert.ToInt32(Console.ReadLine());
                    //    credit = betAgain;
                    //}
                    //else
                    //{
                    //    betting = false;
                    //    UserInterface.ByeByeMessage();
                    //}
                }
            }
        }


    }
}

