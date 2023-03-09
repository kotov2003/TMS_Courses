using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git.hm6.Triangles
{
    internal class Square : Rectangle
    {
        public Square(double firstSide) : base(firstSide, firstSide)
        {

        }

        public override double GetSquare()
        {
            Console.WriteLine("Get Square area");
            return Math.Pow(firstSide, 2);
        }
    }
}
