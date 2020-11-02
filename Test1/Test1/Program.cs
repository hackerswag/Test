using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tal 1:");
           
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Tal 2:");

            int b = int.Parse(Console.ReadLine());

            int c = a + b;
            Console.WriteLine(c);

            Console.WriteLine("Snälla funka");
        }
    }
}
