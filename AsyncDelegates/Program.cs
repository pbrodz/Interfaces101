using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace AsyncDelegates
{

    public class AsyncDemo
    {
        public string TestMethod(int CallDuration, out int threadID)
        {
            Console.WriteLine("Test method begin");
            Thread.Sleep(CallDuration);
            threadID = Thread.CurrentThread.ManagedThreadId;
            return "MyCallTime was " + CallDuration.ToString();
        }
    }

    public delegate string AsyncDelegate(int CallDuration, out int threadID);

    public class AsyncMain
    {
        // Asynchronous method puts the thread id here.
        private static int threadId;

        static void Main(string[] args)
        {
            // Create an instance of the test class.
            AsyncDemo ad = new AsyncDemo();

            // Create the delegate.
            AsyncDelegate dlgt = new AsyncDelegate(ad.TestMethod);

            // Initiate the asychronous call.  Include an AsyncCallback
            // delegate representing the callback method, and the data
            // needed to call EndInvoke.
            IAsyncResult ar = dlgt.BeginInvoke(3000,
                out threadId,
                new AsyncCallback(CallbackMethod),
                dlgt);

            Console.WriteLine("Press Enter to close application.");
            Console.ReadLine();
        }

        // Callback method must have the same signature as the
        // AsyncCallback delegate.
        static void CallbackMethod(IAsyncResult ar)
        {
            // Retrieve the delegate.
            AsyncDelegate dlgt = (AsyncDelegate)ar.AsyncState;

            // Call EndInvoke to retrieve the results.
            string ret = dlgt.EndInvoke(out threadId, ar);

            Console.WriteLine("The call executed on thread {0}, with return value \"{1}\".", threadId, ret);
        }
    }
}