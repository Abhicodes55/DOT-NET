using System;
using System.Collections.Generic;
using System.Text;

namespace Mini_Project__Day_5_
{
    class Photobook 
    {
        protected int pages;
        public void Getpages(int pages)
        {
            
            Console.WriteLine("There are "+pages + " Number of pages in Album");  
        }
       public Photobook (int pages = 16)
        {
            Console.WriteLine("There are "+pages + " Number of pages in Album");
        }
      
    }
    class Bigphotobook
    {
        public Bigphotobook(int pages = 64)
        {
            Console.WriteLine("There are "+ pages + " Number of pages in Album");
        }
    }
    class M
    {
        public static void Main()
        {
            Photobook P = new Photobook();
            Console.WriteLine("Enter the number of pages in Album: ");
            P.Getpages(Convert.ToInt32(Console.ReadLine()));
            Bigphotobook B = new Bigphotobook();
        }
    }
}
