using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter your name - ");
            string name = Console.ReadLine();

            Console.Write("Enter your surname - ");
            string surname = Console.ReadLine();

            Console.Write("How old you - ");
            int year = Convert.ToInt32(Console.ReadLine());

            Console.Write("What is your weight - ");
            int weight = Convert.ToInt32(Console.ReadLine());

            Console.Write("What is your height - ");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(name + " " + surname + " " + year + " years " + weight + "kg " + height + "sm ");
            Console.WriteLine("{0} {1} {2} years {3}kg {4}sm", name, surname, year, weight, height);
            Console.WriteLine($"{name} {surname} {year} years {weight}kg {height}sm");
            Console.ReadKey();

        }
    }
}
