using System;
using System.Collections.Generic;
using System.Text;

namespace Day_4
{
    class Multiplication
    {
        public static void Main()
        {

            Console.WriteLine("Enter number of Rows of  Array 1: "); //getting size of 2D Array 1
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number of Columns of  Array 1: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[a,b];
            for (int row = 0; row < a; row++) // getting Array 1 elements from user
            {
                for (int col = 0; col < b; col++)
                {
                    Console.WriteLine("Enter elements of  Array 1" + "[" + row + "," + col + "]");
                    matrix[row, col] = Convert.ToInt32(Console.ReadLine());//Storing elements in Array
                }
            }
            Console.WriteLine("\nElements of  Array 1 are :- \n");
            for (int row = 0; row < a; row++)// Printing Array 1 elements
            {
                for (int col = 0; col < b; col++)
                {
                    Console.Write(matrix[row, col] + "\t");

                }
                Console.WriteLine();
            }
            Console.WriteLine("\nEnter number of Rows of  Array 2: "); //getting size of 2D Array 2
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number of Columns of  Array 2: ");
            int d = Convert.ToInt32(Console.ReadLine());
            int[,] matrix_1 = new int[c, d];
            for (int row_1 = 0; row_1 < c; row_1++) // getting Array 2 elements from user
            {
                for (int col_1 = 0; col_1 < d; col_1++)
                {
                    Console.WriteLine("Enter elements of  Array 2" + "[" + row_1 + "," + col_1 + "]");
                    matrix_1[row_1, col_1] = Convert.ToInt32(Console.ReadLine());//Storing elements in Array
                }
            }
            Console.WriteLine("\nElements of  Array 2 are :- \n");
            for (int row_1 = 0; row_1 < c; row_1++)// Printing Array elements
            {
                for (int col_1 = 0; col_1 < d; col_1++)
                {
                    Console.Write(matrix_1[row_1, col_1] + "\t");

                }
                Console.WriteLine();
            }
            if (b != c)
            {
                Console.WriteLine("Matrix multipllication is not possible");
            }
            else
            {
                int[,] matrixsum = new int[10,10];
                for (int i = 0; i < b; i++)
             
                    for (int j = 0; j <d; j++)
                        matrixsum[i, j] = 0;
                        for (int i = 0; i <b; i++)// row of first matrix 
                        {
                          for (int j = 0; j < d; j++)// column of second matrix
                          {
                           for (int k = 0; k < b; k++)
                           {
                            int sum = 0;
                            sum += matrix[i, k] * matrix_1[k, j];
                            matrixsum[i, j] = sum;
                           }
                          }
                        }  

                        
                    
                
                Console.WriteLine("Multiplication of Matrix 1 and Matrix 2 : ");
                for (int i = 0; i < b; i++) // Printing Sum of Both the Arrays
                {
                    for (int j = 0; j <d; j++)
                    {
                        Console.Write(matrixsum[i, j] + "\t");
                    }
                    Console.WriteLine();
                }







            }
        }
    }
}

