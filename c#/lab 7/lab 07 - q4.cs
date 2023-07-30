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
            int[] arrayProduct = new int[arraySize];
            int scalarProduct = 0;

           
            for (int i = 0; i < arraySize; i++)
            {
                Console.WriteLine("Enter the value for index {0} of array1: ", i);
                array1[i] = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the value for index {0} of array2: ", i);
                array2[i] = int.Parse(Console.ReadLine());
            }

           
            for (int i = 0; i < arraySize; i++)
            {
                arrayProduct[i] = array1[i] * array2[i];
            }

            for (int i = 0; i < arraySize; i++)
            {
                scalarProduct += arrayProduct[i];
            }

         
            Console.WriteLine("The scalar product is: " + scalarProduct);
        }
    }
}
