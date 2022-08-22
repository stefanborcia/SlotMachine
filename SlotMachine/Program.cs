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

            int pluralCredit = LogicMethods.GetNumber();

            bool betting = true;

            while (betting)
            {
                
                int[,] grid = LogicMethods.CreateGrid();


                 int winValue = LogicMethods.CalculateLineWinings(grid);

                bool jackpot = LogicMethods.CheckJackpotWin(grid);
                //Check if is Jackpot 7-7-7 
                if (jackpot == true)
                {
                    pluralCredit = +10;
                    UserInterface.PrintJackpotWin(pluralCredit);
                }
                //Check if line is wining                
                if (winValue > 0 && jackpot == false)
                {
                    pluralCredit = pluralCredit + winValue;
                    UserInterface.PrintLineWining(winValue);
                }
 
                pluralCredit--;
                UserInterface.YourBalanceIs(pluralCredit);

                //askind user to pres spacebar to spin
                while (!(Console.ReadKey(true).Key == ConsoleKey.Spacebar))
                {                  
                    UserInterface.PressSpaceBar();                   
                }
                if (pluralCredit <= 0)
                {
                    betting = LogicMethods.ContinuePlaying();
                    if (betting)
                    {
                        pluralCredit = LogicMethods.GetNumber();
                    }

                }
            }
        }
    }
}

