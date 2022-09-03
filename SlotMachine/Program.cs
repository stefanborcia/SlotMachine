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
                
                UserInterface.PrintPressSpaceBar();
                //askind user to pres spacebar to spin
                while (!(Console.ReadKey(true).Key == ConsoleKey.Spacebar))
                {
                    UserInterface.PrintPressSpaceBar();
                }

                int[,] grid = LogicMethods.CreateGrid();
                UserInterface.PrintGrid(grid);
                
                int winValue = LogicMethods.CalculateLineWinings(grid);

                bool jackpot = LogicMethods.CheckJackpotWin(grid);
                //Check if is Jackpot 7-7-7 
                if (jackpot == true)
                {
                    winValue = 10;
                    betCredit += winValue;
                    UserInterface.PrintJackpotWin(winValue);
                }
                //Check if line is wining                
                if (winValue > 0 && jackpot == false)
                {
                    betCredit = betCredit + winValue;
                    UserInterface.PrintLineWining(winValue);
                }

                betCredit--;
               
                
                
                if (betting)
                {
                    if (betCredit < 1)
                    {
                        UserInterface.AskNextRound();

                        if (UserInterface.ReadContinuePlaying())
                        {
                            
                            UserInterface.PrintSucces();
                            betCredit = UserInterface.ReadNumber();
                            betting = true;
                        }
                        else
                        {
                            UserInterface.PrintByeByeMessage();
                            betting = false;
                        }
                        

                    }
                    
                }

                

            }
        }
    }
}

