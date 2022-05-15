using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri1040
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores;
            double N1,N2,N3,N4,media;

            valores = Console.ReadLine().Split(' ');
            N1 = double.Parse(valores[0], CultureInfo.InvariantCulture);
            N2 = double.Parse(valores[1], CultureInfo.InvariantCulture);
            N3 = double.Parse(valores[2], CultureInfo.InvariantCulture);
            N4 = double.Parse(valores[3], CultureInfo.InvariantCulture);

            media = Math.Truncate((N1 * 2 + N2 * 3 + N3 * 4 + N4 * 1))/10;

            Console.WriteLine("Media: " + media.ToString("F1",CultureInfo.InvariantCulture));

            if (media >= 7.0)
                Console.WriteLine("Aluno aprovado.");
            else if (media >= 5.0 && media <= 6.9)
            {
                Console.WriteLine("Aluno em exame.");
                double exame = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine("Nota do exame: " + exame.ToString("F1", CultureInfo.InvariantCulture));
                media = (media + exame) / 2.0;

                if (media >= 5.0)
                    Console.WriteLine("Aluno aprovado.");
                else
                    Console.WriteLine("Aluno reprovado.");
                Console.WriteLine("Media final: " + media.ToString("F1", CultureInfo.InvariantCulture));
            }
            else
                Console.WriteLine("Aluno reprovado.");
            Console.ReadLine();
        }
    }
}
