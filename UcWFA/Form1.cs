using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UcWFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int qtdCargaHoraria = Convert.ToInt32(txtUC.Text);
            double num = 3.5;
            int numMax = Convert.ToInt32(Math.Floor(qtdCargaHoraria / num) * 0.25);

            lblResult.Text = $"A quantidade de faltas para a carga horária de {qtdCargaHoraria} horas é de: {numMax} faltas";           
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtUC.Clear();
            lblResult.Text = string.Empty;
        }
    }
}
