using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_2_8
{
     class MyClass
     { 
        public void Method()
        { 
            Console.WriteLine("The MyClass Method was called");

        }
      
     }
    
      class MyClass2 
      {

        public void CallMethod(MyClass my)
        {
            my.Method();

        }
        
      }
              
     
        
      class Program
      {
         static void Main(string[] args)
         {
            MyClass my = new MyClass();
            MyClass2 my2 = new MyClass2();

            my2.CallMethod(my);



            Console.ReadKey();
         }
      }
}






