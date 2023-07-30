using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("Enter the radius of the circle: ");
            float radius = float.Parse(Console.ReadLine());

           
            float area = Math.PI * radius * radius;

            
            float circumference = 2 * Math.PI * radius;

           
            Console.WriteLine("The area of the circle is: " + area);
            Console.WriteLine("The circumference of the circle is: " + circumference);
        }
    }
}
