using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_2_7
{
    class Point
    {
        private int x, y;
        private string name;

        public int X

        {
            get { return x; }

        }

        public int Y
        {
            get { return y; }
        }

        public string Name
        {
            get { return name; }
        }

        public Point(int x, int y)// Consturctor with two parameters
        {
            this.x = x;
            this.y = y;

            Console.WriteLine("Constructor with two parameters");
        }

        public Point(string name)
            : this(200, 300)
        {
            this.name = name;

            Console.WriteLine("Constructor with one parameter");
        }

    }
}
