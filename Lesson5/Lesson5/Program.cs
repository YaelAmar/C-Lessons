
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello world");
            #region CopyCtor
            ///*  Bus bus = new Bus();
            //  bus.GetDetails();
            //  bus.Print();*/

            //Bus[] Rentbus = new Bus[3];
            //for (int i = 0; i < Rentbus.Length; i++)
            //{
            //    Rentbus[i] = new Bus();
            //    Rentbus[i].GetDetails();
            //}
            ///*
            //            Rentbus[2].Print();


            //            Bus customer = Rentbus[2];
            //            customer.Company = "aaaa";

            //            Rentbus[2].Print();
            //            */
            //Console.WriteLine("*****************");
            //Rentbus[2].Print();
            //Bus customer2 = new Bus(Rentbus[2]);

            //Console.WriteLine("*****************");
            //customer2.Company = "aaaaaa";

            //Rentbus[2].Print();

            #endregion

            Ambulance ambulance = new Ambulance();
            ambulance.GetDetails();
            ambulance.Print();

            Bus bus = new Bus();
            bus.GetDetails();
            bus.Print();


            

                      Console.ReadLine();

        }
    }
    
}
