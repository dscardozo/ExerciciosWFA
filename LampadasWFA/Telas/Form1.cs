using LampadasWFA.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LampadasWFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            Comodo lamp = new Comodo();

            // Pegar oque o usuário digitou
            lamp.Potencia = Convert.ToDouble(TxtPotencia.Text);
            lamp.Largura = Convert.ToDouble(TxtLargura.Text);
            lamp.Comprimento = Convert.ToDouble(TxtComprimento.Text);

            // Processamento
            lamp.CalcularQtdLampadas();

            // Saída
            LblResultado.Text = lamp.MostrarResultado();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            TxtPotencia.Clear();
            TxtLargura.Clear();
            TxtComprimento.Clear();
            LblResultado.Text = string.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
