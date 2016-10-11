using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Delegates
{
    public delegate int DelegateToMethod(int x, int y);
    public class Math
    {
        public static int Add(int First, int Second)
        {
            return First + Second;
        }
        public static int Multiply(int First, int Second)
        {
            return First * Second;
        }
        public static int Divide(int First, int Second)
        {
            return First / Second;
        }
    }

    class Program
    {
        //static void Main(string[] args)
        //{
        //    DelegateToMethod aDelegate = new DelegateToMethod(Math.Add);
        //    DelegateToMethod mDelegate = new DelegateToMethod(Math.Multiply);
        //    DelegateToMethod dDelegate = new DelegateToMethod(Math.Divide);

        //    Console.WriteLine(aDelegate(2, 3));

        //    Console.ReadLine();
        //}
    }
}
