using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri1036
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores;
            double A, B, C, r1=0, r2, delta;

            valores = Console.ReadLine().Split(' ');
            A = double.Parse(valores[0], CultureInfo.InvariantCulture);
            B = double.Parse(valores[1], CultureInfo.InvariantCulture);
            C = double.Parse(valores[2], CultureInfo.InvariantCulture);

            delta = B * B - 4 * A * C;

            if (delta < 0 || A == 0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                r1 = (-B + Math.Sqrt(delta)) / (2 * A);
                r2 = (-B - Math.Sqrt(delta)) / (2 * A);

                Console.WriteLine("R1 = " + r1.ToString("F5", CultureInfo.InvariantCulture));
                Console.WriteLine("R2 = " + r2.ToString("F5", CultureInfo.InvariantCulture));
            }

            Console.ReadLine();
        }
    }
}
