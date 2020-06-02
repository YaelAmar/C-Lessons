using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13___Delegate
{
    class Program
    {
        public static void DeleteMassage()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("one doctor exit");

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void BreakMassage()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("one doctor can take a break, there are enough doctors");

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }
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




            //lesson 14
            //קישור הארוע לפונקציה
            hospital.OnDelete += new Empty(DeleteMassage);
            hospital.DoctorOut(hospital.Doctors[0]);


            hospital.OnAdd += new Empty(BreakMassage);
            hospital.DoctorIn(new Doctor());
            hospital.DoctorIn(new Doctor());
            hospital.DoctorIn(new Doctor());
            hospital.DoctorIn(new Doctor());
            hospital.DoctorIn(new Doctor());
            hospital.DoctorIn(new Doctor());
            hospital.DoctorIn(new Doctor());
            hospital.DoctorIn(new Doctor());
            hospital.DoctorIn(new Doctor());
            hospital.DoctorIn(new Doctor());
            hospital.DoctorIn(new Doctor());
            hospital.DoctorIn(new Doctor());
            hospital.DoctorIn(new Doctor());
            hospital.DoctorIn(new Doctor());
            hospital.DoctorIn(new Doctor());

            Console.ReadLine();


        }
    }
}


/*
 * delegate - נציג
 * נציג הכוונה מצביע לפונקציה
 * זהו אוביקט שמחזיק בתוכו פונקציה
 * למה צריכים אותו?
 * . כדי לתקשר בין מחלקות שאין בינהם קשר ישיר
 * 
 * 
 * יצירת נציג - 
 * 1. הגדרת הנציג:  delegate void Count(int a);
 * 2. יצירת מופע מסוג הנציג במחלקה שבה נרצה להפעיל אותו - במחלקה שבה נרצה לגרום לו לפעול - Empty empty
 * 3. הפעלת הנציג בפועל ע"י שם המופע וסוגריים - empty();
 * 4. הצבת הפונקציה שנרצה להפעיל ע"י הנציג - במחלקה האחרת. במחלקה זו נרצה שבפועל תתרחש הפונקציה עליה מצביע הנציג.  - hospital.Check(hospital.MinEmployeeWarning);
 *
 *
 * ארבע דרכים להצבת הפונקציה בנציג:
 * א. יצירת משתנה מסוג הנציג, אליו מוכנסת הפונקציה הרצויה ולאחר מכן הפעלת הנציג 
 *          Empty e = new Empty(hospital.MinEmployeeWarning);
            e= hospital.Good;
   ב. קריאה לפונקציה הרצויה ובתוכה הגדרת הנציג
            hospital.Check(new Empty(hospital.Good));
   ג. קריאה מקוצרת - קריאה ישירות לפונקציה שמתאימה לנציג
             hospital.Check(hospital.MinEmployeeWarning);       
    ד. שרשור כמה פונקציות
             e= hospital.Good;



    event- ארוע
    נציג שמור ומוגן יותר שמטרתו לייצג ארועים שקורים בזמן ריצת התכנית והתייחסות אליהם.
    שונה מנציג ב:
    ניתן להגדיר event רק כחבר מחלקה (member) ולא ניתן בתוך פונקציה או כפרמטר לפונקציה
    ניתן להפעיל    event רק באותה מחלקה בה הוא נכתב
        ניתן להוסיף ולהוריד פונקציות מ  - event באמצעות =+, =-  (כמו multicast delegate), אך לא ניתן לדרוס את מה שיש שם באמצעות =
 */
