using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter first number - ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number - ");
            int b = Convert.ToInt32(Console.ReadLine());

            a = b - a;
            b = b - a;
            a = a + b;

            Console.WriteLine($"a = {a} b = {b}");
            Console.ReadKey();

        }
    }
}
