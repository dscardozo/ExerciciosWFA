using Escola_POO_BASE.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escola_POO_BASE.Telas
{

    /*TODO 3 - Desenhar uma tela para alterar a senha.
     * Esta tela deverá contar um campo para colocar a senha atual
     * a nova senha e confirmar a nova senha 
     * Também deverá conter um botão para confirmar e outro para cancelar
     */
    public partial class TelaPrincipal : Form
    {
        private Usuario _userLogado;
        private List<Usuario> _usuarios;
        private List<Aluno> _alunos;
        private List<Professor> _professores;

        public TelaPrincipal(Usuario usuarioLogado)
        {
            InitializeComponent();
            _userLogado = usuarioLogado;
            _alunos = new List<Aluno>();
            _professores = new List<Professor>();
            _usuarios = new List<Usuario>();
            //GpbTelaPrincipal.Text = "Professor : ";

            try
            {
                _alunos = Aluno.BuscarUsuariosA().ConvertAll(u => (Aluno)u);
                _professores = Professor.BuscarUsuariosP().ConvertAll(u => (Professor)u);
                _usuarios = Usuario.BuscarUsuariosP().ConvertAll(u => (Usuario)u);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,
                                   "Erro",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
            }
        }
        private void TelaPrincipal_Load(object sender, EventArgs e)
        {
            /* IF Ternario
                Caso o objeto _userLogado for do tipo Aluno, então armazenará na 
                propriedade Text a palavra "Aluno", senão "Professor"
            
            //TslPerfilLogado.Text = _userLogado is Aluno ? "Aluno" : "Professor";
             */
            if (_userLogado is Aluno)
            {
                TsiCadastros.Visible = false;
                TslPerfilLogado.Text = "Aluno";

            }
            else
            {
                TsiCadastros.Visible = true;
                TslPerfilLogado.Text = "Professor";

            }

            sairToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;

            TspNomeLogado.Text = _userLogado.Nome;
            TssEmailLogado.Text = _userLogado.Email;

            TssDataHora.Text = DateTime.Now.ToLongDateString() + "   " + DateTime.Now.ToLongTimeString();
            TmrRelogio.Interval = 1000;
            TmrRelogio.Enabled = true;

            /* TODO 1 - Identificar quem está logado, se é aluno ou professor
             * Se for o aluno, mostrar o aluno no toolstrip, assim como
             * o seu e-mail
            */
            /*TODO 2 - Descobrir como mostrar a data completa no toolStrip.
             */
        }

        private void TspAlterarSenha_Click(object sender, EventArgs e)
        {

            TelaAltSenha telaAltSenha = new TelaAltSenha(_userLogado);

            this.Hide();
            telaAltSenha.ShowDialog();
            this.Show();
        }
        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaCadastroAluno tlCadAluno = new TelaCadastroAluno(_userLogado);

            tlCadAluno.MdiParent = this;
            tlCadAluno.Show();
        }
        private void professorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaCadProfessor tlCadProf = new TelaCadProfessor(_userLogado);

            tlCadProf.MdiParent = this;

            tlCadProf.Show();
        }
        private void TmrRelogio_Tick(object sender, EventArgs e)
        {
            TssDataHora.Text = DateTime.Now.ToLongDateString() + "   " + DateTime.Now.ToLongTimeString();

            try
            {
                _alunos = Aluno.BuscarUsuariosA().ConvertAll(u => (Aluno)u);
                LblAtivos.Text = _alunos.Where(u => u.Ativo == true).Count().ToString();
                LblQtdAlunos.Text = _alunos.Count().ToString();
                LblRemovidos.Text = _alunos.Where(u => u.Ativo == false).Count().ToString();

                _professores = Professor.BuscarUsuariosP().ConvertAll(u => (Professor)u);
                LblProfAtivos.Text = _professores.Where(u => u.Ativo == true).Count().ToString();
                LblTotalProf.Text = _professores.Count().ToString();
                LblProfInativo.Text = _professores.Where(u => u.Ativo == false).Count().ToString();
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show($"Você realmente deseja Sair {_userLogado.Nome}?"
                              , "Sair"
                              , MessageBoxButtons.YesNo
                              , MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Close();
                }
                else
                    return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                                "Erro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
        private void trocarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show($"Você realmente Trocar de usuário {_userLogado.Nome}?"
                              , "Trocar"
                              , MessageBoxButtons.YesNo
                              , MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    TelaLogin tlLogin = new TelaLogin();
                    tlLogin.ShowDialog();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                                "Erro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    }
}
