//Biblioteca padrão.
using System;
//Classe do código principal. Ele guarda as informações dos métodos usados para que o código funcione.
class Program
{   //Declaração da variável que permite realisar a adição dos números.
    float Soma(float a, float b)
    {   //Método da classe. Aqui já definimos o tipo de resultado, como vamos obtê-lo e o seu retorno.
        float Resultado;
        Resultado = a + b;
        return Resultado;
    }
    //Declaração da variável que permite realizar a subtração dos números.
    float Subt(float a, float b)
    {   //Método da classe. Aqui já definimos o tipo de resultado, como vamos obtê-lo e o seu retorno.
        float Resultado;
        Resultado = a - b;
        return Resultado;
    }
    //Declaração da variável que permite realizar a multiplicação dos números.
    float Multi(float a, float b)
    {   //Método da classe. Aqui já definimos o tipo de resultado, como vamos obtê-lo e o seu retorno.
        float Resultado;
        Resultado = a * b;
        return Resultado;
    }
    //Declaração da variável que permite realizar a divisão dos números
    float Divi(float a, float b)
    {   //Método da classe. Aqui já definimos o tipo de resultado, como vamos obtê-lo e o seu retorno.
        float Resultado;
        Resultado = a / b;
        return Resultado;
    }
    //Corpo principal do código.
    static void Main()
    {   //Declaração das variáve
        float a, b;
        //Interface interativa para escrever os números.
        Console.WriteLine("Informe os números:");
        //Forma de armazenar as respostas em cada variável respectivamente.
        a = float.Parse(Console.ReadLine());
        b = float.Parse(Console.ReadLine());
        //Aqui instanciamos a classe que criamos e usamos seus métodos feitos.
        Program programa = new Program();
        //Usando os métodos feitos dentro da classe nós teremos a resposta respectiva de cada operador.
        Console.WriteLine("O valor da soma é: " + programa.Soma(a, b));
        Console.WriteLine("O valor da subtração é: " + programa.Subt(a, b));
        Console.WriteLine("O valor da multiplicação é: " + programa.Multi(a, b));
        Console.WriteLine("O valor da divisão é: " + programa.Divi(a, b));
    }
}
