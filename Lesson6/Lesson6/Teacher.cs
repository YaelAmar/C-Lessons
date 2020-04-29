using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
   public  class Teacher:Person
    {
        public int Salary { get; set; }
        public Teacher()
        {

        }

        public Teacher(string firstName, string lastName,int salary) : base(firstName, lastName)
        {
            this.Salary = salary;
        }

        public override void GetDetails()
        {
            base.GetDetails();
            Console.WriteLine("enter a salary");
           Salary= int.Parse(Console.ReadLine());
        }

        override public void  Print()
        {
            Console.WriteLine("this is a teacher*****************");
            base.Print();
            Console.WriteLine(Salary);
        }
    }
    
}
