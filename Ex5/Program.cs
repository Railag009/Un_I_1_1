using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter your name - ");
            string name = Console.ReadLine();

            Console.Write("Enter your surname - ");
            string surname = Console.ReadLine();

            Console.Write("Enter your city - ");
            string city = Console.ReadLine();

            Console.Clear();
            Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
            Console.WriteLine($"Вас зовут {name} {surname}, вы из города {city}");
            Console.ReadKey();

        }
    }
}
