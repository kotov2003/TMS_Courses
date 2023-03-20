using Git.hm6.Triangles;
using System.Collections;

namespace Git.hm9
{
    public class HomeTask9
    {
        static public void Task_ArrayList()
        {
            ArrayList list = new ArrayList();
            try
            {
                object s = list[18];
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Exception of {ex.GetType()} type: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Task done!");
            }
        }
    }
}
