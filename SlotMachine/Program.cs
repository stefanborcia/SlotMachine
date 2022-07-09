using System;

namespace SlotMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Slot Machine !!! Succes !!!");

            Random lineRandom =new Random();

            int line1 = 3;
            int[] arr = new int[line1]; 
            for( int i = 0; i < arr.Length; i++)
            {
                arr[i] = lineRandom.Next(1,8);
                Console.Write(arr[i]);
            }
            Console.WriteLine();
            int line2 = 3;
            int[] arr2 = new int[line2];
            for(int j = 0; j < arr2.Length; j++)
            {
                arr2[j] = lineRandom.Next(1, 8);
                Console.Write(arr2[j]);
            }
            Console.WriteLine();
            int line3 = 3;
            int[] arr3 = new int[line3];
            for(int k = 0; k < arr3.Length; k++)
            {
                Console.Write(arr3[k]);
            }    
        }
    }
}