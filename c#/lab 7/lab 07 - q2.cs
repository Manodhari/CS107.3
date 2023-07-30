using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Enter the array size: ");
            int arraySize = int.Parse(Console.ReadLine());

            int[] array1 = new int[arraySize];
            int[] array2 = new int[arraySize];
            int[] arraySum = new int[arraySize];

          
            for (int i = 0; i < arraySize; i++)
            {
                Console.WriteLine("Enter the value for index {0} of array1: ", i);
                array1[i] = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the value for index {0} of array2: ", i);
                array2[i] = int.Parse(Console.ReadLine());
            }

           
            for (int i = 0; i < arraySize; i++)
            {
                arraySum[i] = array1[i] + array2[i];
            }

            
            Console.WriteLine("The vector sum is: ");
            for (int i = 0; i < arraySize; i++)
            {
                Console.WriteLine("The value at index {0} is {1}", i, arraySum[i]);
            }
        }
    }
}
