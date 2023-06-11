
using System.Security.Cryptography.X509Certificates;

Console.WriteLine("CALCULADORA\n");

Console.WriteLine("Qual operação deseja fazer?");
Console.WriteLine("1- adição");
Console.WriteLine("2- subtração");
Console.WriteLine("3- multiplicação");
Console.WriteLine("4- divisao\n");

int operacao = int.Parse(Console.ReadLine()!);


Console.WriteLine("CALCULADORA\n");

Console.Write("Digite o primeiro numero: ");
int num1 = int.Parse(Console.ReadLine()!);

Console.Write("Digite o segundo numero: ");
int num2 = int.Parse(Console.ReadLine()!);

int resultado;


switch (operacao)
{
    case 1: Soma();
        break;
   
    case 2:Subtracao(); 
        break;

    case 3: Multiplicacao(); 
        break;

    case 4: Divisao();
        break;
}


void Soma()
{
    resultado = num1 + num2;
    Console.WriteLine($"O Resultado é: {resultado}");
}

void Subtracao()
{
    resultado = num1 - num2;
    Console.WriteLine($"O Resultado é: {resultado}");
}

void Multiplicacao()
{
    resultado = num1 * num2;
    Console.WriteLine($"O Resultado é: {resultado}");
}

void Divisao()
{
    resultado = num1 / num2;
    Console.WriteLine($"O Resultado é: {resultado}");
}


    







