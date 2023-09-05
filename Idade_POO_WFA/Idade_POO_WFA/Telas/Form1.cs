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
            if (RdbAnosMesesDias.Checked)
            {
                Idade ida = new Idade(Convert.ToInt32(TxtAnos.Text)
                                    , Convert.ToInt32(TxtMeses.Text)
                                    , Convert.ToInt32(TxtDias.Text));


                LblRespEmDias.Text = ida.RetornaTempoEmDias();
            }
            else
            {
                Idade ida = new Idade(Convert.ToInt32(TxtSomDias.Text));

                ida.CalculaTempoEmAMD();

                LblRespAnos.Text = ida.Anos.ToString();
                LblRespMeses.Text = ida.Meses.ToString();
                LblRespDias.Text = ida.Dias.ToString();
            }
        }

        private void RdbSomDias_CheckedChanged(object sender, EventArgs e)
        {
            if (RdbSomDias.Checked)
            {
                LblRespEmDias.Visible = false;
                TxtSomDias.Visible = true;

                LblRespAnos.Visible = true;
                LblRespMeses.Visible = true;
                LblRespDias.Visible = true;
                TxtAnos.Visible = false;
                TxtMeses.Visible = false;
                TxtDias.Visible = false;
            }
        }

        private void RdbAnosMesesDias_CheckedChanged(object sender, EventArgs e)
        {
            if (RdbAnosMesesDias.Checked)
            {
                LblRespEmDias.Visible = true;
                TxtSomDias.Visible = false;

                LblRespAnos.Visible = false;
                LblRespMeses.Visible = false;
                LblRespDias.Visible = false;
                TxtAnos.Visible = true;
                TxtMeses.Visible = true;
                TxtDias.Visible = true;
            }
        }
    }
}
