using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
   static class OurMath
    {
        public static double PI { get; set; } = 3.14;

        public static long Pow(int num1,int num2)
        {
            long sum = 1;
            for (int i = 0; i < num2; i++)
            {
                sum = sum * num1;
            }

            return sum;
        }

        public static int Convert( int num)
        {
            int dec=0;
            for (int i = 1;num>0; i=i+i)
            {
                dec += num % 10 * i;
                num = num/10;
            }
            return dec;
        }
    }
}
