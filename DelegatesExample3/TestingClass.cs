using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExample3
{
    public class TestingClass : Attribute
    {
        public delegate void TestDelegate();
        public delegate bool TestBoolDelegate(int i);

        public TestDelegate? testDelegateFunction;
        public TestBoolDelegate? testBoolDelegateFunction;
        public Action? testAction;
        public Action <int, float>? testIntFloatAction;
        public Func<bool>? testFunc;
        public Func<int, bool>? testIntBoolFunc;

        public void MyTestDelegateFunction()
        {
            Console.WriteLine("My first");
        }
        public void MySecondTestDelegateFunction()
        {
            Console.WriteLine("My second");
        }
        public bool MyTestBoolDelegateFunction(int i)
        {
            return i < 5;
        }
    }
}
