using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8Abstract
{
    class Squre : Shape
    {
        public override double Area()
        {
            return (Math.Pow(Sides[0], 2));
        }

        public override void Print()
        {
            Console.WriteLine("this is a squre");
        }
    }
}
