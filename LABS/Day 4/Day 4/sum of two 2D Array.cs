using System;
using System.Collections.Generic;
using System.Text;

namespace Day_4
{
    class Class1
    {
        public static void Main6()
        {

            Console.WriteLine("Enter number of Rows of  Array 1: "); //getting size of 2D Array
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number of Columns of  Array 2: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[a, b];
            for (int row = 0; row < a; row++) // getting Array elements from user
            {
                for (int col = 0; col < b; col++)
                {
                    Console.WriteLine("Enter elements of  Array 1" + "[" + row + "," + col + "]");
                    matrix[row, col] = Convert.ToInt32(Console.ReadLine());//Storing elements in Array
                }
            }
            Console.WriteLine("\nElements of  Array 1 are :- \n");
            for (int row = 0; row < a; row++)// Printing Array elements
            {
                for (int col = 0; col < b; col++)
                {
                    Console.Write(matrix[row, col] + "\t");

                }
                Console.WriteLine();
            }
            Console.WriteLine("\nEnter number of Rows of  Array 2: "); //getting size of 2D Array
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number of Columns of  Array 2: ");
            int d = Convert.ToInt32(Console.ReadLine());
            int[,] matrix_1 = new int[c, d];
            for (int row_1 = 0; row_1 < c; row_1++) // getting Array elements from user
            {
                for (int col_1 = 0; col_1 < d; col_1++)
                {
                    Console.WriteLine("Enter elements of  Array 2" + "[" + row_1 + "," + col_1 + "]");
                    matrix_1[row_1, col_1] = Convert.ToInt32(Console.ReadLine());//Storing elements in Array
                }
            }
            Console.WriteLine("\nElements of  Array 2 are :- \n");
            for (int row_1 = 0; row_1 < a; row_1++)// Printing Array elements
            {
                for (int col_1 = 0; col_1 < b; col_1++)
                {
                    Console.Write(matrix_1[row_1, col_1] + "\t");

                }
                Console.WriteLine();
            }



        }
    }
    }

