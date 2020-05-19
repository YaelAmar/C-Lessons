using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lesson11
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            int[] vec = new int[3] { 1, 2, 3 };
            string[] vec2 = new string[2] { "hello", "class" };
            double[] vec3 = new double[4] { 1.1, 2.2, 3.3, 4.4 };


            Print<int>(vec);
            Print<string>(vec2);
            Print<double>(vec3);

            Car car1 = new Car() { KPH = 120 ,ID=111};
            Car car2 = new Car() { KPH = 200 ,ID=222};

            Console.WriteLine(  GetLarge<Car>(car1, car2));
            
            Console.WriteLine(GetMax<int>(7,5));
            #endregion 

            

            Console.ReadLine();
        }
        #region
        static void PrintVec<T>(T[] vec)
        {
            foreach (T item in vec)
            {
                Console.WriteLine(item);
            }
        }
        static T GetMax<T>(T x1,T x2)
            where T:IComparable
        {
            if (x1.CompareTo(x2) > 0)
                return x1;
            return x2;
        }
        #endregion



        public void Print(int[] vec)
        {
            foreach (int item in vec)
            {
                Console.WriteLine(item);
            }
        }

        public void Print(string[] vec)
        {
            foreach (string item in vec)
            {
                Console.WriteLine(item);
            }
        }

        public static void Print<T>(T [] vec)
        {
            foreach (T item in vec)
            {
                Console.WriteLine(item);
            }
        }

        public static T GetLarge<T>(T o1,T o2)
            where T:IComparable
        {
            if (o1.CompareTo(o2)>0)
                return o1;
            return o2;
        }

    }
}
