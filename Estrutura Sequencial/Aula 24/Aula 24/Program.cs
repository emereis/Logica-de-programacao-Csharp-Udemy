using System;
using System.Globalization;
namespace Aula_24
{
    class Program
    {
        static void Main(string[] args)
        {
            double bse, altura, area, perimetro, diagonal;

            Console.WriteLine("Informe a base: ");
            bse = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Informe a altura: ");
            altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = bse * altura;

            perimetro = 2 * bse + 2 * altura;

            diagonal = Math.Sqrt((Math.Pow(bse, 2.0)) + (Math.Pow(altura, 2.0)));

            Console.WriteLine("Altura = " + altura);
            Console.WriteLine("Base = " + bse);
            Console.WriteLine("Área = " + area.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Perímetro = " + perimetro.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal = " + diagonal.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
