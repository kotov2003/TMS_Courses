using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git.hm6.Triangles
{
    internal class TriangleBuilder
    {
        public TriangleBuilder() { }


        public Triangle CreateTriangle(double firstSide, double secondSide, double thirdSide)
        {
            if ((firstSide == secondSide) && (firstSide == thirdSide))
            {
                return new EquiletarlTriangle(firstSide, secondSide, thirdSide);
            }


            double[] sideArray = new double[3]{ firstSide, secondSide, thirdSide };
            Array.Sort(sideArray);
            double firstSideRounded = Math.Round(sideArray[0], 4, MidpointRounding.ToZero);
            double secondSideRounded = Math.Round(sideArray[1], 4, MidpointRounding.ToZero);
            double thirdSideRounded = Math.Round(sideArray[2], 4, MidpointRounding.ToZero);

            var f_1_1 = firstSideRounded * firstSideRounded + secondSideRounded * secondSideRounded;
            var f_1_2 = thirdSideRounded * thirdSideRounded;

            if (Math.Abs(f_1_1 - f_1_2) < 0.001)
            {
                return new RightTriangle(firstSide, secondSide, thirdSide);
            }

            return new Triangle(firstSide, secondSide, thirdSide);
        }
    }
}
