using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri1037
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (valor < 0.00 || valor > 100.00)
            {
                Console.WriteLine("Fora de intervalo");
            }
            else if (valor >= 0.00 && valor <= 25.00)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (valor > 25.00 && valor <= 50.00)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (valor > 50.00 && valor <= 75.00)
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            else
            {
                Console.WriteLine("Intervalo (75,100]");
            }
        }
    }
}
