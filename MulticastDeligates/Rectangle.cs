using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticastDeligates
{
    class Rectangle
    {
        public void GetArea(double Width, double Height)
        {
            Console.WriteLine($"Area is: {Width * Height}");
        }
        public void GetPerimiter(double Width, double Height)
        {
            Console.WriteLine($"Perimeter is: {2 * (Width * Height)}");
        }
    }
}
