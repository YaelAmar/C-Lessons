using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11
{
    class Car:IComparable
    {
        public string Company { get; set; }
        public int ID { get; set; }
        public int KPH { get; set; }

        public int CompareTo(object obj)
        {
            if (KPH > (obj as Car).KPH)
                return 1;
            else if (KPH == (obj as Car).KPH)
                return 0;
            else
                return -1;
        }

        public override string ToString()
        {
            return string.Format(""+ID);
        }
    }
}
