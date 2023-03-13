using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter first x - ");
            int x1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter first y - ");
            int y1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second x - ");
            int x2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second y - ");
            int y2 = Convert.ToInt32(Console.ReadLine());

            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine($"Distance between points = {r:F2}");
            Console.ReadKey();

        }
    }
}
