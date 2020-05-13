using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList a= new ArrayList();
            a.Add(9);
            Console.WriteLine(a.Capacity);
            a.Add(15);
            Console.WriteLine(a.Capacity);
            a.Add("לעי");
            Console.WriteLine(a.Capacity);
            a.Add("hello");
            Console.WriteLine(a.Capacity);
            a.Add(new Person());
            Console.WriteLine(a.Capacity);
            a.Add(9);
            // a.Clear();

            object o = a.Clone();
            Console.WriteLine(o);

            Console.WriteLine(a.Count);

            ArrayList arrayList = new ArrayList();
            arrayList = a.GetRange(2, 2);
            Console.WriteLine("********************");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine(   a.IndexOf(9));


            Console.WriteLine(a.LastIndexOf(9));

            Console.WriteLine(a[0] + "++++++++++++++");


          object[] ss=  a.ToArray();
            Console.WriteLine(ss[2]);

            Console.WriteLine("----------------");
            Print(a);
            a.Sort();
            Print(a);



            Console.WriteLine(a.Count);
            a.Remove("hello");
            Console.WriteLine(a.Count);

            a.RemoveAt(2);

            a.RemoveRange(1, 3);
            Console.WriteLine(a.Count);

            a.Reverse();
           


            Console.ReadLine();
            
        }

       static public void Print(ArrayList a)
        {
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }
        }
    }
}
