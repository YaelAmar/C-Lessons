using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12
{
    class Dog
    {
        public int ID { get; set; }
        public int Age { get; set; }

        public override bool Equals(object obj)
        {
            if (ID == (obj as Dog).ID)
                return true;
            return false;
        }

        public override int GetHashCode()
        {
            return ID;
        }

        public static bool operator >(Dog d1, Dog d2)
        {
            if (d1.Age > d2.Age)
                return true;
            return false;
        }

        public static bool operator <(Dog d1, Dog d2)
        {
            if (d1.Age > d2.Age)
                return false;
            return true;
        }

        public static Dog operator ++(Dog dog)
        {
            dog.Age++;
            return dog;
        }


    }
}
