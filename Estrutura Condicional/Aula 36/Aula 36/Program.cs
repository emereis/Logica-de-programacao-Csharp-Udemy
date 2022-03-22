using System;
using System.Globalization;
namespace Aula_36
{
    class Program
    {
        static void Main(string[] args)
        {
            int minuto;
            double conta;

            minuto = int.Parse(Console.ReadLine());

            conta = 50.0;

            if (minuto > 100)
            {
                conta += ((minuto - 100) * 2.0); // A mesma coisa que conta = conta + ((minuto - 100) * 2.0);
            }

            Console.WriteLine("Valor a pagar: R$ " + conta.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();

        }
    }
}
