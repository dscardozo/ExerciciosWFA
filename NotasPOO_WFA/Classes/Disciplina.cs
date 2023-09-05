using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotasPOO_WFA.Classes
{
    internal class Disciplina
    {
        #region Propriedades

        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Nota3 { get; set; }
        public double Soma { get; set; }
        public double Media { get; set; }
        public string Status { get; set; }
        public string NomeAluno { get; set; }   


        #endregion

        #region Construtores

        public Disciplina()
        {
            
        }

        public Disciplina(double nota1, double nota2, double nota3, string nomeAluno)
        {
            Nota1 = nota1;
            Nota2 = nota2;
            Nota3 = nota3;
            NomeAluno= nomeAluno;            
        }
        #endregion

        #region Métodos

        public void CalcularMedia()
        {
            if (Nota1 < Nota2 && Nota2 < Nota3)
            {
                Soma = Nota2 + Nota3;
            }else 
            if (Nota1 > Nota2 && Nota2 > Nota3) 
            {
                Soma = Nota1 + Nota2;
            }else 
            if(Nota2 < Nota3 && Nota2 < Nota1)
            {
                Soma = Nota2 + Nota3;
            }


            Media = Soma / 2;                                 
        }

        public string MostrarResultado()
        {
            if (Media >= 6)
            {
                Status = $"APROVADO!!";
            }else
            if (Media < 3)
            {
                Status = $"REPROVADO!!";
            }
            else
            {
                Status = $"EXAME";
            }

            string frase;
            frase = $"{NomeAluno} sua média foi de {Convert.ToString(Media)} e vc foi {Status}";
            return frase;
        }

        #endregion

        
    }
}
