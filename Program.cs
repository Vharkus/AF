using System.Globalization;
using System;
//Programa While
namespace Repeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, i = 1;
            Console.WriteLine("Digite um número inteiro positivo: ");
            num = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            while (i <= num)
            {
                Console.WriteLine(i);
                i++;
            }
            return;
        }
    }
}