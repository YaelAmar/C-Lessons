using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15
{
    delegate string FamilyName();
    class Parent
    {
        public string Name { get; set; }
        public string Phone { get; set; }

        public  FamilyName FamilyFunc;

        public void Print()
        {
            if (FamilyFunc != null)
            {
                string s = FamilyFunc();
                Console.WriteLine(Name + " " + s);
            }
        }
    }
}
