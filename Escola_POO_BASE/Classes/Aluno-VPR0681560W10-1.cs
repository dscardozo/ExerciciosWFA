using Escola_POO_BASE.Classes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Escola_POO_BASE.Telas
{

    public class Aluno : Usuario
    {


        #region Propriedades
        public DateTime DtMatricula { get; set; }
        #endregion

        #region Construtores
        public Aluno()
        {
        }

        public Aluno(int id, string nome, DateTime dtNascimento, DateTime dtMatricula, string email, string senha, bool ativo) : base(id, nome, dtNascimento, email, senha, ativo)
        {
            DtMatricula = dtMatricula;
        }
        #endregion


        #region Métodos
        public void Cadastrar(List<Usuario> usuarios)
        {
            string query = string.Format($"INSERT INTO Aluno VALUES ('{Nome}','{DtNascimento}','{DtMatricula}','{Email}','{Crypto.Sha256(Senha)}',1)");
            Conexao cn = new Conexao(query);
                       

            Aluno usuario = new Aluno();

            //Bloco - try..catch
            try
            {
                cn.AbrirConexao();
                cn.comando.ExecuteNonQuery(); // Para o Select ExecuteReader()

                usuarios.Add(this);                

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
        #endregion

}
