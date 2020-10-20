using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class PointException : Exception
    {
        public override string Message => "x must be bigger than y";
    }

}
