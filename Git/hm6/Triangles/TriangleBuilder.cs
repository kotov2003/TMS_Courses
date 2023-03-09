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

            var f_1_1 = Math.Round(firstSide * firstSide + secondSide * secondSide, 2);
            var f_1_2 = Math.Round(thirdSide * thirdSide, 2);

            var f_2_1 = Math.Round(firstSide * firstSide + thirdSide * thirdSide, 2);
            var f_2_2 = Math.Round(secondSide * secondSide, 2);

            var f_3_1 = Math.Round(thirdSide * thirdSide + secondSide * secondSide, 2);
            var f_3_2 = Math.Round(firstSide * firstSide, 2);

            if ((f_1_1 == f_1_2) || (f_2_1 == f_2_2) || (f_3_1 == f_3_2))
            {
                return new RightTriangle(firstSide, secondSide, thirdSide);
            }
            return new Triangle(firstSide, secondSide, thirdSide);
        }
    }
}
