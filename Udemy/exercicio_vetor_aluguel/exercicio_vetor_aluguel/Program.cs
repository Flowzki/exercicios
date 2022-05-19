using System;

namespace exercicio_vetor_aluguel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many rooms will be rented? ");
            int quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Aluguel[] aluguel = new Aluguel[10];

            for(int i = 1; i <= quantidade; i++)
            {
                Console.WriteLine("Rent #" + i);

                Console.Write("Name: ");
                string nome = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Room: ");
                int quarto = int.Parse(Console.ReadLine());

                aluguel[quarto] = new Aluguel(nome, email, quarto);
                Console.WriteLine();
            }

            Console.WriteLine("Busy rooms:");
            for (int i = 0; i < 10; i++)
            {
                if (aluguel[i] != null)
                {
                    Console.WriteLine(aluguel[i].ToString());
                }
            }
        }
    }
}
