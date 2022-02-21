using System;

namespace MulticastDeligates
{
    class Program
    {
        public delegate void RectDelegate(double Width, double Height);

        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle();
            var obj = new RectDelegate(r1.GetArea);

            obj.Invoke(5.35, 5.66);
            Console.ReadKey();
        }
    }
}
