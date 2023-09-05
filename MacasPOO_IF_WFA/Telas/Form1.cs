using MacasPOO_IF_WFA.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MacasPOO_IF_WFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto(Convert.ToInt32(TxtNumMacas.Text));

            produto.ValorTotal();
            produto.MostrarResultado();

            LblResultado.Text = produto.MostrarResultado();

            
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            TxtNumMacas.Clear();

            LblResultado.Text = string.Empty;

        }
    }

}
