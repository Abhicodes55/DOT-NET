using System;
using System.Collections.Generic;
using System.Text;

namespace Day_4
{
    //Program to check whether a string is Palindrome or not
    class palindrome
    {
        public static void Main9()
        {
            Console.WriteLine("Enter a string to check : ");
            string s = Console.ReadLine(); // Getting string input from user
            string rev = string.Empty; // initialisng rev to empty
            for (int i = s.Length - 1; i >= 0; i--) // Reversing the string
            {
                rev += s[i].ToString(); //Storing the reversed string in rev 
            }
             if (rev == s)//  checking condition
             {
                    Console.WriteLine(s + " is a Palindrome string : ");
             }
              else
              {
                    Console.WriteLine(s + " is not a Palindrome string : ");
              }
             

            
        }
    }
}

