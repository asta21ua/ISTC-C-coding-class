using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_2_3
//using get & set
{

    class MyClass
    {

        private string field = null;

        public string Field
        {
            set
            {
                field = value;
            }

            get
            {
                return field;
            }

        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass instance = new MyClass();

            instance.Field = "Hello world!";

            Console.WriteLine(instance.Field);

            Console.ReadKey();
        }
    }
}
