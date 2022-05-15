using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri1046
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] horas;
            int hInicio, hFim, duracao=0;

            horas = Console.ReadLine().Split(' ');
            hInicio = int.Parse(horas[0]);
            hFim = int.Parse(horas[1]);

            if (hInicio == hFim)
                duracao = 24;
            else if (hFim > hInicio && hFim <= 24)
                duracao = hFim - hInicio;
            else if (hInicio > hFim)
                duracao = hFim + 24 - hInicio;

            Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
            Console.ReadLine();
        }
    }
}
