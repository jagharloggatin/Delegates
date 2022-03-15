using System;

namespace MyApp // Note: actual namespace depends on the project name.
{


    internal class Program
    {
        public enum StarWars
        {
            May, The, Force, Be, With, You
        }
        static void Main(string[] args)
        {
            int counter1 = 0;
            int counter2 = 0;

            foreach (var item in ASimpleEnumerableFox())
            {
                counter1++;
                Console.WriteLine($"{counter1} {item}");
            }

            Console.WriteLine();

            foreach (var item in ASimpleEnumerableStarWars())
            {
                counter2++;
                Console.WriteLine($"{counter2} {item}");
            }
        }
        static IEnumerable<string> ASimpleEnumerableFox()
        {
            for (int i = 0; i < 20; i++)
            {
                yield return "The Quick Brown Fox";
            }
        }
        static IEnumerable<StarWars> ASimpleEnumerableStarWars()
        {
            var rnd = new Random();
            List<StarWars> starList = new List<StarWars>();

            for (int i = 0; i < 20; i++)
            {
                starList.Add((StarWars)rnd.Next(0, 6));
                yield return starList[i];
            }
        }
    }
}

