using System;

namespace DAY_10
{
    class TestDelegates
    {   //Multi cast Delegates

        public delegate  int Numchanger(int n);
        static int num = 10;
        public static int Addnum(int p)
        {
            num += p;
            return num;
        }
        public static int Mulnum(int q)
        {
            num *= q;
            return num;
        }
        public static int getnum()
        {
            return num;
        }
        //Creating Delegates Instances
        public static void Main(string[] args)
        {
            Numchanger nc;
            Numchanger nc1 = new Numchanger(Addnum);
            Numchanger nc2 = new Numchanger(Mulnum);
            nc = nc1;
            nc += nc2;
            //Calling Multicast
            nc(5);
            Console.WriteLine("Value of Num: {0}",getnum());
        }
    }
}
