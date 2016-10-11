using System;
using System.Threading;

class Program
{
    public delegate int TheDelegate(int x, int y);
    static int ShowSum(int x, int y)
    {
        int sum = x + y;
        Console.WriteLine("Thread #{0}: ShowSum() Sum={1}", Thread.CurrentThread.ManagedThreadId, sum); 
        return sum;
    }
    static void Main(string[] args)
    {
        TheDelegate d = ShowSum;
        IAsyncResult ar = d.BeginInvoke(10, 10, null, null);
        int sum = d.EndInvoke(ar);
        Console.WriteLine("Thread #{0}: ShowSum() Sum={1}", Thread.CurrentThread.ManagedThreadId, sum);

        Console.ReadLine();
    }
}
