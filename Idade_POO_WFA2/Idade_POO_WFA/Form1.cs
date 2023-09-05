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
                double anos = Convert.ToDouble(TxtAnos.Text);
                double meses = Convert.ToDouble(TxtMeses.Text);
                double dias = Convert.ToDouble(TxtDias.Text);

                double somaAnosEmDias = anos * 365;
                double somaMesesEmDias = meses * 30;
                double totalEmDias = somaAnosEmDias + somaMesesEmDias + dias;

                LblRespEmDias.Text = totalEmDias.ToString();
            }
            else
            {
                int somDias = Convert.ToInt32(TxtSomDias.Text);
                int anos = somDias / 365;
                int restoDias = somDias % 365;
                int meses = restoDias / 30;
                restoDias = restoDias % 30;
                if (meses == 12)
                {
                    meses -= 1;
                    restoDias += 30;
                }
                
                LblRespAnos.Text = anos.ToString();
                LblRespMeses.Text = meses.ToString();
                LblRespDias.Text = restoDias.ToString();
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
