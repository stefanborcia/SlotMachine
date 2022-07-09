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

            Random lineRandom =new Random();
            int rows = 3;
            int cols = 3;
            int[,] arr = new int[rows, cols]; 
            for( int i = 0; i < rows; i++)
            {
                for(int j = 0; j < cols; j++)
                {
                    arr[i, j] = lineRandom.Next(1, 8);
                    Console.Write(arr[i, j] + " " );
                }
                Console.WriteLine(" ");
            }
            
        }
    }
}