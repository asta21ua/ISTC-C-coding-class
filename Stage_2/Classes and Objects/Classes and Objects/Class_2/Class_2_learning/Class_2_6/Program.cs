using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_2_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Using constructor by default
            var pointA = new Point();
            Console.WriteLine("pointA.X = {0} pointA.Y = {1}", pointA.X, pointA.Y);

            Console.WriteLine(new string('_', +30));

            //User's constuctor

            Point pointB = new Point(200, 100);

            Console.WriteLine("point.X = {0} point.Y = {1}", pointB.X, pointB.Y);

            Console.ReadKey();

        }
    }
}
