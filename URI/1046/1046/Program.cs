using System;

namespace _1046
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');

            int horaini = int.Parse(vet[0]);
            int horafim = int.Parse(vet[1]);

            int duracao;
            if (horaini < horafim) 
            {
                duracao = horafim - horaini;
            }

            else
            {
                duracao = 24 - horaini + horafim;
            }

            Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");

        }
    }
}
