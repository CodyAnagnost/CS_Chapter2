using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eggs
{
    class Program
    {
        static void Main(string[] args)
        {
            int Dinkleburg = 8;
            int Drake =  4;
            int Sean = 9;
            int Cody = 2;
            int eggs = Dinkleburg + Drake + Sean + Cody;
            Console.WriteLine("Total number of eggs is " + eggs + " Dozens " + (eggs / 12) + " eggs " + eggs % 12);
        }
    }
}
