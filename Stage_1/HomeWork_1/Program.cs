using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int w = 24;
            int z = 6;

            int a = w + z;
            int d = w - z;
            int g = w * z;
            int h = w / z;

            Console.WriteLine($"w + z = {a}");
            Console.WriteLine($"w - z = {d}");
            Console.WriteLine($"w * z = {g}");
            Console.WriteLine($"w / z = {h}");

            Console.ReadKey();



        }
    }
}
