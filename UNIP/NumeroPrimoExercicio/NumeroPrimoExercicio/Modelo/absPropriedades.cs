using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroPrimoExercicio.Modelo
{
    internal abstract class absPropriedades
    {
        private string mensagem;
        private int num;
        private string numero;
        
        public string Mensagem
        {
            get { return mensagem; }
            set { mensagem = value; }
        }

        public int Num
        {
            get { return num; }
            set { num = value; }
        }

        public string Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public absPropriedades(int num)
        {
            this.num = num;
        }

        public absPropriedades(string numero)
        {
            this.numero = numero;
        }


    }
}
