using System;
using System.Globalization;
namespace Exercício_de_Fixação_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, triangulo, circulo, trapezio, quadrado, retangulo;

            string [] valores = Console.ReadLine().Split(' ');
            A = double.Parse(valores[0], CultureInfo.InvariantCulture);
            B = double.Parse(valores[1], CultureInfo.InvariantCulture);
            C = double.Parse(valores[2], CultureInfo.InvariantCulture);


            triangulo = (double)A * C / 2.0;
            circulo = (double) 3.14159 * C * C;
            trapezio = (double)(A + B) / 2 * C;
            quadrado = (double) B * B;
            retangulo = (double)A * B; 

            Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
