using System;
using System.Globalization;

namespace exercicio_classe_perimetro
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo dados;
            dados = new Retangulo();

            Console.WriteLine("Entre a largura e a altura do retângulo: ");
            dados.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            dados.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("AREA = " + dados.Area().ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine();
            Console.WriteLine("PERIMETRO = " + dados.Perimetro().ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine();
            Console.WriteLine("DIAGONAL = " + dados.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
