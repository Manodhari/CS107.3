using System;

namespace ConsoleApplication
{
    class FindValues
    {
        public float findArea(float radius)
        {
            float area = Math.PI * radius * radius;
            return area;
        }

        public float findCircumference(float radius)
        {
            float circumference = 2 * Math.PI * radius;
            return circumference;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
           
            FindValues findValues = new FindValues();

            
            Console.WriteLine("Enter the radius of the circle: ");
            float radius = float.Parse(Console.ReadLine());

           
            float area = findValues.findArea(radius);

            
            float circumference = findValues.findCircumference(radius);

            Console.WriteLine("The area of the circle is: " + area);
            Console.WriteLine("The circumference of the circle is: " + circumference);
        }
    }
}
