//Bibliotecas padrões.
using System.Globalization;
using System;
//Programa While
namespace Repeticao
{   //Classe principal do Programa.
    class Program
    {   //Corpo principal do código.
        static void Main(string[] args)
        {   //Declaração da variável.
            int num, i = 1;
            //Interface que pede um número inteiro positivo.
            Console.WriteLine("Digite um número inteiro positivo: ");
            //Lê e armazena o número na variável em questão.
            num = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            // Estrutura de repetição que executa enquanto 'i' for menor ou igual a 'num'.
            while (i <= num)
            {   // Imprime o valor de 'i'.
                Console.WriteLine(i);
                //Contador. Faz com que os números seguintes aumentem seu valor em 1.
                i++;
            }//Encerra o programa. Não retorna a nada pois estamos dentro de um Void.
            return;
        }
    }
}
