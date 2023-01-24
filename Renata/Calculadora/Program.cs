using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {
            string operacao = "";
            double resultado = 0;
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Mentoria Dev - Calculadora");

            do
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Qual operação deseja fazer?");
                Console.WriteLine("1 - Soma");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Divisão");
                Console.WriteLine("4 - Multiplicação");
                Console.WriteLine("5 - Sair");
                Console.WriteLine("---------------------------------");
                operacao = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine("Digite o primeiro número");
                int n1 = int.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("Digite o segundo número");
                int n2 = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (operacao)
                {
                    case "1":
                        if (operacao == "1")
                        {
                            resultado = Soma(n1, n2);
                        }
                        Console.WriteLine($"O valor final é: {resultado}");
                        Console.WriteLine();
                        break;
                    case "2":
                        if (operacao == "2")
                        {
                            resultado = Subtracao(n1, n2);
                        }
                        Console.WriteLine($"O valor final é: {resultado}");
                        Console.WriteLine();
                        break;
                    case "3":
                        if (operacao == "3")
                        {
                            resultado = Divisao(n1, n2);
                        }
                        Console.WriteLine($"O valor final é: {resultado}");
                        Console.WriteLine();
                        break;
                    case "4":
                        if (operacao == "4")
                        {
                            resultado = Multiplicacao(n1, n2);
                        }
                        Console.WriteLine($"O valor final é: {resultado}");
                        Console.WriteLine();
                        break;
                    default:
                        Console.WriteLine("Calculadora encerrada");
                        break;
                }
            } while (operacao != "5");
        }

        static int Soma(int a, int b)
        {
            int resultado = a + b;
            return resultado;
        }

        static int Subtracao(int a, int b)
        {
            int resultado = a - b;
            return resultado;
        }

        static int Divisao(int a, int b)
        {
            int resultado = a / b;
            return resultado;
        }

        static int Multiplicacao(int a, int b)
        {
            int resultado = a * b;
            return resultado;
        }
    }
}



