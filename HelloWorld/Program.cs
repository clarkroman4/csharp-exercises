using System;

namespace HelloWorld
{
   class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a width: ");
            int width = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a height: ");
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine("The area of the rectangle is " + height * width);
        }
    }
}
