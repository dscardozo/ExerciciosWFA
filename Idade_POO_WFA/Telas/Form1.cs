using Idade_POO_WFA.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Idade_POO_WFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa(TxtNome.Text
                                       ,Convert.ToInt32(TxtIdade.Text)
                                       ,Convert.ToInt32(TxtMeses.Text)
                                       ,Convert.ToInt32(TxtDias.Text));
            pessoa.RetornaDias();

            LblResultado.Text = $"{pessoa.Nome}, você tem {pessoa.RetornaDias()} dias de vida";
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            TxtNome.Clear();
            TxtIdade.Clear();
            TxtMeses.Clear();
            TxtDias.Clear();
            LblResultado.Text = string.Empty;
            LblResultadoInverso.Text = string.Empty;
        }

        private void BtnCalculoInverso_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa(TxtNome.Text
                                       , Convert.ToInt32(TxtIdade.Text)
                                       , Convert.ToInt32(TxtMeses.Text)
                                       , Convert.ToInt32(TxtDias.Text));


            pessoa.MostrarResultadoInverso();

                                 

            LblResultadoInverso.Text = $"{pessoa.Nome}, você tem {pessoa.AnosInverso} anos, {pessoa.MesesInverso} meses e {pessoa.DiasInverso} dias.";
        }
    }
}
