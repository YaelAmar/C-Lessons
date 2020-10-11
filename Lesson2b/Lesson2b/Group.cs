using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2b
{
   public class Group
    {
        const string Name = "Our School";
        public Student[] Class { get; set; } = new Student[30];
        public void a()
        {
            Class[0] = new Student() { Borndate = new DateTime(1999, 01, 01), FirstName = "Jeal", LsatName = "Kohen" };
            Class[1] = new Student() { Borndate = new DateTime(2020, 10, 8), FirstName = "Galia", LsatName = "Amar" };
            Console.WriteLine(Class[0].Age().Days);
            Class[1].Age();
        }

        public Group()
        {
            a(); 

        }
        public Group(Group group) : this()
        {
            group = new Group();
            group.Class =new Student[30];
            for (int i = 0; i < Class.Length; i++)
            {
                group.Class[i] = new Student(Class[i]);
            }
        }
    }
}
