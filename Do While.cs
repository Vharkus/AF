//Bibliotecas padrões.
using System.Globalization;
using System;

namespace Repeticao
{   //Classe principal do programa. 
    class DoWhile
    {   //Corpo principal do código.
        static void Main()
        {   //Declaração da variável.
            bool repeat = true;
            while (repeat)
            {


                int num;
                bool Invalid = false;
                //Parte do código que será repetido.
                do
                {  
                    //Interface interativa que pede um número.
                    Console.WriteLine("Digite um número entre 1 e 10: ");
                    //Lê e armazena o número digitado na variável.
                    string input = Console.ReadLine();
                    if (!int.TryParse(input, out num) || num < 1 || num > 10)
                    {
                        Console.WriteLine("Numero invalido. Tente Novamente, com valores de 1 a 10.");
                    }
                    else
                    {
                        Invalid = true;
                    }
                    // Verifica se o número está fora do intervalo permitido.
                } while (!Invalid);
                // Exibe o número digitado pelo usuário.
                Console.WriteLine("Você digitou " + num + " .");

                Console.WriteLine("Deseja digitar um novo número? (S/N): ");

                string repeatInput = Console.ReadLine();

                repeat = string.Equals(repeatInput, "S", StringComparison.OrdinalIgnoreCase);
            }
        }
    }
}
