using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkLesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pencilcase pencilcase = new Pencilcase();
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
            pencilcase.Glue.Color = "yellow";
            //pencilcase.glue.company = "sticky";
            pencilcase.Glue.Size = 12;
            pencilcase.Glue.Stick();
            pencilcase.Glue.Stick2();
            pencilcase.Glue.Stick3();


            pencilcase.Pen.Color = Color.blue|Color.red|Color.yellow;
            pencilcase.Pen.comany = "pilot";
            pencilcase.Pen.width = 0.4;
            pencilcase.Pen.Draw();
            pencilcase.Pen.Paint();
            pencilcase.Pen.Write();

            Console.WriteLine("enter to  pencilcase.Pencil.color");
            pencilcase.Pencil.color = Console.ReadLine();
            pencilcase.Pencil.company = "pp";
            Console.WriteLine("enter to  pencilcase.Pencil.hasEreaser");
            pencilcase.Pencil.hasEreaser = bool.Parse(Console.ReadLine());
            pencilcase.Pencil.Write();
            pencilcase.Pencil.Write2();
            pencilcase.Pencil.Erase();

         
            Console.ReadLine();
        }
    }
}
