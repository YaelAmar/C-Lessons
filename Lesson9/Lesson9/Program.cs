using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat() { Name="Mitzi"};
            Cat cat2 = new Cat();

            Console.WriteLine(cat.Equals(cat2));
            Console.WriteLine(cat.ToString());
            Console.WriteLine(cat.Age());

            Dog dog = new Dog();
            Dog dog2 = new Dog() {Color=ConsoleColor.Red,DogType="Pincher" };
            Console.WriteLine(dog.Equals(dog2));
            Console.WriteLine(dog2.ToString());
            Console.WriteLine(dog.Description());

            Print(dog);
            Console.ReadLine();
        }

       static public void Print(object obj)
        {
            if (obj is Cat)
                (obj as Cat).MakeSound();
            else
                (obj as Dog).MakeSound();
           
        }

    }
}
