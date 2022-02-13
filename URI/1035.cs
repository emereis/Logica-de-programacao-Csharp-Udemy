using System;

namespace Aula_38
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, D;

            string[] vet = Console.ReadLine().Split(' ');

            A = int.Parse((vet[0]));
            B = int.Parse((vet[1]));
            C = int.Parse((vet[2]));
            D = int.Parse((vet[3]));

            switch (B > C && D > A && C + D > A + B && C > 0 && D > 0 && A % 2 == 0)
            {
                case true:
                    Console.WriteLine("Valores aceitos");
                    break;

                case false:
                    Console.WriteLine("Valores não aceitos");
                    break;
            }    


        }



    }
}

