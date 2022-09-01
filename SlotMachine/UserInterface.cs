namespace SlotMachine
{
    internal class UserInterface
    {
        public static void DisplayWelcomeAndInfo()
        {
            Console.WriteLine("Welcome to the Slot Machine !!! Success !!!");
            Console.WriteLine("Spin by pressing the SpaceBar on Keyboard");
            Console.WriteLine("-----");
        }
        public static void PrintBalance(int pluralCredit)
        {
            Console.WriteLine("-----");
            Console.WriteLine($"Your Balance is : {pluralCredit}$");
            Console.WriteLine("-----");
        }
        public static void PrintLineWining(int winValue)
        {
            Console.WriteLine("***********");
            Console.WriteLine($"You won {winValue}$");
            Console.WriteLine("***********");
        }
        public static void PrintSucces()
        {
            Console.WriteLine("We wish you best of luck !");
            Console.WriteLine("**************************");
        }
        public static void PrintByeByeMessage()
        {
            Console.WriteLine("Thank you for playing !");
            Console.WriteLine("Maybe next time more luck !");
        }
        public static void PrintJackpotWin(int winValue)
        {
            Console.WriteLine("*********************************************");
            Console.WriteLine($" Congratulation !!!  Jackpot !!! You won {winValue}$");
            Console.WriteLine("**********************************************");
        }
        public static void AskNextRound()
        {
            Console.WriteLine("You are out of money ");
            Console.WriteLine("Would you like to add more money? Y or N ");
        }
        public static void PrintPressSpaceBar()
        {
            Console.WriteLine("-----");
            Console.WriteLine("You need to press the SpaceBar on keyboard to play");
        }
        public static void PrintGrid(int[,] grid)
        {
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    Console.Write(grid[i, j] + " ");
                }
                Console.WriteLine(" ");
            }
        }
        public static int  ReadNumber()
        {
            int betCredit = 0;
            Console.WriteLine("How much money you would like to play ?");
            
            while (betCredit <= 0)
            {
                int.TryParse(Console.ReadLine(), out betCredit);
                if (betCredit <=0)
                {
                    Console.WriteLine("Please enter a valid number");
                }
            }
            return betCredit;
        }
        public static bool ReadContinuePlaying()
        {
            string response = Console.ReadLine();
            response = response.ToLower();

            return (response == "y");
        }
    }
}
