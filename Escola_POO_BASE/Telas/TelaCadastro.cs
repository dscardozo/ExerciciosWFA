using Escola_POO_BASE.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escola_POO_BASE.Telas
{
    public partial class TelaCadastro : Form
    {
        public TelaCadastro()
        {
            InitializeComponent();
        }

        private void BtnCadCadastrar_Click(object sender, EventArgs e)
        {
            if (RdbCadastroAluno.Checked)
            {
                Cadastro cadAluno = new Cadastro();
                cadAluno.Nome = TxtCadNome.Text;
                cadAluno.DtNascimento = Convert.ToDateTime(TxtCadNascimento.Text);
                cadAluno.Email = TxtCadEmail.Text;
                if (TxtCadSenha1.Text == TxtCadSenha2.Text)
                {
                    cadAluno.Senha = TxtCadSenha1.Text;
                }
                else
                {
                    MessageBox.Show("A senhas não conferem, favor digitar a mesma senha!!!"
                                    , "Senha"
                                   , MessageBoxButtons.OK
                                   , MessageBoxIcon.Error);
                }
                cadAluno.Ativo = true;

            }
            else
            {
                Cadastro cadProf = new Cadastro();
                cadProf.Nome = TxtCadNome.Text;
                cadProf.DtNascimento = Convert.ToDateTime(TxtCadNascimento.Text);
                cadProf.Email = TxtCadEmail.Text;
                if (TxtCadSenha1.Text == TxtCadSenha2.Text)
                {
                    cadProf.Senha = TxtCadSenha1.Text;
                }
                else
                {
                    MessageBox.Show("A senhas não conferem, favor digitar a mesma senha!!!"
                                    , "Senha"
                                   , MessageBoxButtons.OK
                                   , MessageBoxIcon.Error);
                }
                cadProf.Ativo = true;
            }
            
            


            TelaLogin tlLogin = new TelaLogin();
            tlLogin.ShowDialog();



        }




        private void BtnCadLimpar_Click(object sender, EventArgs e)
        {
            TxtCadNome.Clear();
            TxtCadNascimento.Clear();
            TxtCadEmail.Clear();
            TxtCadSenha1.Clear();
            TxtCadSenha2.Clear();
        }

        private void CkbCadSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (CkbCadSenha.Checked)
            {
                TxtCadSenha1.UseSystemPasswordChar = false;
                TxtCadSenha2.UseSystemPasswordChar = false;
            }
            else
            {
                TxtCadSenha1.UseSystemPasswordChar = true;
                TxtCadSenha2.UseSystemPasswordChar = true;
            }
        }

       
    }
   
}
