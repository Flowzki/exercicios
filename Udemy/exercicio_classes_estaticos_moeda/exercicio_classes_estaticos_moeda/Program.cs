using System;
using System.Globalization;

namespace exercicio_classes_estaticos_moeda
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com a cotação do dólar: ");
            double cot = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares vai comprar? ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double resultado = ConversorDeMoeda.DolarParaReal(cot, quantia);

            Console.WriteLine("Valor a ser pago em reais: " + resultado.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
