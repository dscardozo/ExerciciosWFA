using Escola_POO_BASE;
using Escola_POO_BASE.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Escola_POO_BASE.Telas
{
    public partial class TelaLogin : Form
    {
        //Declarar objetos na classe o torna acessível
        //por todos os métodos da classe.                   
        public TelaLogin()
        {
            InitializeComponent();                  
            toolStripStatusLabel1.Text = "Conectando, aguarde . . . ";
        }
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            
            try
            {
                               
                Usuario userLogado = Usuario.RealizarLogin(TxtEmail.Text, TxtSenha.Text, RdbAluno.Checked);
                toolStripStatusLabel1.Text = "Conectado!";

                if (userLogado.Senha == Crypto.Sha256("123"))
                {

                    TelaAltSenha telaAltSenha = new TelaAltSenha(userLogado);
                    
                    telaAltSenha.ShowDialog();
                    TxtSenha.Clear();
                    TxtSenha.Focus(); // já deixa selecionado
                    
                }
                else
                {
                    TelaPrincipal tlPrincipal = new TelaPrincipal(userLogado);

                    
                    tlPrincipal.ShowDialog();
                    //this.Show();
                    //TxtSenha.Clear();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = "Falhou";
                MessageBox.Show(ex.Message
                              , "Projeto Escola"
                              , MessageBoxButtons.OK
                              , MessageBoxIcon.Error);
            }
        }
        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            TxtEmail.Clear();
            TxtSenha.Clear();
        }
        private void ChkVisualizarSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkVisualizarSenha.Checked)

                TxtSenha.UseSystemPasswordChar = false;

            else

                TxtSenha.UseSystemPasswordChar = true;
        }

        private void TxtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                BtnLogin.PerformClick();
            }
        }

        private void TxtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                BtnLogin.PerformClick();
            }
        }

        private void RdbProfessor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                BtnLogin.PerformClick();
            }
        }

        private void RdbAluno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                BtnLogin.PerformClick();
            }
        }
    }
}


