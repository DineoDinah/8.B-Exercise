using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.B_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(test(5, 4));
            Console.WriteLine(test(4, 3));
            Console.WriteLine(test(1, 4));
            Console.ReadLine();
        }
        public static bool test(int x, int y) 
        {
            if (x == 5 || y == 5 ||(x + y == 5) ||Math.Abs(x - y) == 5 )
                return true;
            else
                return false;
        }
    }
}
