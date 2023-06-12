//Bibliotecas padrões.
using System.Globalization;
using System;

namespace Repeticao
{   //Classe principal do programa. 
    class DoWhile
    {   //Corpo principal do código.
        static void Main(string[] args)
        {   //Declaração da variável.
            int num = 0;
            //Parte do código que será repetido.
            do
            {   //Interface interativa que pede um número.
                Console.WriteLine("Digite um número entre 1 e 10: ");
                //Lê e armazena o número digitado na variável.
                num = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             // Verifica se o número está fora do intervalo permitido.
            } while (num < 1 || num > 10);
             // Exibe o número digitado pelo usuário.
            Console.WriteLine("Você digitou " + num + " .");
            //Encerra o programa
            return;
        }
    }
}
