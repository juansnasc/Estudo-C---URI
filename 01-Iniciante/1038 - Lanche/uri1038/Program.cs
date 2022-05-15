using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri1038
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] entrada;
            int codigo, quantidade;
            double total, preco = 0;

            entrada = Console.ReadLine().Split(' ');
            codigo = int.Parse(entrada[0]);
            quantidade = int.Parse(entrada[1]);

            switch (codigo)
            {
                case 1:
                    preco = 4.00;
                    break;
                case 2:
                    preco = 4.50;
                    break;
                case 3:
                    preco = 5.00;
                    break;
                case 4:
                    preco = 2.00;
                    break;
                case 5:
                    preco = 1.50;
                    break;      
            }

            total = preco * quantidade;
            Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}
