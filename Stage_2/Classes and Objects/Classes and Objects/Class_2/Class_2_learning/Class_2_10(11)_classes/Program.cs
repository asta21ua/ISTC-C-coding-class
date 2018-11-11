using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_2_10_11__classes //creating of weak links
{
    class MyClass
    {
        public void Method()
        {
            Console.WriteLine("Hello world!");

        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            MyClass my = new MyClass(); // strong link
            new MyClass().Method(); // weak link

            Console.ReadKey();
        }
    }
}
