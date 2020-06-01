using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13___Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("yael amar");

            Hospital hospital = new Hospital();
            //4. שימוש בנציג
            //דרך מקוצרת - ברמיזה
            hospital.Check(hospital.MinEmployeeWarning);
            //דרך מקורית
            hospital.Check(new Empty(hospital.Good));


            //דרך ארוכה
            Empty e = new Empty(hospital.MinEmployeeWarning);
            e+= hospital.Good;
            //נציג ניתן לשרשור
            e += hospital.Good; e += hospital.Good; e += hospital.Good; e += hospital.Good;

            hospital.Check(e);



            Console.ReadLine();


        }
    }
}
