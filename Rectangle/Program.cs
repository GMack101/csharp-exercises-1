using System;

namespace Rectangle
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double length;
            double width;
            double area;

            Console.WriteLine("Enter a length:");
            length = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter a width:");
            width = double.Parse(Console.ReadLine());

            area = length * width;

            Console.WriteLine("The area of the rectangle is " + area);
        }
    }
}
