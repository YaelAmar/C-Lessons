using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw
{
    class ShoppingList
    {
        public const string BSD = "בס\"ד";
        public string Name { get; set; }
        public DateTime DateOfList { get; set; }
        public Bread[] Breads { get; set; }
        public Milk[] Milks { get; set; }

        public ShoppingList(int b,int m)
        {
            Milks = new Milk[m];
            Breads = new Bread[b];
        }


    }
}
