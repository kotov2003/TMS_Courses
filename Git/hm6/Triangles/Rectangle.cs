using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git.hm6.Triangles
{
    internal class Rectangle:Shape
    {
        public double firstSide;

        public double secondSide;

        public Rectangle(double firstSide, double secondSide)
        {
            this.firstSide = firstSide;
            this.secondSide = secondSide;
        }

        public override double GetSquare()
        {
            Console.WriteLine("Get Rectangle area");
            return firstSide * secondSide;
        }
    }
}
