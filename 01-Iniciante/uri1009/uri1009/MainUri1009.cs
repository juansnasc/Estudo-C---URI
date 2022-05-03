using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri1009
{
    class MainUri1009
    {
        static void Main(string[] args)
        {
                string nome;
                double salarioFixo, totalVendido, salarioFinal, comissao;

                nome = Console.ReadLine();
                salarioFixo = double.Parse(Console.ReadLine());
                totalVendido = double.Parse(Console.ReadLine());

                comissao = totalVendido * 0.15;
                salarioFinal = salarioFixo + comissao;
                Console.WriteLine($"TOTAL = R$ {salarioFinal:F2}");
                Console.ReadLine();
        }
    }
}
