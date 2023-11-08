// See https://aka.ms/new-console-template for more information
using CalculadoraPrograma;
using System.Diagnostics.CodeAnalysis;

[ExcludeFromCodeCoverage]
class Program
{
    private static void Main(string[] args)
    {
        CalculadoraExecucao calculadora = new CalculadoraExecucao(DateTime.Now);

        while (true)
        {
            Console.WriteLine("==========Calculadora==========");
            Console.WriteLine();
            Console.WriteLine("Digite a opção desejada");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Histórico");
            Console.WriteLine("6 - Encerrar");

            string? opcao = Console.ReadLine();
            Console.WriteLine();

            switch (opcao)
            {
                case "1":
                    var valores = calculadora.ColetarValores();
                    var resultado = calculadora.Somar(valores.Item1, valores.Item2);
                    Console.WriteLine($"O resultado é {resultado}");
                    Console.WriteLine();
                    break;

                case "2":
                    valores = calculadora.ColetarValores();
                    resultado = calculadora.Subtrair(valores.Item1, valores.Item2);
                    Console.WriteLine($"O resultado é {resultado}");
                    Console.WriteLine();
                    break;

                case "3":
                    valores = calculadora.ColetarValores();
                    resultado = calculadora.Multiplicar(valores.Item1, valores.Item2);
                    Console.WriteLine($"O resultado é {resultado}");
                    Console.WriteLine();
                    break;

                case "4":
                    valores = calculadora.ColetarValores();
                    resultado = calculadora.Dividir(valores.Item1, valores.Item2);
                    Console.WriteLine($"O resultado é {resultado}");
                    Console.WriteLine();
                    break;

                case "5":
                    var historico = calculadora.Historico();
                    foreach (var operacao in historico)
                    {
                        Console.WriteLine($"{operacao}");
                    }
                    Console.WriteLine();
                    break;

                case "6":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Digite uma opção válida");
                    Console.WriteLine();
                    break;
            }
        }
    }
}