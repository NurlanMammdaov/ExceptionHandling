using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpEx
{
    internal class InvailedAgeException : Exception
    {
        public InvailedAgeException(string message) : base(message) { }
    }
}
