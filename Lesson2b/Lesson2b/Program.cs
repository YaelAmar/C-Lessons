using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2b
{
    class Program
    {
        static void Main(string[] args)
        {

            Group group = new Group();
            Group group2 = new Group(group);
            group2 = group;
            Console.WriteLine( group2.Class[0].Age());
            Random rand = new Random();

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(rand.Next(100));
                Console.Beep();
            }



            #region console options
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = new UTF8Encoding();
            Console.WriteLine("\u05D0\u05D3");
            Console.WriteLine("אריאל");
            Console.WriteLine(new string("שיעור מוצלח".Reverse().ToArray()));
            Console.Beep();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            #endregion


            #region implicit and explicit cast
            int x =3;
            double y= 5.8;
            // - מדבל לאינט - חובה בצורה מפורשת!! המרה כלפי מעלה
            //המרה כלפי מעלה - מטיפוס מפורט לטיפוס מפורט פחות - קיים חשש לאיבוד מידע

            x = (int)y;

            //המרה כלפי מטה - מאינט לדבל - לא חובה בצורה מפורשת
            //המרה כלפי מטה  - מטיפוס מפורט פחות לטיפוס מפורט יותר - לא קיים חשש לאיבוד מידע

            y = (double)x;

            #endregion


            #region parse& tryparse

            string s = Console.ReadLine();
            //int num = int.Parse(s);
            //Console.WriteLine(num);

            bool res;
            int numafterParse;
            res = int.TryParse(s, out numafterParse);
            while(!res)
                {
                Console.WriteLine("error! you type wrong input");
                res = int.TryParse(Console.ReadLine(), out numafterParse);
            }
            Console.WriteLine(numafterParse);
            
               
            #endregion

            Console.WriteLine("עברית");
            Console.ReadLine();

           
        }
    }
}
