using System;
using System.Globalization;

namespace curso{
    class Program
    {
        static void Main(String[] args)  {

           Double x = 10.35784;

            Console.WriteLine(x.ToString("F2"));
            Console.WriteLine(x.ToString("F3"));
            Console.WriteLine(x.ToString("F4"));

            Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();

        }

    }

}