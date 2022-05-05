using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomaHerancaExercicio.Modelo
{
    class Validacao : Propriedades
    {
        public Validacao(string numero1, string numero2)
        {
            this.numero1 = numero1;
            this.numero2 = numero2;
            Validar();
        }

        private void Validar()
        {
            this.mensagem = "";

            try
            {
                this.n1 = Convert.ToDouble(this.numero1);
                this.n2 = Convert.ToDouble(this.numero2);
            }
            catch (Exception)
            {
                this.mensagem = "Erro de conversão";
            }
        }
    }
}
