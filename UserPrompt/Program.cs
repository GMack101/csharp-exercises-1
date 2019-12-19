using System;

namespace UserPrompt
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");

            string name = Console.ReadLine();

            Console.WriteLine("Hello, " + name);
        }
    }
}
