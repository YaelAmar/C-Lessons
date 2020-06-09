
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15
{
    class Family
    {
        public string LastName { get; set; }
        public Parent Father { get; set; }
        public Parent Mother { get; set; }

        public string GetFamilyName()
        {
            return LastName;
        }

        public Family()
        {
            Father = new Parent() { Name = "avi" };
            Mother = new Parent() { Name = "michal" };
            Father.FamilyFunc = new FamilyName(GetFamilyName);
            Mother.FamilyFunc = GetFamilyName;
        }
    }
}
