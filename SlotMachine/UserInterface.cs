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
            Console.WriteLine("Welcome to the Slot Machine !!! Succes !!!");
            Console.WriteLine("Spin by pressing the SpaceBar on Keyboard");
            Console.WriteLine("Enter how much money you want to spend: $");
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
    }
}
