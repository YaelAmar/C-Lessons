using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2b
{
   public class Student
    {
        public static int NumOfStudent { get; set; }

        public string FirstName { get; set; }
        public string  LsatName { get; set; }
        private readonly string id;
        public string ID { get { return id; } }
      

        private DateTime borndate;

        public DateTime Borndate
        {
            get { return borndate; }
            set { borndate = value; }
        }

        public Student()
        {
            NumOfStudent++;
        }

        public Student(string firstName, string lsatName, DateTime borndate):this()
        {
            FirstName = firstName;
            LsatName = lsatName;
            Borndate = borndate;
            
        }
        public Student(Student student):this()
        {
            student = new Student();
            student.Borndate = Borndate;
            student.LsatName = LsatName;
            student.FirstName = FirstName;
        }
        public TimeSpan Age()
        {
            return DateTime.Now - Borndate;
           
        }
    }
}
