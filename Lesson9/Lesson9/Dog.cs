using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9
{
    class Dog:Animal,IAnimalBehavior
    {
        public ConsoleColor Color { get; set; }
        public string DogType { get; set; }

        public override bool Equals(object obj)
        {
            Dog dog = new Dog();
            dog = (Dog)obj;
            if (Color == dog.Color && DogType == dog.DogType)
                return true;
            return false;
        }

        public override string ToString()
        {
            return string.Format("this is {0} dog and his color is {1}",DogType,Color);
        }

        public void MakeSound()
        {
            Console.WriteLine("Haoooo");
            Console.Beep(50, 3500);
        }

        public int Age()
        {
            return 20;
        }

        public string Description()
        {
            return "nice dog";
        }
    }
}
