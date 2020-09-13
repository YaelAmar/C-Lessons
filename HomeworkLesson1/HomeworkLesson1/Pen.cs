using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkLesson1
{
    [Flags]
    enum Color
    {
        yellow=2,
        red=4,
        green=8,
        blue=16,
        black=32
    }

    enum Company
    {
        pilot,
        a,
        b,
        c

    }

    class Pen
    {
        internal string comany;
        internal double width;
        
        public Color Color { get; set; }

        internal void Write()
        {
            Console.WriteLine("the pen is writing");
        }

        internal void Draw()
        {
            Console.WriteLine("the pen is drawing");

        }

        internal void Paint()
        {
            Console.WriteLine("the pen is painting");

        }
    }
}
