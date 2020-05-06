using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8Abstract
{
    class Triangle : Shape
    {
        public int Height { get; set; }

        public override double Area()
        {
            return (Sides[0] * Height) / 2;
        }

        public override void Print()
        {
            Console.WriteLine("this is a triangle");
        }
    }
}
