using System;
using System.Collections.Generic;
using System.Text;

namespace DAY_10
{   //Func Delegate
    //Action Delegate
    //predicate Delegate
    class Class1
    {
        static int sum (int x,int y)
        {
            return (x + y);
        }
        static void print(int i)
        {
            Console.WriteLine(i);
        }
        static bool Ispositivenum(int val)
        {
            if (val > 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
           public  static void Main()
             {
                Func<int, int, int> add = sum;
                int result = add(10, 20);
                Console.WriteLine("sum: {0}", result);
                Action<int> printvalue = print;
                printvalue(10);
                Predicate<int> predicate = Ispositivenum;
                Console.WriteLine(Ispositivenum(5));

             }
        
    }
}
