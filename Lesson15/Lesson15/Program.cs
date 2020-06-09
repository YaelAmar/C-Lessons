using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15
{
    class Program
    {
        static void Main(string[] args)
        {
            Family family = new Family();
            
            family.LastName = "Kohen";
            family.Father.Print();
            family.Mother.Print();

            Console.ReadLine();
              
        }
    }
}
