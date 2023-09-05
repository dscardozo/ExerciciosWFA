using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotasPOO_WFA.Classes
{
    internal class Aluno
    {
        #region Propriedades
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Nota3 { get; set; }
        public string NomeAluno { get; set; }
        #endregion

        #region Construtores
        public Aluno()
        {
            
        }

        public Aluno(double nota1, double nota2, double nota3, string nomeAluno)
        {
            Nota1 = nota1;
            Nota2 = nota2;
            Nota3 = nota3;
            NomeAluno = nomeAluno;
        }


        #endregion

        #region Métodos

        

        public double CalcularMedia()
        {
            double menorNota = Math.Min(Math.Min(Nota1, Nota2), Nota3);
            double media;

            if (double.IsNaN(Nota3))
            {
                media = (Nota1 + Nota2) / 2;
            }
            else
            {
                media = (Nota1 + Nota2 + Nota3 - menorNota) / 2;
            }

            return media;
        }

        public string MostrarResultado()
        {
            double media = CalcularMedia();

            if (media >= 6)
            {
                return "Aprovado";
            }
            else if (media >= 3)
            {
                return "Exame";
            }
            else
            {
                return "Reprovado";
            }
        }
        #endregion
    }
}
