namespace SlotMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {

            UserInterface.DisplayWelcomeAndInfo();

            int betCredit = UserInterface.ReadNumber();

            bool betting = true;

            while (betting)
            {
                UserInterface.PrintBalance(betCredit);
                int[,] grid = LogicMethods.CreateGrid();
                UserInterface.PrintGrid(grid);

                int winValue = LogicMethods.CalculateLineWinings(grid);

                bool jackpot = LogicMethods.CheckJackpotWin(grid);
                //Check if is Jackpot 7-7-7 
                if (jackpot == true)
                {
                    betCredit = betCredit + 10;
                    UserInterface.PrintJackpotWin(betCredit);
                }
                //Check if line is wining                
                if (winValue > 0 && jackpot == false)
                {
                    betCredit = betCredit + winValue;
                    UserInterface.PrintLineWining(winValue);
                }
                UserInterface.PrintPressSpaceBar();
                //askind user to pres spacebar to spin
                
                betCredit--;
               
                if (betting)
                {
                    while (betCredit <= 0)
                    {
                        UserInterface.AskNextRound();
                        
                        if (UserInterface.ReadContinuePlaying())
                        {
                           
                            UserInterface.PrintSucces();
                            betCredit = UserInterface.ReadNumber();
                           
                        }
                        else
                        {
                            UserInterface.PrintByeByeMessage();
                            betting = false;
                        }

                    
                    }
                    
                    
                }

                while (!(Console.ReadKey(true).Key == ConsoleKey.Spacebar))
                {
                    UserInterface.PrintPressSpaceBar();
                }

            }
        }
    }
}

