using System;
using System.Globalization;
namespace Aula_33
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, soma;

            Console.WriteLine("Informe o valor da sua nota no primeiro semestre : ");
            nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture );



            Console.WriteLine("Informe o valor da sua nota no segundo semestre : ");
            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture) ;

            soma = nota1 + nota2;
            

            if (soma >= 60.00)
            {
                Console.WriteLine("Nota Final = " + soma.ToString ("F1", CultureInfo.InvariantCulture) + " Aprovado!"); ;
            }

            else
            
                Console.WriteLine("REPROVADO!");
            
                



        }
    }
}
