using System;

namespace DAY_5
{ 




    abstract class Animal
    {  public string name;
        public void Getname()
        {
            Console.WriteLine("Enter name of Dog:");
           
        }
        public void Setname()
        {
            name = Console.ReadLine();
        }
        abstract public void Eat();
    }
    class Dog:Animal
    {  
        override public void Eat()
        {
            Console.WriteLine( name + " is Eating !");
        }
        static void Main3(string[] args)
        {
            Dog d1 = new Dog();
            d1.Getname();
            d1.Setname();
            d1.Eat();
        }
    }
}
