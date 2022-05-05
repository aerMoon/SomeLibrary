using System;
using System.Collections.Generic;
using System.Text;

namespace SomeLibrary
{
    public class Point
    {
        public int x, y;

        public Point (int a = 0, int b = 0)
        {
            x = a; y = b; 
        }

        public override string ToString()
        {
            return $"точка {x}.{y}";
        }
    }
}
