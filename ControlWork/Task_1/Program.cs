using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, world!");
            Console.WriteLine("And hi again!");
            Random rand = new Random();
            int size = rand.Next(5, 50);
            for (int i = 5; i < size; i++)
            {
                Console.Write("!");
            }
        }
    }
}