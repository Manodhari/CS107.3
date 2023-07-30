using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter an integer: ");
            int number = int.Parse(Console.ReadLine());

           
            bool isEven = number % 2 == 0;

           
            if (isEven)
            {
                Console.WriteLine("The number is even");
            }
            else
            {
                Console.WriteLine("The number is odd");
            }
        }
    }
}
