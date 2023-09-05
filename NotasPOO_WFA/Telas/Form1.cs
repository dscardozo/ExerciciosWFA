using NotasPOO_WFA.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotasPOO_WFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {

            string nomeAluno = TxtNomeAluno.Text;

            double nota1 = double.Parse(TxtNota1.Text);
            double nota2 = double.Parse(TxtNota2.Text);
            double nota3;

            
            if (String.IsNullOrWhiteSpace(Convert.ToString(TxtNota3.Text)))
            {
                nota3 = double.NaN; 
            }
            else
            {
                nota3 = double.Parse(Convert.ToString(TxtNota3.Text));
            }

            Aluno aluno = new Aluno(nota1, nota2, nota3, nomeAluno);
            double media = aluno.CalcularMedia();

            string status = aluno.MostrarResultado();

            LblResultado.Text = $"Aluno: {nomeAluno}\nMédia: {media:F2}\nSituação: {status}";
        }

        private void BtnLimpar_Click(object sender, EventArgs e) 
        {
            TxtNota1.Clear();
            TxtNota2.Clear();
            TxtNota3.Clear();
            TxtNomeAluno.Clear();
            LblResultado.Text = string.Empty; ;    
        }
    }
}
