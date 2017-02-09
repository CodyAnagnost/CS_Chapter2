using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EggsInteractive
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int eggs1, eggs2, eggs3, eggs4;

            Console.WriteLine("How many eggs did the first chicken lay?");
            eggs1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many eggs did the second chicken lay?");
            eggs2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many eggs did the third chicken lay?");
            eggs3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many eggs did the fourth chicken lay?");
            eggs4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(eggs1 + eggs2 + eggs3 + eggs4); 
        }
    }
}
