//Biblioteca padrão
using System;
//Classe do código.
class Program
    {   //Corpo principal do código. Aqui há um string com array que permite adicionar novos códigos e argumentos.
        static void Main(string[] args)
        {   //Declaração da variável.
            int num;
            //Interface interativa.
            Console.Write("Digite um número inteiro positivo: ");
            //Aqui a informação anterior será lida e armazenada na variável em questão.
            num = int.Parse(Console.ReadLine());
            //Interface que mostra a quantidade de números pares que serão exibidos.
            Console.Write("Os primeiros " + num + " são pares ");
            //Estrutura de repetição. O i vale 2 e enquanto o i for menor ou igual ao número digitado o código ficará repetindo. O contador final força o resultado somar 2 o tempo todo.
            for (int i = 2; i <= num * 2; i += 2)
            {   //Interface que soma o valor de i e gerá nosso número.
                 Console.Write(i + " ");
            }
            //Quebra de linha após a exibição dos números            
            Console.WriteLine();
        }
    }
