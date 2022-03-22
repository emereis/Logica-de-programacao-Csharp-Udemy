using System;
using System.Globalization;
namespace Aula_30
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Exercicio 1010 SPLIT ;
            * int codigo1, codigo2, qtde1, qtde2;
            double vlr1, vlr2, total;

            string[] valores = Console.ReadLine().Split(' ');
            codigo1 = int.Parse(valores[0]);
            qtde1 = int.Parse(valores[1]);
            vlr1 = double.Parse(valores[2], CultureInfo.InvariantCulture);
            
            valores = Console.ReadLine().Split(' ');
            codigo2 = int.Parse(valores[0]);
            qtde2 = int.Parse(valores[1]);
            vlr2 = double.Parse(valores[2], CultureInfo.InvariantCulture);
            
            total = (vlr1 * qtde1) + (vlr2 * qtde2);
            
            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            
            
            
            EXERCICIO 1014
            int distancia;
            double combustivel, medio;
            
            distancia = int.Parse (Console.ReadLine());
            combustivel= double.Parse (Console.ReadLine(), CultureInfo.InvariantCulture);
            
            medio = (double) distancia / combustivel;
            
            Console.WriteLine(medio.ToString("F3", CultureInfo.InvariantCulture) + "km/l");
            
            
            EXERCICIO 1016
            
            int distancia, tempo;
            
            distancia = int.Parse(Console.ReadLine());
            
            tempo = distancia * 2;
            
            Console.WriteLine(tempo + " minutos");
            
            
            EXERCICIO 1017*/

            int tempo, velocidade, distancia;
            double combustivel;

            tempo = int.Parse(Console.ReadLine());
            velocidade = int.Parse(Console.ReadLine());

            distancia =  tempo * velocidade;

            combustivel = distancia / 12.0;

            Console.WriteLine(combustivel.ToString("F3", CultureInfo.InvariantCulture));
   
        }
    }
}
