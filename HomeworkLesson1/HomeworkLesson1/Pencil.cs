using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkLesson1
{
    class Pencil
    {
        internal string company;
        internal string color;
        internal bool hasEreaser;

        internal void Write()
        {
            Console.WriteLine("the pencil is writing");
        }

        internal void Erase()
        {
            if(hasEreaser==true)
                Console.WriteLine("the pencil is ereaseing now");

            else
                Console.WriteLine("the pencil has no ereaser");
        }


        internal void Write2()
        {
            Console.WriteLine("the pencil is writing 2");
        }
    }
}
