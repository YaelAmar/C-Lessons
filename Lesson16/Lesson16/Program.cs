using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16
{
    class Program
    {
        static void Main(string[] args)
        {
            #region x
            //List<Point> points = new List<Point>();
            //Random random = new Random();
            //for (int i = 0; i < 100; i++)
            //{
            //    points.Add(new Point() { X = random.Next(1000), Y = random.Next(500) });
            //    Console.WriteLine(points[i].X+ " "+points[i].Y);
            //}
            //Console.WriteLine("****************************");
            //var a = points.Select(p => p.X);
            //foreach (var item in a)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            // LINQ - Language Integrated Query - שאילתא משולבת בשפה


            //טיפוס אנונימי
            var x=5;
            var y = new Point();

            List<Point> L = new List<Point>();
            Random rnd = new Random();
            for (int i = 0; i < 20; i++)
            {
                L.Add(new Point() { X = rnd.Next(1000), Y = rnd.Next(1000) });
            }

            var L2 = from p in L
                     where p.X > 100 && p.Y > 100
                     select p;

            //lambda expression
            var l3 = L.Where(p=>p.X < 300 && p.Y < 300).ToList();
            var l4 = L.Where(p =>
            {
                if (p.X > 150)
                    Console.WriteLine("larger than 150");
                if (p.X < 100)
                    return true;
                return false;
            }
            ).ToList();


           

            foreach (var item in l3)
            {
                Console.WriteLine(item.X + " , " + item.Y);
            }

            Console.WriteLine("******************");
            Print(L);

            Console.WriteLine("large than 100");

            foreach (var item in L2)
            {
                Console.WriteLine(item.X + " , " + item.Y);
            }
            Console.ReadLine();
        }

        public static void Print(List<Point> l)
        {
            foreach (var item in l)
            {
                Console.WriteLine(item.X + " , " + item.Y);
            }
        }

        public static bool GetPoint(Point p)
        {
            if (p.X < 300 && p.Y < 300)
                return true;
            return false;
        }

     
    }
}
//http://www.corner.co.il/Articles/ArticleDetials/49/Linq-To-Object--%D7%97%D7%9C%D7%A7-%D7%A8%D7%90%D7%A9%D7%95%D7%9F
//https://webmaster.org.il/articles/aspnet-linq-syntax/