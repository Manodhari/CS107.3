using System;

namespace ConsoleApplication
{
    class Animal
    {
        public void print()
        {
            Console.WriteLine("I am Animal");
        }
    }

    class Dog : Animal
    {
        public override void print()
        {
            Console.WriteLine("I am Animal");
            Console.WriteLine("I have four legs");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.print();
        }
    }
}
