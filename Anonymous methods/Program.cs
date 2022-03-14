using System;

namespace Anonymous_methods
{
    class Program
    {

        static void Main(string[] args)
        {
            var anonMeth = new AnonymousMethods();

            GreetingsDelegate obj = delegate (string name)
            {
                return "Hello " + name + " a very good morning!";
            };

            string str = obj.Invoke("Jonathan");
            Console.WriteLine(str);
            Console.ReadKey();

        }
    }
}
