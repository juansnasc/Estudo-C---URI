using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri1004
{
    class MainUri1004
    {
        static void Main(string[] args)
        {

            int A, B, PROD;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());

            PROD = A * B;
            Console.WriteLine($"PROD = {PROD}");
        }
    }
}
