using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkLesson1
{
    class Glue
    {
        /* JAVA
        private string company;

       public void SetCompany(string company)
        {
            if(company!="")
                this.company = company;
        }

       public string GetCompany()
        {
            return this.company;
        }
        */

        private int size;

        public int Size
        {
            get { return size; }
            set {
                if (value > 0)
                    size = value;
                else
                    size = 1;
            }
        }

        
        public string Color { get; set; }

        public Glue():this(5, "fhd")
        {
          
        }
        public Glue(int size, string color)
        {
            Size = size;
            Color = color;
        }

        

        public void Stick()
        {
            Console.WriteLine("the glue is sticking");
        }

        public void Stick2()
        {
            Console.WriteLine("the glue is sticking 2");
        }

        public void Stick3()
        {
            Console.WriteLine("the glue is sticking 3");
        }
    }
}
