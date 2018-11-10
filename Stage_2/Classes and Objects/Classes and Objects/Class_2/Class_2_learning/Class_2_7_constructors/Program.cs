using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_2_7
{
    class Program
    {
        static void Main(string[] args)
        {

            Point point = new Point("A");
            Console.WriteLine("{0}.X = {1}, {0}.Y = {2}", point.Name, point.X, point.Y);



            Console.ReadKey();
        }
    }
}
