using System;

namespace Day_4
{
    class Program
    {
        static void Main1(string[] args)
        { int row, col;
            int[,] matrix = new int[2, 2] { { 1, 2 }, { 3, 4 } }; //pre defined elements
            for (row = 0; row < 2; row++) // printing elements of 2d Array
            {
                for (col = 0; col < 2; col++)
                {
                    Console.Write(matrix[row, col]+"\t");
                }
                Console.WriteLine();
            }
        }
    }
}