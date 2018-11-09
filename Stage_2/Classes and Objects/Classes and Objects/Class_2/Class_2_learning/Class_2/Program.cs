using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_2
{

    class MyClass
    {
        //creating of class MyClass
        public string field;

        public void Method()

        {
            Console.WriteLine(field);
        }
    }
        
    class Program
    {
        static void Main(string[] args)
        {

            MyClass instance = new MyClass();

            instance.field = "Hello world!";

            instance.Method();

            Console.WriteLine(instance.field);

            Console.ReadKey();
        }
    }
}
