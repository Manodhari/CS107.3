using System;

namespace ConsoleApplication
{
    class AnotherClass
    {
        public void createArray(int size)
        {
            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter the value for index {0}: ", i);
                int value = int.Parse(Console.ReadLine());
                array[i] = value;

              
                array[i + 1] = 0;
            }

            
            for (int i = 0; i < size + 1; i++)
            {
                Console.WriteLine("The value at index {0} is {1}", i, array[i]);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {  
            Console.WriteLine("Enter the array size: ");
            int size = int.Parse(Console.ReadLine());

          
            AnotherClass anotherClass = new AnotherClass();

            
            anotherClass.createArray(size);
        }
    }
}
