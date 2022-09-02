using System;
using System.Collections.Generic;
using System.Text;

namespace DAY_2
{
    class Class4
    {
        public void swap(int c, int d)
        {

            int temp;
            temp = c;
            c = d;
            d = temp;


        }
        static void Main(string[] args)
        {
            Class4 n = new Class4();
            int a, b;
            Console.WriteLine("Enter two numbers  for swap  ");
            Console.WriteLine("\nEnter the first number :  ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter the second numbers :  ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nBefore swap value of a= {0} and b= {1}", a, b);
            n.swap (a, b);
            Console.WriteLine("\nAfter swap value of a= {0} and b= {1}", a, b);
        }
       
    }
}
