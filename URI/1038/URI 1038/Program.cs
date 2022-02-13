using System;
using System.Globalization;

namespace URI_1038
{
    class Program
    {
        static void Main(string[] args)
        {
            

            string[] valores = Console.ReadLine().Split(' ');
            int codigo = int.Parse(valores[0]);
            int quantidade = int.Parse(valores[1]);


            double total;
            if (codigo == 1)
            {
                total = quantidade * 4.00  ;
            }


            else if (codigo == 2)
            {
                total = quantidade * 4.50 ;
            }


            else if (codigo == 3)
            {
                total = quantidade * 5.00;
            }

            else if (codigo == 4)
            {
                total = quantidade * 2.00 ;
            }

            else
            {
                total = quantidade * 1.50;
            }
                
            Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));

        
        }
    }
}
