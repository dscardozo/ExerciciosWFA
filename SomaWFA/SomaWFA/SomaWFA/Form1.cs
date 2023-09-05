using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomaWFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            //Pegar o que o usuário digitou nas TextBox's.
            double valor1, valor2;

            valor1 = Convert.ToDouble(TxtValor1.Text);
            valor2 = Convert.ToDouble(TxtValor2.Text);

            double result = valor1 + valor2;

            LblResultado.Text = $"Resultado: {result}";
        }
    }
}
