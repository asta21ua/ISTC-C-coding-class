using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Async_meth_06
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Primary Flow: ID {0}", Thread.CurrentThread.ManagedThreadId);

            var myDeleagete = new Action(Method);

            // the deleaget method whitch will be launched after the asynchronous operation would end
            var callback = new AsyncCallback(HandleCompletion);

            myDeleagete.BeginInvoke(callback, null);

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
                Thread.Sleep(30);
                Console.Write(".");
            }


        }

        static void HandleCompletion(IAsyncResult asyncResult)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Callback method Thread ID {0}", Thread.CurrentThread.ManagedThreadId);
            Console.ForegroundColor = ConsoleColor.Red;
            
        }
    }
}
