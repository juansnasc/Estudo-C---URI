using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri1013
{
    class MainUri1013
    {
        static void Main(string[] args)
        {
            string[] valores;
            int a, b, c, maiorAB, maiorABC;

            valores = Console.ReadLine().Split(' ');

            a = int.Parse(valores[0]);
            b = int.Parse(valores[1]);
            c = int.Parse(valores[2]);

            maiorAB = (a + b + Math.Abs(a - b)) / 2;
            maiorABC = (maiorAB + c + Math.Abs(maiorAB-c)) / 2;

            Console.WriteLine(maiorABC + " eh o maior");
            Console.ReadLine();
        }
    }
}
