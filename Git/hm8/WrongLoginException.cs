using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git.hm8
{
    internal class WrongLoginException : Exception
    {
        public WrongLoginException() { }

        public WrongLoginException(string msg) : base(msg) { }
    }
}
