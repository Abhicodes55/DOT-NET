using System;
using System.Collections.Generic;
using System.Text;

namespace DAY_2
{
    class Class3
    {
        static void Main5(string[] args)

        {
            int a, b, choice; //variable declaration
            Console.WriteLine("Enter two numbers :  ");
            a = Convert.ToInt32(Console.ReadLine()); // getting user input
            b = Convert.ToInt32(Console.ReadLine()); // getting user input
           
                Console.WriteLine("press 1:add  2:sub  3:mul  4:div   ");
            Console.WriteLine("Enter your choice:  ");
            choice = Convert.ToInt32(Console.ReadLine()); // getting user coice as input
            
                switch (choice)
                {
                    case 1:
                        Console.WriteLine(a + b);
                        break;

                    case 2:
                        Console.WriteLine(a - b);
                        break;
                    case 3:
                        Console.WriteLine(a * b);
                        break;
                    case 4:
                        Console.WriteLine(a / b);
                        break;
                    default:
                        Console.WriteLine("please enter a valid choice :");
                        break;


                }
            




        }
    }
}
