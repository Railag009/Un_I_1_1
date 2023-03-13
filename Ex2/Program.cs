using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            Console.Write("What is your weight - ");
            int weight = Convert.ToInt32(Console.ReadLine());

            Console.Write("What is your height - ");
            double height = Convert.ToDouble(Console.ReadLine());

            double I = weight / (height * height);

            Console.WriteLine($"Your IMT = {I}");
            Console.ReadKey();

        }
    }
}
