using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace uri1014
{
    class MainUri1014
    {
        static void Main(string[] args)
        {
            int distTotalPercorrida;
            double totCombustivelGasto, consumoMedio;

            distTotalPercorrida = int.Parse(Console.ReadLine());
            totCombustivelGasto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            consumoMedio = distTotalPercorrida / totCombustivelGasto;
            Console.WriteLine(consumoMedio.ToString("F3", CultureInfo.InvariantCulture) + " km/l");
            Console.ReadLine();
        }
    }
}
