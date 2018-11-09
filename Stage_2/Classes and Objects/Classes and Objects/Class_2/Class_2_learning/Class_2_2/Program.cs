using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_2_2
//using metodes of entrance
{
    class MyClass
    {
        private string field = null;

        public void SetFiled(string value)
        {
            field = value;
        }

        public string GetField()
        {
            return field;
        }


        class Program
        {
            static void Main(string[] args)
            {
                MyClass instance = new MyClass();

                instance.SetFiled("Hello world!");

                string @string = instance.GetField();

                Console.WriteLine(@string);

                Console.ReadKey();

            }

        }

    }
}
