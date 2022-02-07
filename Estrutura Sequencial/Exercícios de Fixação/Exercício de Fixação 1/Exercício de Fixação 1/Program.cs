using System;
using System.Globalization;
namespace Exercício_de_Fixação_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;

            Console.WriteLine("Digite o seu nome completo:");
            nome = Console.ReadLine();
            Console.WriteLine($"O seu nome completo é: {nome}.");


            int casa;

            Console.WriteLine("Quantos quartos tem na sua casa? ");
            casa = int.Parse(Console.ReadLine());
            Console.WriteLine($"A sua casa possuí: {casa} quartos.");


            double preco;
            Console.WriteLine("Entre com o preço de um produto");
            preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine($"O preço do seu produto informado é: {preco.ToString("F2", CultureInfo.InvariantCulture)}");


            Console.WriteLine("Informe o seu ultimo nome, idade, e altura (mesma linha):");
            string[] vet = Console.ReadLine().Split(' ');
            string ultimo_nome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);


            Console.WriteLine(ultimo_nome );
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
            
            
        }
    }
}
