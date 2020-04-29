using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    sealed  class  Student:Person
    {
        public double Avg { get; set; }
        public Student()
        {
                
        }

        public Student(string firstName, string lastName,double avg):base(firstName,lastName)
        {
            Avg = avg;
        }

        public new void GetDetails()
        {
            base.GetDetails();
            Console.WriteLine("enter avg");
            Avg= double.Parse( Console.ReadLine());
        }
        public new void Print()
        {
            Console.WriteLine("this is a student--------");
            base.Print();
            Console.WriteLine(Avg);


        }
    }
}
//code reuse

