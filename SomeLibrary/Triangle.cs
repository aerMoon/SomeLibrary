using System;
using System.Collections.Generic;
using System.Text;

namespace SomeLibrary
{
    public class Triangle
    {
        Point p1 = new Point();
        Point p2 = new Point();
        Point p3 = new Point();

        public Triangle (Point p1, Point p2, Point p3)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
        }
        public double GetAreaFromPoint(Point p1, Point p2, Point p3)
        {
            double a = p2.x - p1.x;
            double b = p3.y - p1.y;
            double c = p3.x - p1.x;
            double d = p2.y - p1.y;

            return  (a*b - c*d)/2;

        }

        public override string ToString()
        {
            return  $"координаты вершин треугольника:\n" +
                    $"{p1}\n{p2}\n{p3}" +
                    $"\nплощадь: {this.GetAreaFromPoint(p1,p2,p3)}";
        }
    }
}
