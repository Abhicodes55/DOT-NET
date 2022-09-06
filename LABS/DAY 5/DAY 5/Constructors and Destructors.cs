using System;
using System.Collections.Generic;
using System.Text;

namespace DAY_5
{
    public class ConstructorsAndDestructors
    {
        public static void Main()
        {
            int total = 3;
            Person[] persons = new Person[total];
            Console.WriteLine("Enter three Names : ");
            for (int i = 0; i < total; i++)
            {
                persons[i] = new Person(Console.ReadLine());
            }

            for (int i = 0; i < total; i++)
            {
                Console.WriteLine(persons[i].ToString());
            }
        }

        public class Person
        {
            public string Name { get; set; }

            public Person(string name)
            {
                Name = name;
            }

            public override string ToString()
            {
                return "\nHello! My name is " + Name;
            }

            ~Person()
            {
                Name = string.Empty;
            }
        }
    }
}
