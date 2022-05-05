using System;
using SomeLibrary;

namespace ClientProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 1);
            Point p2 = new Point(4, 1);
            Point p3 = new Point(4, 4);

            Triangle triangle = new Triangle(p1,p2,p3);

            Console.WriteLine(triangle);
        }
    }
}
