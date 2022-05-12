using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace exercicio_classes_estaticos_moeda
{
    class ConversorDeMoeda
    {
        public static double IOF = 6.0;

        public static double DolarParaReal(double cotacao, double quantia)
        {
            double total = cotacao * quantia;
            return total + total * IOF / 100.0;
        }
    }
}
