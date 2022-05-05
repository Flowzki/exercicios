using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomaHerancaExercicio.Modelo
{
    class Controle : Propriedades
    {
        public Controle(string numero1, string numero2)
        {
            this.numero1 = numero1;
            this.numero2 = numero2;
            Executar();
        }

        private void Executar()
        {
            this.mensagem = "";
            Validacao validacao = new Validacao(this.numero2, this.numero2);

            if (validacao.mensagem.Equals(""))
            {
                Calculos calculos = new Calculos(validacao.n1, validacao.n2);
                this.resultado = calculos.res.ToString();
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
        }
    }
}
