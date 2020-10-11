using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = new UTF8Encoding();
            Console.WriteLine("\u05D0\u05D1");
            Console.WriteLine("אריאל");
            Console.WriteLine(new string("אריאל".Reverse().ToArray()));


            Console.WriteLine("עברית");
            Console.ReadLine();

           
        }
    }
}
