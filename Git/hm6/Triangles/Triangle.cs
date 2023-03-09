using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git.hm6.Triangles
{
    internal class Triangle
    {
        public double firstSide;

        public double secondSide;

        public double thirdSide;

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            this.firstSide = firstSide;
            this.secondSide = secondSide;
            this.thirdSide = thirdSide;
        }

        public virtual double GetSquare()
        {
            Console.WriteLine("Get square Heron formula");
            double semiPerimetr = (firstSide + secondSide + thirdSide) / 2;
            return Math.Sqrt(semiPerimetr * (semiPerimetr - firstSide) * (semiPerimetr - secondSide) * (semiPerimetr - thirdSide));
        }
    }
}
