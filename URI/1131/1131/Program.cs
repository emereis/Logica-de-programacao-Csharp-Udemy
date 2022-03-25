using System;

namespace _1131
{
    class Program
    {
        static void Main(string[] args)
        {
            int golsinter, golsgremio, jogo, qtdejogos, vitinter, vitgremio, empate;
            

            qtdejogos = 0;
            vitgremio = 0;
            vitinter = 0;
            empate = 0;
            jogo = 1;

            while (jogo == 1)
            {
                golsinter = int.Parse(Console.ReadLine());

                golsgremio = int.Parse(Console.ReadLine());

                qtdejogos = qtdejogos + 1;


                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                jogo = int.Parse(Console.ReadLine());

                if (golsinter > golsgremio)
                {
                    vitinter = vitinter + 1;
                }

                else if (golsinter < golsgremio)
                {
                    vitgremio = vitgremio + 1;
                }

                else
                {
                    empate = empate + 1;
                }



            }

            

            Console.WriteLine(qtdejogos + " GRENAIS");
            Console.WriteLine("Inter:" + vitinter);
            Console.WriteLine("Gremio:" + vitgremio);
            Console.WriteLine("Empate:" + empate);
            
            if (vitinter > vitgremio)
            {
               Console.WriteLine( "Inter venceu mais");
            }

            else if (vitinter < vitgremio)
            {
                Console.WriteLine("Gremio venceu mais");
            }

            else {
                Console.WriteLine("Empate");

            }
        }
    }
}
