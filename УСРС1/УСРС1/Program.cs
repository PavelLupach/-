using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace УСРС1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            Console.WriteLine($"1 a = {a}");
            
            a += 10;
            Console.WriteLine($"2 a = {a}");

            a -= 4;
            Console.WriteLine($"3 a = {a}");

            a *= 2;
            Console.WriteLine($"4 a = {a}");

            a %= 8;
            Console.WriteLine($"5 a = {a}");

            a |= 4;
            Console.WriteLine($"6 a = {a}");

            a &= 2;
            Console.WriteLine($"7 a = {a}");

            int b = 6;
            Console.WriteLine($"b = {b}");

            int c = a += b -= 5;
            Console.WriteLine($"c = {c}");
        }
    }
}
