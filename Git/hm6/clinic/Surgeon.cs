using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git.hm6.clinic
{
    internal class Surgeon : Doctor
    {
        public override void Treat()
        {
            Console.WriteLine("Surgeon treat started");
        }
    }
}
