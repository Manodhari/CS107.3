using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the radius of the circle: ");
            double radius = double.Parse(Console.ReadLine());

            double area = Math.PI * radius * radius;

            
            Console.WriteLine("The area of the circle is: " + area);
        }
    }
}
