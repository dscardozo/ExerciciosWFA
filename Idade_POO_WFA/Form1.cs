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
                                     ,Convert.ToInt32(TxtAnos.Text)
                                     ,Convert.ToInt32(TxtMes.Text)
                                     ,Convert.ToInt32(TxtDia.Text));

            int TotalDias = pessoa.CalcularDias();

            LblResult.Text = $"{TotalDias}";

        }

        

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            TxtNome.Clear();
            TxtAnos.Clear();
            TxtDia.Clear();
            LblResult.Text = string.Empty;
        }
    }
}
