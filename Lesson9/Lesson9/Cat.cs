using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9
{
    class Cat:Animal,IAnimalBehavior
    {
        public ConsoleColor Color { get; set; }
        public string Name { get; set; }

        public override bool Equals(object obj)
        {
            Cat cat = new Cat();
            cat = (Cat)obj;
            if (this.Color == cat.Color && this.Name == cat.Name)
                return true;
            return false;

        }

        public override string ToString()
        {
            return Name;
        }

        public void MakeSound()
        {
            Console.WriteLine("Miaooo");
            Console.Beep(37, 1000);
        }

        public int Age()
        {
            return 14;
        }

        public string Description()
        {
            return "nice animal";
        }
    }
}
