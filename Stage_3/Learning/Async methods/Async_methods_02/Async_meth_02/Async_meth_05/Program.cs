using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Async_meth_05
{
    class Program
    {
        static void Main()
        {
            var myDelegate = new Func<int, int, int>(Add);

            //Launch of the asynchronous operation
            IAsyncResult asyncResult = myDelegate.BeginInvoke(1, 2, null, null);
            Console.WriteLine("Asynchronous program was launched.The Main method is continuing to work");

            //
            while (!asyncResult.IsCompleted)
            {
                Thread.Sleep(100);
                Console.Write(".");

            }

            //getting the result of the  asynchronous operation

            int result = myDelegate.EndInvoke(asyncResult);

            Console.WriteLine("\nResult = " + result);

            //delay

            Console.ReadKey();
        }
        // method for working in other streams

        static int Add(int s, int d)
        {
            Thread.Sleep(3000);
            return s + d;

        }
      



}
}
