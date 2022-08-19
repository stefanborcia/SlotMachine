using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotMachine
{
    internal class UserInterface
    {
        public static void DisplayWelcomeAndInfo()
        {
            Console.WriteLine("                                               Welcome to the Slot Machine !!! Succes !!!");
            Console.WriteLine("Spin by pressing the SpaceBar on Keyboard");
            Console.WriteLine(" ");
        }
        public static void YourBalanceIs (int credit)
        {
            Console.WriteLine("-----");
            Console.WriteLine($"Your Balance is : {credit}$");
            Console.WriteLine("-----");
        }
        public static void PrintLineWining(int winValue)
        {
            Console.WriteLine("***********");
            Console.WriteLine($"You won {winValue}$");
            Console.WriteLine("***********");
        }
        public static void PrintJackpotWin(int winValue)
        {
            Console.WriteLine("*********************************************");
            Console.WriteLine($" Congratulation !!!  Jackpot !!! You won {winValue}$");
            Console.WriteLine("**********************************************");

        }
        public static void ByeByeMessage()
        {
            Console.WriteLine("Thank you for playing !");
            Console.WriteLine("Maybe next time more luck !");
        }
        public static void PlayAgainMessage()
        {
            Console.WriteLine("We wish you best of luck !");
        }
        public static void AskNextRound()
        {
            Console.WriteLine("You are out of money ");
            Console.WriteLine("Would you like to add more money? Y or N ");
        }
        public static void PressSpaceBar()
        {
            Console.WriteLine(" ");
            Console.WriteLine("You need to press the SpaceBar on keyboard to play");
        }
    }
}
