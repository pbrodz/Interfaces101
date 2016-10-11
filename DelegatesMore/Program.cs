using System;
delegate string MyDelegate(int x);

class MyType
{
    public string MyFunc(int foo)
    {
        return "MyFunc called with the value " + foo + " for foo";
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyType mt = new MyType();
        MyDelegate del = new MyDelegate(mt.MyFunc);
        Console.WriteLine(del.Invoke(3));
        Console.WriteLine(del(3));
        Console.ReadLine();
    }
}
