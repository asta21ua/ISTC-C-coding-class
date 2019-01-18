using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Async_meth_07
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Primary Flow: ID {0}", Thread.CurrentThread.ManagedThreadId);

            var myDeleagete = new Action(Method);

            // the deleaget method whitch will be launched after the asynchronous operation would end
            var callback = new AsyncCallback(HandleCompletion);

            myDeleagete.BeginInvoke(callback, "Hello world");

            Console.WriteLine("The Primary Flow is continuing to work");

            //delay

            Console.ReadKey();

        }

        static void Method()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n Asynchronous method was lanched");
            Console.WriteLine("\n Secondary Flow ID {0}", Thread.CurrentThread.ManagedThreadId);

            for (int i = 0; i < 80; i++)
            {
                Thread.Sleep(50);
                Console.Write(".");
            }
            Console.WriteLine("Asynchronous operation was ended.\n ");
            Console.ForegroundColor = ConsoleColor.Cyan;
        }
        static void HandleCompletion(IAsyncResult asyncResult)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Callback method Thread ID {0}", Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("Infomation about Asynchronous operation - " + asyncResult.AsyncState);
            Console.ForegroundColor = ConsoleColor.Red;
        }
    }
}
