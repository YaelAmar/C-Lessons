using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    class Program
    {
        static void Main(string[] args)
        {//פונקציה סטטית
            /*
            Student[] myClass = new Student[5];
            for (int i = 0; i < myClass.Length; i++)
            {
                myClass[i] = new Student();
                myClass[i].GetDetails();
            }
            Console.WriteLine(Student.Avg());
            */

            Console.WriteLine(   OurMath.Convert(1001111));
            Console.ReadLine();
        }
    }
}
