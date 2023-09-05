using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CirculoWFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            //Pegar o raio que o usuário digitou
            double raio = Convert.ToDouble(TxtRaio.Text);

            //Aplicar a fórmula da área do círculo
            double area = Math.PI * Math.Pow(raio, 2);

            //Escrever a área na label
            LblArea.Text = $"Área: {area:F2}";
        }
    }
}
