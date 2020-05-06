using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] s = new Shape[2];
            Shape shape = new Triangle();
            Triangle triangle = new Triangle();
            triangle.Height = ((Triangle)shape).Height;

            s[0] = new Triangle() { Height=3};
            s[1] = new Squre();

            for (int i = 0; i < s.Length; i++)
            {
              s[i].Print();
            }
            //לולאה שעוברת על מערך של אוביקטים
            foreach (Shape item in s)
            {
                item.Print();
            }
            Console.ReadLine();

        }
        public void Print(Shape shape)
        {
            if (shape is Triangle)
            {
                Console.WriteLine("triangle");
                //הדפסה של שם המחלקה
                Console.WriteLine(shape.GetType().Name);
            }
        }
    }
}
