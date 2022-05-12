using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomaHerancaExercicio
{
    using SomaHerancaExercicio.Modelo;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSomar_Click_1(object sender, EventArgs e)
        {
            Controle controle = new Controle(txbNumero1.Text, txbNumero2.Text);

            if(controle.mensagem.Equals(""))
            {
                lblResultado.Text = controle.Resultado;
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }
        }

        private void txbNumero1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbNumero2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }
    }
}
