using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ur1042
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores;
            int A,B,C;

            valores = Console.ReadLine().Split(' ');

            A = int.Parse(valores[0]);
            B = int.Parse(valores[1]);
            C = int.Parse(valores[2]);

            if(A<B && A<C){
                Console.WriteLine(A);
                if (B<C){
                    Console.WriteLine(B);
                    Console.WriteLine(C);
                }else if (C<B)
                {
                    Console.WriteLine(C);
                    Console.WriteLine(B);
                }
            }else if(B<A && B<C){
                Console.WriteLine(B);
                if (A<C){
                    Console.WriteLine(A);
                    Console.WriteLine(C);
                }else if (C<A){
                    Console.WriteLine(C);
                    Console.WriteLine(A);
                }
            }else if(C<A && C<B){
                Console.WriteLine(C);
                if (A<B){
                    Console.WriteLine(A);
                    Console.WriteLine(B);
                }else if(B<A){
                    Console.WriteLine(B);
                    Console.WriteLine(A);
                }
            }

            Console.WriteLine();
            
            for(int i = 0; i < valores.Length; i++)
            {
                Console.WriteLine(valores[i]);
            }

            Console.ReadLine();
        }
    }
}
