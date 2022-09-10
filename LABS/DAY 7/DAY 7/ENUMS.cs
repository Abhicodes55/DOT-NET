using System;
using System.Collections.Generic;
using System.Text;

namespace DAY_7
{    
    enum Weekdays
    {
        Monday=1,
        Tuesday = 2,
        Wednesday= 3,
        Thrusday= 4,
        Friday= 5,
        Saturday = 6,
        Sunday = 7,
    }
    class M
    { 
        public static void Main3()
        {
            Console.WriteLine(Weekdays.Monday);
            Console.WriteLine((int)Weekdays.Monday);
            Console.WriteLine(Weekdays.Tuesday);
            Console.WriteLine((int)Weekdays.Tuesday);
            Console.WriteLine(Weekdays.Wednesday);
            Console.WriteLine((int)Weekdays.Wednesday);
            Console.WriteLine(Weekdays.Thrusday);
            Console.WriteLine((int)Weekdays.Thrusday);
            Console.WriteLine(Weekdays.Friday);
            Console.WriteLine((int)Weekdays.Friday);
            Console.WriteLine(Weekdays.Saturday);
            Console.WriteLine((int)Weekdays.Saturday);
            Console.WriteLine(Weekdays.Sunday);
            Console.WriteLine((int)Weekdays.Sunday);
            Console.ReadKey();
        } 
    }
}
