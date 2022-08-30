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
                UserInterface.PrintRandomNumbers(grid);

                UserInterface.PressSpaceBar();

                int winValue = LogicMethods.CalculateLineWinings(grid);

                bool jackpot = LogicMethods.CheckJackpotWin(grid);
                //Check if is Jackpot 7-7-7 
                if (jackpot == true)
                {
                    betCredit += 10;
                    UserInterface.PrintJackpotWin(betCredit);
                }
                //Check if line is wining                
                if (winValue > 0 && jackpot == false)
                {
                    betCredit = betCredit + winValue;
                    UserInterface.PrintLineWining(winValue);
                }

                betCredit--;

                //askind user to pres spacebar to spin
                while (!(Console.ReadKey(true).Key == ConsoleKey.Spacebar))
                {
                    UserInterface.PressSpaceBar();
                }
                if (betCredit <= 0)
                {
                    UserInterface.AskNextRound();
                    betting = UserInterface.ReadContinuePlaying() ;
                    
                    if (betting)
                    {
                        betCredit = UserInterface.ReadNumber();
                    }

                }
            }
        }
    }
}

