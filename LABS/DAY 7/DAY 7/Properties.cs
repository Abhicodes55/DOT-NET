using System;
using System.Collections.Generic;
using System.Text;

namespace DAY_7
{
    class Properties
    {
        int b;
        public int B { get { return b; } set { b = value; } }
    }
    class  M2
    {
         public static void Main()
         {
            Properties p=new Properties();
            Console.WriteLine(p.B= 2);
         }
    }
}
