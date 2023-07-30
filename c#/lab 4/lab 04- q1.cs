
using System;

namespace ConsoleApplication
{
    class ConvertValues
    {
        public static void kilometerTOmeter(int kilometer)
        {
            int meter = kilometer * 1000;
            Console.WriteLine("The equivalent of {0} km in meter is {1} m", kilometer, meter);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ConvertValues convertValues = new ConvertValues();

            Console.WriteLine("Enter the kilometer value: ");
            int kilometer = int.Parse(Console.ReadLine());

            convertValues.kilometerTOmeter(kilometer);
        }
    }
}
