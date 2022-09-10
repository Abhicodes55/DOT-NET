using System;
using System.Collections.Generic;
using System.Text;

namespace Day_4
{
    class Transform
    {
        public static void Main()
        {
            Console.WriteLine("Enter number of Rows : ");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number of Columns : ");
            int col = Convert.ToInt32(Console.ReadLine());

            int[,] matrix= new int[row,col];
            int[,] transpose = new int[row,col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.WriteLine("Enter elements of  Matrix" + "[" + i + "," + j + "]");
                    matrix[i, j] =Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Matrix before Transpose : ");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();

            }
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    transpose[i,j] = matrix[j, i]; 
                }

            }



            Console.WriteLine("Matrix after Transpose : ");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                   Console.Write(transpose[i, j]+"\t");
                }
                Console.WriteLine();

            }
        }
    }
}
