using System;

namespace _2DArrays
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[,] twoDimensional = new int[3, 4]
                {//  0, 1, 2, 3
                    {0, 1, 2, 3 },//0
                    {4, 5, 6, 7 },//1
                    {8, 9, 10, 11 }//2
                };

            Console.WriteLine("The location of 1, 3 is: " + twoDimensional[1, 3]);
            Console.WriteLine("------------------------------------------------------------");
            Extension(twoDimensional);
        }

        public static void Extension(int[,] twoDimensional)
        {
            foreach (int first in twoDimensional)
            {
                if (twoDimensional[1, 0] == first || twoDimensional[2, 0] == first)
                {
                    Console.WriteLine("\n");
                }
                Console.Write(string.Join(" ", first, "\t"));
            }

            Console.WriteLine("\n\nWhere is the location of 1 in the two dimensional array?");
            string userInput = Console.ReadLine();

            if (userInput == "0, 1" || userInput == "0,1")
            {
                Console.WriteLine("You got it right");
            }
            else
            {
                Console.WriteLine("You got it wrong\nThe correct answer is 0, 1 or 0,1");
            }
        }
    }
}