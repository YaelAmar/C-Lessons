using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Point []vec = new Point[10];
            Console.WriteLine("please enter a number");
            try {
                vec[0] = new Point();
                vec[0].X = int.Parse(Console.ReadLine());
                vec[0].Invalid();
            }
           
            catch(NullReferenceException e)
            {
                Console.WriteLine("erorr! you forgot the \"new\" word");
            }
            catch (FormatException e)
            {
               // throw e;
               Console.WriteLine("error!"+e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("goodbye");
            }

            Console.ReadLine();
        }
    }
}
