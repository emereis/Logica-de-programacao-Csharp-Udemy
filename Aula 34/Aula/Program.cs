using System;
using System.Globalization;
namespace Aula34
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, DELTA, R1, R2;

            string[] vet = Console.ReadLine().Split(' ');

            A = double.Parse(vet [0], CultureInfo.InvariantCulture);
            B = double.Parse(vet [1], CultureInfo.InvariantCulture);
            C = double.Parse(vet [2], CultureInfo.InvariantCulture);

            

            DELTA = Math.Pow(B, 2.0) - 4 * A * C;




            if (A == 0 || DELTA < 0.0)
            {

                Console.WriteLine("Impossivel calcular");

            }

            else {
                R1 = (-B + Math.Sqrt(DELTA)) / (2.0 * A);

                R2 = (-B - Math.Sqrt(DELTA)) / (2.0 * A);

                Console.WriteLine("R1 = " + R1.ToString("F5", CultureInfo.InvariantCulture));
                Console.WriteLine("R2 = " + R2.ToString("F5", CultureInfo.InvariantCulture));
            }

                     

        }
    }
}
