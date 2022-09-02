using System;
using System.Collections.Generic;
using System.Text;

namespace DAY_2
{
    class Class
    {
        static void Main1(string[] args)
        {


            Console.WriteLine("Enter a Number to check:  ");
            int num;
            num = Convert.ToInt32(Console.ReadLine());

            if 
                (num % 2 == 0)
            {
                Console.WriteLine("{0} is an even number .", num);

            }
            else {
                Console.WriteLine("{0} is an odd number .", num);
            }

            
        }
    }
}
