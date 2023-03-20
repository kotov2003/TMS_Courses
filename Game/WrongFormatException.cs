using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class WrongFormatException : Exception
    {
        public WrongFormatException() { }
        public WrongFormatException(string msg) : base(msg) { }
    }
}