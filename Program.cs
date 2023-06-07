//Dá acesso a biblioteca, além de facilitar a escrtia do código.
using System;
class Program
{
    //Corpo principal do meu programa. String[]args é um parâmetro com array que pode ser usado para passar argumentos de linha de comando para o programa
    static void Main(string[] args)
    {   //Declaração das variáveis.
        char op, resposta;
        float num1, num2;
        bool continuar = true;
        //Condição de repetição. Enquanto "continuar for verdadeiro o loop não para.
        while (continuar)
        {   //Interface interativa inicial. Permite escolher o operador.
            Console.WriteLine("Entre com o Operador: +,-,*,/: ");
            //A informação é lida e convertida como dado Char, armazenando a infomrção acima na variável.
            op = Convert.ToChar(Console.ReadLine());
            //Interface interativa para escolher os números da conta.
            Console.Write("Entre com dois valores: ");
            //Cria um array de valores e lê ele. Split serve para pode separar a quantidade de valores e poder manter tudo em uma única linha. As linhas de num1 e num2 são os números dentro do array que serão armazenados nele, além de convertidos e float e lidos depois.
            string[] valores = Console.ReadLine().Split(' ');
            num1 = Convert.ToSingle(valores[0]);
            num2 = Convert.ToSingle(valores[1]);
            //Função semelhante ao "If", porem utilizada quando temos mais informações para lidarmos. "op" dará as informaões para o switch funcionar.
            switch (op)
            {   //Case pega uma parte específica dentro da variável para analisar.
                case '+':
                    //Aqui será escrito a equação solicitada. O $ serve para realizar a interpolação de uma string, ou seja, poermite que coloquemos variáveis dentro de uma string com "".
                    Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                    //Força a parada do switch quando uma de suas opções for realizada.
                    break;
                //Case pega uma parte específica dentro da variável para analisar.    
                case '-':
                 //Aqui será escrito a equação solicitada. O $ serve para realizar a interpolação de uma string, ou seja, poermite que coloquemos variáveis dentro de uma string com "".
                    Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                    //Força a parada do switch quando uma de suas opções for realizada.
                    break;
                //Case pega uma parte específica dentro da variável para analisar.
                case '*':
                 //Aqui será escrito a equação solicitada. O $ serve para realizar a interpolação de uma string, ou seja, poermite que coloquemos variáveis dentro de uma string com "".
                    Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                    //Força a parada do switch quando uma de suas opções for realizada.
                    break;
                //Case pega uma parte específica dentro da variável para analisar.
                case '/':
                    //Condicional usada para impedir que uma divisão por 0 aconteça.
                    if (num2 != 0)
                    {   //Conta de divisão.
                        Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
                    }
                    //Interface que surge caso tenha uma divisão por 0
                    else
                    {
                        Console.WriteLine("Erro: Divisão por zero não é permitida.");
                    }
                    //Força a parada do switch quando uma de suas opções for realizada.
                    break;
                //Mensagem específica que surge quando qualquer resposta além dos operadores são colocados.
                default:
                    Console.WriteLine("Operador errado, por favor insira o operador correto.");
                    break;
            }
            //Interface que surge após a conta.
            Console.Write("Deseja continuar? (s/n): ");
            //A resposta será lida e convertida para Char e armazenada na variável.
            resposta = Convert.ToChar(Console.ReadLine());
            //Segunda estrutura de repetição, aqui vamos descobrir se o programa irá recomeçar ou não. Devemos especificar todas as respostas possíveis.
            while (resposta != 's' && resposta != 'S' && resposta != 'n' && resposta != 'N')
            {   //Interface interativa que surge caso o usuário de alguma resposta diferente das definidas.
                Console.Write("Resposta inválida. Deseja continuar? (s/n): ");
                //Analisa e converte sua resposta, se estiver dentro das definidas pela variável dará continuidade.
                resposta = Convert.ToChar(Console.ReadLine());
            }
            //Definição das respostas positivas que farão o código começar de novo.
            continuar = (resposta == 's' || resposta == 'S');
        }
    }
}
