
// See https://aka.ms/new-console-template for more information
using DelegatesExample3;

Console.WriteLine("Hello, World!");

var test = new TestingClass();


//adds 3 methods to delegate
test.testDelegateFunction += test.MyTestDelegateFunction;
test.testDelegateFunction += test.MySecondTestDelegateFunction;
test.testDelegateFunction += test.MySecondTestDelegateFunction;

//print 3 delegate
test.testDelegateFunction();

Console.WriteLine();

//subtract 1 method from delegate
test.testDelegateFunction -= test.MySecondTestDelegateFunction;

//print 2 methods from delegate
test.testDelegateFunction();

//Add bool function
test.testBoolDelegateFunction = test.MyTestBoolDelegateFunction;
Console.WriteLine(test.testBoolDelegateFunction(2));

//Add anonymous method
test.testDelegateFunction = delegate() { Console.WriteLine("\nAnonymous method"); };
test.testDelegateFunction();

//Lambda expression (anonymous method printed at once, easiest and most compact way to make a method)
test.testDelegateFunction = () => { Console.WriteLine("Lambda expression"); };

//Lambda how to make an anonymous bool method
test.testBoolDelegateFunction = (int i) => { return i < 5; };
Console.WriteLine(test.testBoolDelegateFunction(5));

//Lambda Action that takes int and float and prints out result
test.testIntFloatAction = (int i, float f) => { Console.WriteLine("\nTesting Action"); };
test.testIntFloatAction(5, 5);

//Lambda Func that takes a bool
test.testFunc = () => { return 5 > 3; };   
test.testFunc = () => false;

//Lambda Func test bool that takes an int
test.testIntBoolFunc = (int i) => { return i < 5; };
Console.WriteLine("\n" + test.testIntBoolFunc(5));




