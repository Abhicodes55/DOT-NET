using System;
using System.Collections.Generic;
using System.Text;

namespace DAY_2
{
    class Class2
    {
        static void Main2(string[] args)

        {

            Console.WriteLine("Enter three numbers to check for the Largest number:  ");
            int a, b, c;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            if ((a > b)&(a>c))
                    {
                Console.WriteLine("{0} is the largest:  ", a);
                    }
            else if ((b > a) & (b > c))
            {
                Console.WriteLine("{0} is the largest:  ", b);
                    }
            else
            {
                Console.WriteLine("{0} is the largest:  ", c);
            }

        }
    }
}
