using MentoriaDev;

Console.WriteLine("###############################");
Console.WriteLine("Mentoria Dev - Calculadora");
Console.WriteLine("###############################");

int opcao = 0;

while (opcao != 5)
{
    Console.WriteLine("");
    Console.WriteLine("-------------------------------");
    Console.WriteLine("Qual a operação deseja fazer?");
    Console.WriteLine(" 1 - Soma ");
    Console.WriteLine(" 2 - Substração ");
    Console.WriteLine(" 3 - Divisão ");
    Console.WriteLine(" 4 - Multiplicação ");
    Console.WriteLine(" 5 - Sair ");
    Console.WriteLine("-------------------------------");

    bool isInteger = Int32.TryParse(Console.ReadLine(), out opcao);

    if (isInteger && opcao != 5)
    {
        Console.WriteLine("");
        Console.WriteLine("Digite o primeiro número?");
        var num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("");
        Console.WriteLine("Digite o segundo número?");
        var num2 = Convert.ToInt32(Console.ReadLine());

        Calculadora calc = new Calculadora(num1, num2, (TiposOperacao)opcao);

        Console.WriteLine("");
        Console.WriteLine($"O valor final é: {calc.Calcular()} ");
    }
}

Console.WriteLine("-------------------------------");
Console.WriteLine("Saindo da calculadora");
var opc = Console.ReadLine();