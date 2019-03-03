using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*******Hello World!!!*******");
            //Console.ReadKey();         

            Console.WriteLine("Please enter your name:  "); //Type your name
            
            string name = Console.ReadLine();

            Console.WriteLine($"Hello {name}");   // say hello

            Calculator.Add(12,85);

            Console.ReadKey(); 

        }

    }
        class Calculator             // creating class calculator
        {

          public static void Add(int x, int y) // object of class
          {

            int z= x + y;
            Console.WriteLine($"Sum {x} + {y} = {z}"); 
            
          }


        }
}



        