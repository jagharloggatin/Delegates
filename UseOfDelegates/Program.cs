﻿using System;

namespace UseOfDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new MyClass();
            obj.LongRunning(CallBack);

        }

        static void CallBack(int i)
        {
            Console.WriteLine(i);
        }

        public class MyClass
        {
            public delegate void CallBack(int i);

            public void LongRunning(CallBack obj)
            {
                for (int i = 0; i < 10000; i++)
                {
                    obj(i);
                }
            }
        }
    }
}
