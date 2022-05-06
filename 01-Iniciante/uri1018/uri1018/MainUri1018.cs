using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri1018
{
    class MainUri1018
    {
        static void Main(string[] args){
            int[] valores = {100,50,20,10,5,2,1};
            int[] ocorrencias = new int[7];
            int N;

            N = int.Parse(Console.ReadLine());

            if(N>0 && N< 1000000){

                Console.WriteLine(N);

                for (int i = 0; i < 7; i++)
                {
                    if (N / valores[i] != 0)
                    {
                        ocorrencias[i] = N / valores[i];
                        N %= valores[i];
                    }
                    else
                        continue;
                }

                for (int i = 0; i < 7; i++)
                {
                    Console.WriteLine(ocorrencias[i] + " nota(s) de R$"+valores[i]+",00");
                }
            }

            Console.ReadLine();
        }
    }
}
