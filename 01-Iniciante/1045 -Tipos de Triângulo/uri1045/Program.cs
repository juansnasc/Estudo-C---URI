using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri1045
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] entrada;
            double A, B, C, maior, meio, menor;

            entrada = Console.ReadLine().Split(' ');
            A = double.Parse(entrada[0], CultureInfo.InvariantCulture);//5.0
            B = double.Parse(entrada[1], CultureInfo.InvariantCulture);//7.0
            C = double.Parse(entrada[2], CultureInfo.InvariantCulture);//5.0

            maior = meio = menor = A;

            if (A != B && A != C && B != C) {
                if (A > B && A > C) {
                    maior = A;
                    if (B > C)
                    {
                        meio = B;
                        menor = C;
                    }
                    else if (C > B)
                    {
                        meio = C;
                        menor = B;
                    }
                }
                else if (B > A && B > C)
                {
                    maior = B;
                    if (A > C)
                    {
                        meio = A;
                        menor = C;
                    }
                    else if (C > A)
                    {
                        meio = C;
                        menor = A;
                    }
                }
                else if (C > A && C > B)
                {
                    maior = C;
                    if (A > B) {
                        meio = A;
                        menor = B;
                    } else if (B > A) {
                        meio = B;
                        menor = A;
                    }
                }

            } else if (A == B) {
                if (C > A) {
                    maior = C;
                    meio = A;
                    menor = B;
                } else if (A > C) {
                    maior = A;
                    meio = B;
                    menor = C;
                }
            } else if (A == C) {
                if (A > B) {
                    maior = A;
                    meio = C;
                    menor = B;
                } else if (B > A) {
                    maior = B;
                    meio = A;
                    menor = C;
                }
            } else if (B == C) {
                if (A > B) {
                    maior = A;
                    meio = B;
                    menor = C;
                } else if (B > A) {
                    maior = B;
                    meio = A;
                    menor = C;
                }
            }

            A = maior;//7.0
            B = meio;//5.0
            C = menor;//5.0

            if (A >= B + C){ 
                Console.WriteLine("NAO FORMA TRIANGULO");
            }else{
                if (A * A == B * B + C * C)
                    Console.WriteLine("TRIANGULO RETANGULO");
                if (A * A > B * B + C * C)
                    Console.WriteLine("TRIANGULO OBTUSANGULO");
                if (A * A < B * B + C * C)
                    Console.WriteLine("TRIANGULO ACUTANGULO");
                if (A == B && B == C)
                    Console.WriteLine("TRIANGULO EQUILATERO");
                if ((A == B && C != B) || (A == C && B != A) || (B == C && A != B))
                    Console.WriteLine("TRIANGULO ISOSCELES");
            }

            Console.ReadLine();
        }
    }
}
