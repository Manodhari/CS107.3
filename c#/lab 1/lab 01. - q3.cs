using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the first number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int secondNumber = int.Parse(Console.ReadLine());

            int sum = firstNumber + secondNumber;

            Console.WriteLine("The sum of the two numbers is: " + sum);
        }
    }
}
