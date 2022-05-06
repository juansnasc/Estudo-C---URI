using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri1012
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores;
            double A, B, C, areaTrian, areaCirc, areaTrap, areaQuad, areaRet, pi = 3.14159;

            valores = Console.ReadLine().Split(' ');

            A = double.Parse(valores[0], CultureInfo.InvariantCulture);
            B = double.Parse(valores[1], CultureInfo.InvariantCulture);
            C = double.Parse(valores[2], CultureInfo.InvariantCulture);

            areaTrian = (A * C) / 2;
            areaCirc = pi * C * C;
            areaTrap = ((A + B) * C) / 2;
            areaQuad = B * B;
            areaRet = A * B;

            Console.WriteLine("TRIANGULO: " + areaTrian.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + areaCirc.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + areaTrap.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + areaQuad.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + areaRet.ToString("F3", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}
