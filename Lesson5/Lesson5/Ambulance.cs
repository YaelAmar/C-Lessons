using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    class Ambulance:Vehicle
    {
 
        public string RedLights { get; set; }
        public int NumOfCrew { get; set; }
        public int Code { get; set; }
        public string Area { get; set; }

        public Ambulance():base()
        {

        }

        public Ambulance(int numOfSeats, string feulType, string company, int id, string redLights, int numOfCrew, int code, string area):base( numOfSeats,  feulType,  company,  id )
        {
            
            RedLights = redLights;
            NumOfCrew = numOfCrew;
            Code = code;
            Area = area;
        }

        public  void Print()
        {
            base.Print();
            Console.WriteLine(" RedLights: " + RedLights);
            Console.WriteLine(" NumOfCrew: " + NumOfCrew);
            Console.WriteLine(" Code: " + Code);
            Console.WriteLine(" Area: " + Area);
            
        }

        public void GetDetails()
        {
            base.GetDetails();
            Console.WriteLine("Enter color");
            RedLights = Console.ReadLine();
            Console.WriteLine("Enter NumOfCrew");
            NumOfCrew = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Code");
            Code = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Area");
            Area = Console.ReadLine();

        }

       

    }
}
