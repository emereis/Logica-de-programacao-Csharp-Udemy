using System;

namespace Aula19
{
    class Program
    {
        static void Main(string[] args)
        {
            //A = Math.Sqrt(x); Variável A recebe a raiz quadrada de X.
            //A = Math.Pow(x,y); Variável A recebe o resultado de X elevado a Y.
            //A = Math.Abs(x); Variável A recebe o valor absoluto de X.


            double a;
            Console.WriteLine("Informe o valor de A: ");
            a = double.Parse(Console.ReadLine());

            double b;
            Console.WriteLine("Informe o valor de B: ");
            b = double.Parse(Console.ReadLine());

            double c;
            Console.WriteLine("Informe o valor de C: ");
            c = double.Parse(Console.ReadLine());


            double delta;
            delta = Math.Pow(b, 2) - 4 * a * c;

            double x1;
            x1 = (-b + Math.Sqrt(delta)) / (2 * a);

            double x2;
            x2 = (+b + Math.Sqrt(delta)) / (2 * a);


            Console.WriteLine("O valor de delta= " + delta);
            Console.WriteLine("O valor de X1= " + x1);
            Console.WriteLine("O valor de X2= " + x2);
        
        
        
        }
    }
}
