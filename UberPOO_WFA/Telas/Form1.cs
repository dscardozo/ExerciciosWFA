using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UberPOO_WFA.Classes;

namespace UberPOO_WFA
{
    public partial class UberForm : Form
    {
        public UberForm()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            Uber uber = new Uber(Convert.ToDouble(TxtKmInicio.Text)
                                , Convert.ToDouble(TxtKmFimDia.Text)
                                , Convert.ToDouble(TxtConsumoCombustivel.Text)
                                , Convert.ToDouble(TxtValorFimDia.Text));

            uber.CalcularKm();


            LblResultado.Text = uber.MostrarResultado();


        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            TxtKmInicio.Clear();
            TxtKmFimDia.Clear();
            TxtConsumoCombustivel.Clear();
            TxtValorFimDia.Clear();
            LblResultado.Text = string.Empty;  
        }

        
    }
}
