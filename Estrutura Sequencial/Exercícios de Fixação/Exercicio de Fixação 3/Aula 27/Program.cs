using System;

namespace Aula_27
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n, hora, resto, minuto, segundo;

            n = int.Parse(Console.ReadLine());

            hora = n / 3600;

            resto = n % 3600;

            minuto = resto / 60;

            segundo = resto % 60;

            Console.WriteLine(hora + ":" + ":" + minuto + ":" + segundo);
            
        }
    }
}
