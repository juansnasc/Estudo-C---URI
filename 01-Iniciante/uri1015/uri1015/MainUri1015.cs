using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri1015
{
    public class MainUri1015
    {
        static void Main(string[] args)
        {
            string[] coordenadas1, coordenadas2;
            double x1, y1, x2, y2, distancia, resultado1, resultado2;

            coordenadas1 = Console.ReadLine().Split(' ');
            coordenadas2 = Console.ReadLine().Split(' ');

            x1 = double.Parse(coordenadas1[0], CultureInfo.InvariantCulture);
            y1 = double.Parse(coordenadas1[1], CultureInfo.InvariantCulture);
            x2 = double.Parse(coordenadas2[0], CultureInfo.InvariantCulture);
            y2 = double.Parse(coordenadas2[1], CultureInfo.InvariantCulture);

            resultado1 = quadrado(x2 - x1);
            resultado2 = quadrado(y2 - y1);

            distancia = Math.Sqrt(resultado1 + resultado2);
            Console.WriteLine(distancia.ToString("F4", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }

        public static double quadrado(double valor)
        {
            return valor * valor;
        }
    }
}
