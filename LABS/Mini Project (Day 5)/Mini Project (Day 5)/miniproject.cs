using System;

namespace Mini_Project__Day_5_
{   
    class Person
    {
        public int age;
        public void Greet()
        {
            Console.WriteLine("hello ! ");
        }
        public void SetAge(int Age)
        {
            age = Age;

        }

    }
    class Student : Person
    {
      public void Study()
      {
            Console.WriteLine("i am studying ");
      }
        public void Showage()
        {
            Console.WriteLine("My age is "+age+" years");
        }
    }


    class Teacher : Person
    {
        public void Explain()
        {
            Console.WriteLine("i am Explaining ");
        }

    }
    class Miniproject
    {
        static void Main()  
        {
            Person P = new Person();
            P.Greet();
            Console.WriteLine();
            Student S = new Student();
            S.SetAge(18);
            S.Greet();
            S.Showage();
            S.Study();
            Console.WriteLine();
            Teacher T = new Teacher();
            T.SetAge(45);
            T.Greet();
            T.Explain();

        }
    }
}
