using System;
using System.Linq;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string vowels = "aeiouAEIOU";

          
            Console.WriteLine("Enter a string: ");
            string inputString = Console.ReadLine();

           
            int vowelCount = 0;

          
            for (int i = 0; i < inputString.Length; i++)
            {
                if (vowels.Contains(inputString[i]))
                {
                    vowelCount++;
                }
            }

           
            Console.WriteLine("The number of vowels in the string is: " + vowelCount);
        }
    }
}
