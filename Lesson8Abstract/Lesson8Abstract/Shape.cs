using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8Abstract
{
   abstract class Shape
   {
        public int SideNum { get; set; }
        public int[] Sides { get; set; }
        public Shape()
        {
            SideNum = 3;
            Sides = new int[3];

        }

        public Shape(int sideNum)
        {
            SideNum = sideNum;
            Sides = new int[3];
        }

        abstract public void Print();

        public int Perimiter()
        {
            int sum = 0;
            for (int i = 0; i < Sides.Length; i++)
            {
                sum += Sides[i];
            }
            return sum;
        }

         abstract  public double Area();        
     
   }
}
