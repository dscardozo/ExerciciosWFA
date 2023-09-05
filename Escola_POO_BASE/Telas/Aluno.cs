using System;
using System.Collections.Generic;

namespace Escola_POO_BASE.Telas
{
    internal class Aluno
    {

        #region Propriedades


        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DtNascimento { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public bool Ativo { get; set; }

        #endregion

        #region Construtores
        public Aluno()
        {

        }

        public Aluno(int id, string nome, DateTime dtNascimento, string email, string senha, bool ativo)
        {
            Id = id;
            Nome = nome;
            DtNascimento = dtNascimento;
            Email = email;
            Senha = senha;
            Ativo = ativo;
        }


        #endregion

        #region Métodos

        public static Aluno RealizarLogin(string email, string senha, List<Aluno> alunos)
        {
            Aluno aluno = alunos.Find(a => a.Email == email);
            if (aluno == null)
            {
                // Tratar erro 
            }
            else
            {
                
            }

            return aluno;
        }

        public static List<Aluno> GerarAlunos()
        {
            List<Aluno> alunos = new List<Aluno>();
            Aluno aluno1 = new Aluno(1, "Danilo", Convert.ToDateTime("28/08/1978"), "dscardozo@hotmail.com", "280878", true);
            Aluno aluno2 = new Aluno(2, "Elaine", Convert.ToDateTime("07/03/1988"), "elainesantos@hotmail.com", "070388", true);
            Aluno aluno3 = new Aluno(3, "Giulia", Convert.ToDateTime("09/06/2009"), "giuliakaroline@hotmail.com", "190609", true);

            alunos.Add(aluno1);
            alunos.Add(aluno2);
            alunos.Add(aluno3);


            return alunos;
        }

        #endregion
    }
}
