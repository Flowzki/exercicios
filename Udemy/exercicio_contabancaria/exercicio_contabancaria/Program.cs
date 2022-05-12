using System;
using System.Globalization;

namespace exercicio_contabancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria contabancaria;

            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta ");
            string nome = Console.ReadLine();

            Console.WriteLine("Haverá depósito inicial (s/n)?");
            char opcao = char.Parse(Console.ReadLine());

            if(opcao == 's')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                contabancaria = new ContaBancaria(numero, nome, saldo);
            }
            else
            {
                contabancaria = new ContaBancaria(numero, nome);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(contabancaria);

            Console.WriteLine();
            Console.Write("Entre com um valor para depósito: ");
            double quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            contabancaria.Deposito(quantidade);

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(contabancaria);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            contabancaria.Saque(quantidade);

            Console.WriteLine("Dados da conta atualizados");
            Console.WriteLine(contabancaria);
        }
    }
}
