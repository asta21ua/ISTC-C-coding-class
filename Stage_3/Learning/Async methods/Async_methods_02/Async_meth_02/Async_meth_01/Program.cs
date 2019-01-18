using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Async_meth_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Primary flow: ID {0}", Thread.CurrentThread.ManagedThreadId);

            var myDelegate = new Action(Method);

            myDelegate.BeginInvoke(null, null);

            Console.WriteLine("Main");
            for (int i = 0; i < 80; i++)
            {
                Thread.Sleep(50);
                Console.WriteLine(".");
            }
            Console.ReadKey();
        }

        static void Method()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nAsync method was lode.");
            Console.WriteLine("\n Secondary flow: ID {0}", Thread.CurrentThread.ManagedThreadId);

            for (int i = 0; i < 80; i++)
            {
                Thread.Sleep(60);
                Console.WriteLine("A");

            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Async operation was done.\n");

        }
    }
}
