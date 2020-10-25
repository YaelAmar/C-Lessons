using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw
{
    class Milk
    {
       

        public static int Counter { get; set; }
        public int MyProperty { get; set; }
        public int MyProperty2 { get; set; }
        public int MyProperty3 { get; set; }

        public Milk(int myProperty, int myProperty2, int myProperty3)
        {
            MyProperty = myProperty;
            MyProperty2 = myProperty2;
            MyProperty3 = myProperty3;
        }
        public Milk()
        {

        }
        public Milk(Milk s)
        {
            MyProperty = s.MyProperty;
            MyProperty2 =s. MyProperty2;
            MyProperty3 =s.MyProperty3;
        }

        public void Print()
        {
            Console.WriteLine(Counter+MyProperty);
        }
    }
}
