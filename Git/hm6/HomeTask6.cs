using Git.hm6.clinic;
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
            Triangle triangle = new TriangleBuilder().CreateTriangle(5.14, 3.1, 4.1);
            Console.Write(triangle.GetSquare());

            Shape[] shapeList = new Shape[] { new Triangle(10, 20, 20), new RightTriangle(3, 4, 5), new Rectangle(2, 3), new Square(5) };

            foreach (var item in shapeList)
            {
                Console.WriteLine(item.GetSquare());
            }
        }

        static public void Task_Clinic()
        {
            Console.WriteLine($"\n{new string('=', 55)}\n#Welcome to \'Task_Clinic!\'#\n{new string('=', 55)}");

            var plan = new TreatmentPlan(2);
            var patient = new Patient();
            patient.AddTreatmentPlan(plan);
            patient.AssignDoctorAndTreat();
        }
    }
}
