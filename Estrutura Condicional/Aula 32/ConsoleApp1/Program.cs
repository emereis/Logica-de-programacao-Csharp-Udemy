using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int horas;

            Console.WriteLine("Informe o valor de X: ");
            horas = int.Parse(Console.ReadLine());
            

            if (horas > 4 && horas < 12 )  {
                Console.WriteLine("Bom dia!");            
            }

            if (horas > 12 && horas < 18)   {
                Console.WriteLine("Boa tarde!");
            }

            if (horas >= 18 || horas < 04)  {
                Console.WriteLine("Boa noite!");
            }
                
            

            Console.ReadLine();
        }
    }
}
