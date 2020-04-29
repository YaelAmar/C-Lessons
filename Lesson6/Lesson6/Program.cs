using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.GetDetails();
            student.Print();

            Teacher teacher = new Teacher();
            teacher.GetDetails();
            teacher.Print();

            Console.WriteLine("+++++++++++++++++++++++++++++++++++++");
            (student as Person).Print();
            (teacher as Person).Print();
            Console.ReadLine();
        }
    }
}
