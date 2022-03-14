using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_methods
{
    public delegate string GreetingsDelegate(string name);
    class AnonymousMethods
    {
        /// <summary>
        /// Greetingses the specified name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public static string Greetings(string name)
        {
            return "Hello " + name + "a very good morning!";
        }
    }
}
