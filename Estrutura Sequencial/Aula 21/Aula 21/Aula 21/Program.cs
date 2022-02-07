using System;
using System.Globalization;

namespace Aula_20
{
    class Program
    {
        static void Main(string[] args)
        {/*Fazer um programa para ler as medidas da largura e comprimento de um terreno retangular com uma casa
          * decimal, bem como o valor do metro quadrado do terreno com duas casas decimais. Em seguida, o 
          * programa deve mostrar o valor da área do terreno, bem como o valor do preço do terreno, ambos com duas casas
          * decimais, conforme o exemplo.
         */

            double largura, comprimento, precometroquadrado, area, preco;


            Console.WriteLine("Informe a largura do terre    : ");
            largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("Informe o comprimento do terreno: ");
            comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Informe o valor do preço por metro quadrado: ");
            precometroquadrado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = largura * comprimento;

            preco = area * precometroquadrado;

            Console.WriteLine("Area = " + area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Preço = " + preco.ToString("F2", CultureInfo.InvariantCulture));


            Console.ReadLine();
        }
    }
}
