using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri1002
{
    class MainUri1002
    {
        static void Main(string[] args)
        {
            double area, raio, pi = 3.14159;

            raio = double.Parse(Console.ReadLine());
            area = pi * raio * raio;

            Console.WriteLine($"A={area:F4}");
            Console.ReadLine();
        }
    }
}
