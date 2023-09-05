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
    public partial class TelaAltSenha : Form
    {
        private Usuario _userLogado;

        // Exigir que a tela tenha o usuário logado
        public TelaAltSenha(Usuario userLogado)
        {
            InitializeComponent();
            _userLogado = userLogado;
        }


        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                _userLogado.AlterarSenha(TxtSenhaAtual.Text
                                        , TxtNovaSenha.Text
                                        , TxtRepeteSenha.Text
                                        );
                Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            TxtSenhaAtual.Clear();
            TxtNovaSenha.Clear();
            TxtRepeteSenha.Clear();
            //Close();
        }

        private void TxtSenhaAtual_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                BtnConfirmar.PerformClick();
            }
        }

        private void TxtNovaSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                BtnConfirmar.PerformClick();
            }
        }

        private void TxtRepeteSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                BtnConfirmar.PerformClick();
            }
        }

        private void CkbVisualizar_CheckedChanged(object sender, EventArgs e)
        {
            if (CkbVisualizar.Checked)
            { 
                TxtSenhaAtual.UseSystemPasswordChar = false;
                TxtNovaSenha.UseSystemPasswordChar = false;
                TxtRepeteSenha.UseSystemPasswordChar = false;
            }
            else
            { 
                TxtSenhaAtual.UseSystemPasswordChar = true;
                TxtNovaSenha.UseSystemPasswordChar = true;
                TxtRepeteSenha.UseSystemPasswordChar = true;
            }
        }
    }
}
