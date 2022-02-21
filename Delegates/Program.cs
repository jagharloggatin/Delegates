using System;

namespace Delegates
{
    public delegate void AddDelegate(int x, int y);
    public delegate string SayDelegate(string str);

    class Program
    {
        static void Main(string[] args)
        {
            var op1 = new Operators();

            AddDelegate ad = new AddDelegate(op1.AddMethod);
            ad(50, 100);
            ad.Invoke(50, 100);

            SayDelegate sd = new SayDelegate(SayHello);
            string str = sd("Jonathan");
            Console.WriteLine(str);
        }
        public static string SayHello(string name)
        {
            return "Hello " + name;
        }
    }
}
