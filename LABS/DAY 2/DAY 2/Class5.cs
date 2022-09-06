using System;
using System.Collections.Generic;
using System.Text;

namespace DAY_2
{
    class Class5
    {
       public static void Main()
        {
            Console.WriteLine("Enter any value");
            string g = Console.ReadLine() ;
           
            int result;
          bool isnum =int.TryParse(g, out result);
                if (isnum == true)
                {
                Console.WriteLine(" Numeric value");
                }
            else
            {
                Console.WriteLine(" Please enter a numeric value");
            }
        }
    }
}
