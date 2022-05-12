using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace exercicio_contabancaria
{
    class ContaBancaria
    {
        public int NumeroConta { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numeroconta, string nome)
        {
            NumeroConta = numeroconta;
            Nome = nome;
        }

        public ContaBancaria(int numeroConta, string nome, double saldo) : this(numeroConta, nome)
        {
            Deposito(saldo);
        }

        public void Deposito(double quantidade)
        {
            Saldo += quantidade;
        }

        public void Saque(double quantidade)
        {
            Saldo -= quantidade;
            Saldo -= 5;
        }

        public override string ToString()
        {
                return "Conta: " + NumeroConta + ", Titular: " + Nome + ", Saldo: $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture); 
        }
    }
}