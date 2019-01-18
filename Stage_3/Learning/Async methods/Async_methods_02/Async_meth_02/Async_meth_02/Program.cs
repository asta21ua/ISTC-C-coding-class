using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Async_meth_02
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Primary flow: ID {0}", Thread.CurrentThread.ManagedThreadId);

            var myDelegate = new Action(Method);

            IAsyncResult asyncResult = myDelegate.BeginInvoke(null, null);

            Console.WriteLine("Primary flow is continuing working");

            // wating for asynchronous operetion ends 
            myDelegate.EndInvoke(asyncResult);

            Console.WriteLine("The end of Primary flow work");

            //delay

            Console.ReadKey();

        }

        static void Method()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\nAsync method was lode.");
            Console.WriteLine("\n Secondary flow: ID {0}", Thread.CurrentThread.ManagedThreadId);

            for (int i = 0; i < 80; i++)
            {
                Thread.Sleep(50);
                Console.Write(".");


            }


        }
    }
}
