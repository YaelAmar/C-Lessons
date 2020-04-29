using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    class Principale:Teacher
    {
        public int Bonus { get; set; }

        public override void Print()
        {
            Console.WriteLine("this is a Principale");
        }
    }
}
