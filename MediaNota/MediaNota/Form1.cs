using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaNota
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalcularMedia_Click(object sender, EventArgs e)
        {
            string nomeAluno = TxtNomeAluno.Text;

            double nota1 = double.Parse(TxtNota1.Text);
            double nota2 = double.Parse(TxtNota2.Text);
            double nota3;
            double media;

           
            if (String.IsNullOrWhiteSpace(TxtNota3.Text))
            {
                
                nota3 = double.NaN;
                 
            }
            else
            {
                nota3 = double.Parse(TxtNota3.Text);
            }

            double menorNota = Math.Min(Math.Min(nota1, nota2), nota3);
            media = (nota1 + nota2 + nota3 - menorNota) / 2;

            string situacao;

            if (media >= 6)
            {
                situacao = "Aprovado";
            }
            else if (media >= 3)
            {
                situacao = "Exame";
            }
            else
            {
                situacao = "Reprovado";
            }

            LblResultado.Text = $"Aluno: {nomeAluno}\nMédia: {media:F2}\nSituação: {situacao}";
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            TxtNota1.Clear();
            TxtNota2.Clear();
            TxtNota3.Clear();
            TxtNomeAluno.Clear();
            LblResultado.Text = string.Empty;
        }
    }
}

