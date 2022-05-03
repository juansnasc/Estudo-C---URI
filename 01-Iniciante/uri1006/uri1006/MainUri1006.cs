using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri1006
{
    class MainUri1006
    {
        static void Main(string[] args)
        {
            double A, B, C, MEDIA;

            A = double.Parse(Console.ReadLine());
            B = double.Parse(Console.ReadLine());
            C = double.Parse(Console.ReadLine());

            MEDIA = (A * 2 + B * 3 + C * 5) / 10.0;
            Console.WriteLine($"MEDIA = {MEDIA:F1}");
        }
    }
}
