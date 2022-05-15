using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri1043
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] entrada;
            double A, B, C;

            entrada = Console.ReadLine().Split(' ');
            A = double.Parse(entrada[0], CultureInfo.InvariantCulture);
            B = double.Parse(entrada[1], CultureInfo.InvariantCulture);
            C = double.Parse(entrada[2], CultureInfo.InvariantCulture);

            if (A + B > C && A + C > B && B + C > A)
            {
                double perimetro = A + B + C;
                Console.WriteLine("Perimetro = " + perimetro.ToString("F1", CultureInfo.InvariantCulture));
            }
            else
            {
                double areaTrap = (A + B) * C / 2;
                Console.WriteLine("Area = " + areaTrap.ToString("F1", CultureInfo.InvariantCulture));
            }

            Console.ReadLine();
        }
    }
}
