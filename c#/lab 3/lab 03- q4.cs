using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Enter an upper limit: ");
            int upperLimit = int.Parse(Console.ReadLine());

            
            int sum = 0;

            for (int i = 1; i <= upperLimit; i += 2)
            {
                sum += i;
            }

          
            Console.WriteLine("The sum of the odd numbers is: " + sum);
        }
    }
}
