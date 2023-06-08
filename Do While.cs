using System.Globalization;
using System;

namespace Repeticao
{
    class DoWhile
    {
        static void Main(string[] args)
        {
            int num = 0;

            do
            {
                Console.WriteLine("Digite um número entre 1 e 10: ");
                num = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            } while (num < 1 || num > 10);
            Console.WriteLine("Você digitou " + num + " .");
            return;
        }
    }
}
