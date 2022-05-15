using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri1060
{
    class Program
    {
        public static void Main(string[] args) {
            string[] valores = new string[6];
            int qtdPositivos = 0;

            for(int i = 0; i < valores.Length; i++)
                valores[i] = Console.ReadLine();
            
            for(int i=0; i< valores.Length; i++)
                if (!identificaChar(valores[i], '-'))
                    qtdPositivos++;

            Console.WriteLine($"{qtdPositivos} valores positivos");
            Console.ReadLine();
        }

        public static bool identificaChar(string cadeia,char procurado){
            int k=0;
            
            while (k < cadeia.Length)
            {
                if (cadeia[k] == procurado)
                    return true;
                k++;
            }
            return false;
        }
    }
}
