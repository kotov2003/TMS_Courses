using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git.hm8
{
    internal class WrongPasswordException : Exception
    {
        public WrongPasswordException() { }

        public WrongPasswordException(string msg) : base(msg) { }
    }
}
