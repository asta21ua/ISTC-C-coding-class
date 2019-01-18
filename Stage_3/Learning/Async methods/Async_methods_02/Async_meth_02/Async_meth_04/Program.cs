using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Async_meth_04
{
    class Program
    {
        static void Main()
        {
            var myDelegate = new Func<int, int, int>(Add);

            //launching of the asynchronous program

            IAsyncResult asyncResult = myDelegate.BeginInvoke(1, 2, null, null);

            Console.WriteLine("Asynchronous program was launched. The Main method is continuing to work");
            Console.WriteLine("The Main method is wating for the end of the Asynchronous program launch");

            Console.Writeline(asyncResult.AsyncWaitHandle.GetType());

            asyncResult.AsyncWaitHandle.WaitOne();
            Console.WriteLine("The end of Asynchronous method");

            //getting the reslt of the Asynchronous oparetion
            int result = myDelegate.EndInvoke(asyncResult);


            //closing the waithHandle

            asyncResult.AsyncWaitHandle.Close();
            Console.WriteLine("Result =  "+ result);

            //delay
            Console.ReadKey();
        }

        static int Add(int a, int b)
        {
            Thread.Sleep(3000);
            return a + b;
            
        }
    }
}
