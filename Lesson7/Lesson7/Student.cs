using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Mark { get; set; }
        public static int Count { get; set; }
        public static int Sum { get; set; }
        static Student()
        {
            Count = 0;
            Sum = 0;
        }
        public Student()
        {
            Count++;
            Sum += Mark;
        }

        public Student(string firstName, string lastName, int mark)
        {
            Count++;
            FirstName = firstName;
            LastName = lastName;
            Mark = mark;
            Sum += Mark;
        }

        public static double Avg()
        {
            
            return Sum / Count;
        }
        public void GetDetails()
        {
            Console.WriteLine("enter first name");
            FirstName=Console.ReadLine();
            Console.WriteLine("enter last name");
            LastName = Console.ReadLine();
            Console.WriteLine("enter mark");
            Mark =int.Parse( Console.ReadLine());
            Sum += Mark;


        }
    }
}
