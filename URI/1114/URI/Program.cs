using System;

namespace URI
{
    class Program
    {
        static void Main(string[] args)
        {
            int senha;

            senha = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("Senha Invalida");
                senha = int.Parse(Console.ReadLine());
                
            }
            while (senha != 2002);
            {
                Console.WriteLine("Acesso Permitido");

            }



            Console.ReadLine();




        }
    }
}
