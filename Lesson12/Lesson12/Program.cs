using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog1 = new Dog() { ID = 1, Age = 15 };
            Dog dog2 = new Dog() { ID=2,Age=10};


            Console.WriteLine(dog1>dog2);
            Console.WriteLine(dog1++);
            Console.WriteLine(dog1.Age);

            Stack stack = new Stack();
            stack.Push(3);
            stack.Push(dog1);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

            Queue queue = new Queue();


            List<int> l1 = new List<int>();
            l1.Add(5);


            List<Dog> l2 = new List<Dog>();
            l2.Add(dog1);
            l2.Add(dog2);
            foreach (Dog item in l2)
            {
                Console.WriteLine(item.Age);
            }

            Console.ReadLine();
        }
    }
}
