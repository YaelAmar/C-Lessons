using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkLesson1
{
    class Pencilcase
    {
        public Glue Glue { get; set; } = new Glue();
       public  Pen Pen { get; set; } = new Pen();
       public  Pencil Pencil { get; set; } = new Pencil();

        public DateTime Date { get; set; } = new DateTime();
        
    }
}
