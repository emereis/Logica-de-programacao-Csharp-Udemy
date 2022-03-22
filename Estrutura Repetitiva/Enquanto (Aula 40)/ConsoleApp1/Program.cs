using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, total;

            num = int.Parse(Console.ReadLine());
            total = 0;
            while (num != 0)
            {
                total = total + num;
                num = int.Parse(Console.ReadLine());
            }


            Console.WriteLine(total);
            Console.ReadLine();




        }
    }
}
