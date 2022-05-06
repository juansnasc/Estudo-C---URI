using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri1011
{
    class Program
    {
        static void Main(string[] args)
        {
            double volume, R, pi = 3.14159;

            R = double.Parse(Console.ReadLine());
            volume = (4 / 3.0) * pi * R * R * R;

            Console.WriteLine($"VOLUME = {volume:F3}");
            Console.ReadLine();
        }
    }
}
