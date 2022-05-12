using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroPrimoExercicio.Modelo
{
    internal class Validacao : absPropriedades
    {
        public Validacao(string numero) : base(numero)
        {
            Validar();
        }

        private void Validar()
        {
            this.Mensagem = "";

            try
            {
                this.Num = (int)Convert.ToInt64(this.Numero); 
            }
            catch (Exception)
            {

                this.Mensagem = "Número inválido";
            }
        }
    }
}
