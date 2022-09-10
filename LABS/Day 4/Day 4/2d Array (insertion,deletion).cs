using System;
using System.Collections.Generic;
using System.Text;

namespace Day_4
{
    class Class2

    {
        public static void Main()
        {

            Console.WriteLine("Enter number of Rows of 2D Array: "); //getting size of 2D Array
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number of Columns of 2D Array: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[a, b];
            for (int row = 0; row < a; row++) // getting Array elements from user
            {
                for (int col = 0; col < b; col++)
                {
                    Console.WriteLine("Enter elements of 2D Array" + "[" + row + "," + col + "]");
                    matrix[row, col] = Convert.ToInt32(Console.ReadLine());//Storing elements in Array
                }
            }
            Console.WriteLine("\nElements of 2D Array are :- \n");
            for (int row = 0; row < a; row++)// Printing Array elements
            {
                for (int col = 0; col < b; col++)
                {
                    Console.Write(matrix[row, col] + "\t");

                }
                Console.WriteLine();
            }
           
        }
    }
}
