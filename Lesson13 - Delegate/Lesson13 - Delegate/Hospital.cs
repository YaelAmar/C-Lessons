using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13___Delegate
{//1.
    delegate void Count(int a);
    class Hospital
    {

        
        public string Name ;
        public List<Doctor> Doctors = new List<Doctor>();
        public List<Professor> Professors = new List<Professor>();

        public event Empty OnDelete;
        public event Empty OnAdd;

        public Hospital()
        {
            Doctors.Add(new Doctor());
            Doctors.Add(new Doctor());
            Doctors.Add(new Doctor());
            Doctors.Add(new Doctor());
           

            Professors.Add(new Professor());
            for (int i = 0; i < Professors.Count; i++)
            {
                Professors[i].CountDoctorsInHospital(Doctors.Count);
            }
           
        }
        public void Check(/*2. יצירת מופע מסוג נציג*/Empty empty)
        {
            Empty empty1;
            if (Doctors.Count <= 5)
                //3. הפעלת הנציג
                empty();
          
        }
        public void MinEmployeeWarning()
        {
            Console.WriteLine("ATTENTION!  Doctor's number is low!!!");
        }

        public void Good()
        {
            Console.WriteLine("Well Done!! you have enugh doctors!!!");
        }

        public void DoctorOut(Doctor doctor)
        {

          int a=  Doctors.IndexOf(doctor);
            Doctors.RemoveAt(a);
            if (OnDelete != null)
                OnDelete();
        }
      
        public void DoctorIn(Doctor doctor)
        {
            Doctors.Add(doctor);
            if (Doctors.Count > 10&&OnAdd!=null)
                OnAdd();
        }

    }
}
