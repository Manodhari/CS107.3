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

            
            int subtraction = firstNumber - secondNumber;

            
            int multiplication = firstNumber * secondNumber;

            
            int division = firstNumber / secondNumber;

            Console.WriteLine("The sum of the two numbers is: " + sum);
            Console.WriteLine("The subtraction of the two numbers is: " + subtraction);
            Console.WriteLine("The multiplication of the two numbers is: " + multiplication);
            Console.WriteLine("The division of the two numbers is: " + division);
        }
    }
}
