using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_2_6
{
    class Point
    {
        private int x, y;

        public int X
        {
            get { return x; }

        }

        public int Y
        {
            get { return y; }

        }

        public Point() // by default
        {
            Console.WriteLine("Constructor by default");
        }


        public Point(int x, int y) // constructor see by user
        {
            Console.WriteLine("Users consructor");

            this.x = x;
            this.y = y;
            
        }


    }

}





