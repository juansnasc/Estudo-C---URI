﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri1115
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores;
            int x, y;// +-  -- -+ ++

            valores = Console.ReadLine().Split(' ');

            x = int.Parse(valores[0]);
            y = int.Parse(valores[1]);

            while(x!=0 && y != 0){
                if (x > 0 && y > 0)
                    Console.WriteLine("primeiro");
                else if (x < 0 && y > 0)
                    Console.WriteLine("segundo");
                else if (x < 0 && y < 0)
                    Console.WriteLine("terceiro");
                else if (x > 0 && y < 0)
                    Console.WriteLine("quarto");

                valores = Console.ReadLine().Split(' ');

                x = int.Parse(valores[0]);
                y = int.Parse(valores[1]);
            }

            //Console.ReadLine();
        }
    }
}
