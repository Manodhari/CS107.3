using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            int sum = 0;

          
            while (number > 0)
            {
                int digit = number % 10;
                sum += digit;
                number = number / 10;
            }

            Console.WriteLine("The sum of the digits is: " + sum);
        }
    }
}
