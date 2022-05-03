using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri1010
{
    class MainUri1010
    {
        static void Main(string[] args)
        {
            int qtdPecas1,qtdPecas2;
            double valorUnit1, valorUnit2, valorTotalPagar;

            string[] dados1 = Console.ReadLine().Split(' ');
            qtdPecas1 = int.Parse(dados1[1]);
            valorUnit1 = double.Parse(dados1[2]);

            string[] dados2 = Console.ReadLine().Split(' ');
            qtdPecas2 = int.Parse(dados2[1]);
            valorUnit2 = double.Parse(dados2[2]);

            valorTotalPagar = qtdPecas1*valorUnit1 + qtdPecas2*valorUnit2;
            Console.WriteLine($"VALOR A PAGAR: R$ {valorTotalPagar:F2}");
        }
    }
}
