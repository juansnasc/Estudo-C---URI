using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri1114
{
    class Program
    {
        static void Main(string[] args){
            int valor = int.Parse(Console.ReadLine());

            while(valor != 2002)
            {
                Console.WriteLine("Senha Invalida");

                valor = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso Permitido");
            Console.ReadLine();
        }
    }
}
