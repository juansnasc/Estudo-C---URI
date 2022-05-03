using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri1008
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, qtdHorasTrab;
            double valorPorHora, salario;

            numero = int.Parse(Console.ReadLine());
            qtdHorasTrab = int.Parse(Console.ReadLine());
            valorPorHora = double.Parse(Console.ReadLine());

            salario = qtdHorasTrab * valorPorHora;
            Console.WriteLine($"NUMBER = {numero}");
            Console.WriteLine($"SALARY = U$ {salario:F2}");
        }
    }
}
