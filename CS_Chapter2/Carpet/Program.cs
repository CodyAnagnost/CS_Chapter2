using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Carpet
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 25;
            int width = 42;
            int length_yards = length / 3;
            int width_yards = width / 3;
            double cost = length_yards * width_yards ;
            Console.WriteLine("The total cost per square foot is");
        }
    }
}
