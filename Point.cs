using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game1
{
    class Point
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public void ShowCoordinate()
        {
            Console.WriteLine("X = {0}, Y = {1}", X, Y);
        }
    }
}
