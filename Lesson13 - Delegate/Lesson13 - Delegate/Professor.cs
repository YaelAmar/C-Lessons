using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13___Delegate
{
    class Professor:Doctor
    {
        //2.
        public Count CountDoctorsInHospital;
        public Professor()
        {
            //3.
            CountDoctorsInHospital =PrintNumOfDoctors;
        }
        public void PrintNumOfDoctors(int a)
        {
           
            Console.WriteLine(a);
        }


        public TimeSpan TimeOfWork { get; set; }
        public int NumOfStudent { get; set; }

        public int Teach()
        {
            return NumOfStudent;
        }
        


    }
}
