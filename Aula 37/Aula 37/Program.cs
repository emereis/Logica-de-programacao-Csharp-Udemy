using System;

namespace Aula_37
{
    class Program
    {
        static void Main(string[] args)
        {
            //SWITCH CASE
            
            int x;
            string dia;

            x = int.Parse(Console.ReadLine());

            /* SEM SWITCH
            if (x == 1)
            {
                dia = "Domingo";
            }

            else if (x == 2)
            {
                dia = "Segunda";
            }

            else if (x == 3)
            {
                dia = "Terça";
            }

            else if (x == 4)
            {
                dia = "Quarta";
            }

            else if (x == 5)
            {
                dia = "Quinta";
            }

            else if (x == 6)
            {
                dia = "Sexta";
            }

            else if (x == 7)
            {
                dia = "Sábado";
            }

            else
            {
                dia = "Valor inválido";
            }



            Console.WriteLine("Dia da semana : " + dia);
            Console.ReadLine();*/



            //COM SWITCH CASE

            switch (x)
            {
                case 1:
                    dia = "domingo";
                    break;
                case 2:
                    dia = "segunda";
                    break;
                case 3:
                    dia = "terça";
                    break;
                case 4:
                    dia = "quarta";
                    break;
                case 5:
                    dia = "quinta";
                    break;
                case 6:
                    dia = "sexta";
                    break;
                case 7:
                    dia = "sábado";
                    break;
                default:
                    dia = "valor inválido";
                    break;
            }

            Console.WriteLine("Dia da semana " +dia);

        }
    }
}
