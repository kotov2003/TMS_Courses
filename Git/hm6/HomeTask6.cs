using Git.hm6.Triangles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git.hm6
{
    public class HomeTask6
    {
        static public void Task_TriangleAreas()
        {
            Triangle triangle = new TriangleBuilder().CreateTriangle(3.1, 4.1, 5.14);
            Console.Write(triangle.GetSquare());
        }
    }
}
