using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri1017{
    class Program
    {
        static void Main(string[] args)
        {

            int tempoViagem, velMedViagem, distanciaTotal;
            double litrosNecessarios;

            tempoViagem = int.Parse(Console.ReadLine());
            velMedViagem = int.Parse(Console.ReadLine());

            distanciaTotal = tempoViagem * velMedViagem;
            litrosNecessarios = distanciaTotal / 12.0;
            Console.WriteLine(litrosNecessarios.ToString("F3",CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}
