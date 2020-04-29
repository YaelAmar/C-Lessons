using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    class Vehicle
    {
        public int NumOfSeats { get; set; }
        public string FeulType { get; set; }
        public string Company { get; set; }
        public int Id { get; set; }

        public Vehicle()
        {

        }

        public Vehicle(int numOfSeats, string feulType, string company, int id)
        {
            NumOfSeats = numOfSeats;
            FeulType = feulType;
            Company = company;
            Id = id;
        }

        public  void Print()
        { 
            Console.WriteLine(" NumOfSeats: " + NumOfSeats);
            Console.WriteLine(" FuelType: " + FeulType);
            Console.WriteLine(" Company: " + Company);
            Console.WriteLine(" Id: " + Id);
        }

        public void GetDetails()
        {
            Console.WriteLine("Enter NumOfSeats");
            NumOfSeats = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter FuelType");
            FeulType = Console.ReadLine();
            Console.WriteLine("Enter Company");
            Company = Console.ReadLine();
            Console.WriteLine("Enter Id");
            Id = int.Parse(Console.ReadLine());
        }
    }
}
