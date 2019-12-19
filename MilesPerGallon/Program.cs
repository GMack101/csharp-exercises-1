using System;

namespace MilesPerGallon
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double miles;
            double gallons;
            double mpg;

            Console.WriteLine("Enter miles driven:");
            miles = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter gallons of gas used:");
            gallons = double.Parse(Console.ReadLine());

            mpg = miles / gallons;

            Console.WriteLine("Miles per gallon: " + mpg);
        }
    }
}
