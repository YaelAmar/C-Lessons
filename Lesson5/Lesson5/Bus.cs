using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    //enum FuelType
    //{
    //    benzin=1,
    //    neft
    //}
    class Bus:Vehicle
    {
       
        public int NumOfRavKav { get; set; }
        public int NumOfBell { get; set; }
        public bool Screen { get; set; }

        public Bus():base()
        {

        }

        public Bus(int numOfSeats, string fuelType, string company, int id, int numOfRavKav, int numOfBell, bool screen):base( numOfSeats,  fuelType,  company,  id)
        {
           
            NumOfRavKav = numOfRavKav;
            NumOfBell = numOfBell;
            Screen = screen;
        }

        public Bus(Bus b):base(b.NumOfSeats, b.FeulType, b.Company, b.Id)
        {
            NumOfRavKav = b.NumOfRavKav;
            NumOfBell = b.NumOfBell;
            Screen = b.Screen;
        }

        public  void Print()
        {
           base.Print();
            Console.WriteLine(" Id: "+ Id);
            Console.WriteLine(" NumOfRavKav: "+ NumOfRavKav);
            Console.WriteLine(" NumOfBell: "+NumOfBell);
            Console.WriteLine(" Screen: "+ Screen);

        }

        public void GetDetails()
        {
            base.GetDetails();
            Console.WriteLine("Enter NumOfRavKav");
            NumOfRavKav = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter NumOfBell");
            NumOfBell = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Screen");
            Screen = bool.Parse(Console.ReadLine());


        }
    }
}
