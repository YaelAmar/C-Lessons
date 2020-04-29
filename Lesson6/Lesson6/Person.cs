using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
  public class Person
    {
        public string  FirstName { get; set; }
        public string LastName { get; set; }
        public Person()
        {

        }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public virtual void GetDetails()
        {
            Console.WriteLine("enter first name");
           FirstName= Console.ReadLine();
            Console.WriteLine("enter last name");
            LastName = Console.ReadLine();

        }
        public virtual void Print()
        {
            Console.WriteLine("this is a Person--------");
            Console.WriteLine(FirstName);
            Console.WriteLine(LastName);

        }
    }
}
