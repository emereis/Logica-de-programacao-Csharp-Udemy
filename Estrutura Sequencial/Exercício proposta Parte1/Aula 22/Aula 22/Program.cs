using System;
using System.Globalization;
namespace Aula_22
{
    class Program
    {
        static void Main(string[] args)
        {
            float R, area, pi = 3.14159;

            R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = pi * (R * R);

            Console.WriteLine("Area= " + area.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
