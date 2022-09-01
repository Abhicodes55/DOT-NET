using System;

namespace DAY_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter two numbers to check for the greater number: ");
            int first, second;
            first = Convert.ToInt32(Console.ReadLine());
            second = Convert.ToInt32(Console.ReadLine());
            if (first>second)
            {
                Console.WriteLine("{0} is greater than {1}",first,second);
            }
            else
            {
                Console.WriteLine("{0} is greater than {1}", second, first );
            }
        }
    }
}
