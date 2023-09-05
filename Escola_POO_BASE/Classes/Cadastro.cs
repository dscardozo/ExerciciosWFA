using Escola_POO_BASE.Telas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escola_POO_BASE.Classes
{
    internal class Cadastro
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

        public Cadastro()
        {

        }

        public Cadastro(int id, string nome, DateTime dtNascimento, string email, string senha, bool ativo)
        {
            Id = id;
            Nome = nome ?? throw new ArgumentNullException(nameof(nome));
            DtNascimento = dtNascimento;
            Email = email ?? throw new ArgumentNullException(nameof(email));
            Senha = senha ?? throw new ArgumentNullException(nameof(senha));
            Ativo = ativo;
        }



        #endregion

        #region Métodos

        public static Cadastro RealizarLogin(string email, string senha, List<Cadastro> novoCadastros)
        {
            Cadastro cadastro = novoCadastros.Find(a => a.Email == email);
            novoCadastros.Find(a => a.Senha == senha);
            novoCadastros.Find(a => a.Ativo == true);
            if (novoCadastros == null)
            {
                // Tratar erro
                MessageBox.Show("Login de professor negado. Verifique o e-mail e a senha."
                               , "Login"
                               , MessageBoxButtons.OK
                               , MessageBoxIcon.Error);
            }
            else
            {
                TelaPrincipal tlPrincipal = new TelaPrincipal();
                tlPrincipal.ShowDialog();
            }
            return cadastro;
        }

        public static List<Cadastro> GerarCadastro()
        {
            List<Cadastro> novoCadastro = new List<Cadastro>();

            Cadastro novoCad1 = new Cadastro();
            novoCadastro.Add(novoCad1);

            TelaCadastro tlCadastro = new TelaCadastro();
            tlCadastro.ShowDialog();

            return novoCadastro;

        }

        #endregion
    }
}
