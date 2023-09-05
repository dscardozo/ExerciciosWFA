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

namespace Escola_POO_BASE.Telas
{
    public partial class TelaCadastroAluno : Form
    {
        private List<Usuario> _usuarios;
        private Professor _userLogado;

        public TelaCadastroAluno(List<Usuario> usuarios, Usuario userLogado)
        {
            InitializeComponent();
            _usuarios = usuarios;
            _userLogado = (Professor)userLogado;
        }

        // Método de formulário que ira configurar o DgvUsuarios

        private void ConfiguraDgvUsuarios()
        {
            // Criação das colunas no DgvUsuarios
            DgvUsuarios.Columns.Add("Id","Matrícula");
            DgvUsuarios.Columns.Add("Nome","Nome");
            DgvUsuarios.Columns.Add("Dtnascimento","Data Nascimento");
            DgvUsuarios.Columns.Add("DtMatricula","Data Matrícula");
            DgvUsuarios.Columns.Add("Email","E-mail");
            DgvUsuarios.Columns.Add("Ativo","Ativo");

            //Configuração dos alinhamentos de cada coluna no DgvUsuarios
            DgvUsuarios.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvUsuarios.Columns["Nome"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DgvUsuarios.Columns["Dtnascimento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DgvUsuarios.Columns["DtMatricula"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DgvUsuarios.Columns["Email"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DgvUsuarios.Columns["Ativo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            //Configuração dos tamanhos de cada coluna do DgvUsuarios
            DgvUsuarios.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            DgvUsuarios.Columns["Nome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DgvUsuarios.Columns["DtNascimento"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            DgvUsuarios.Columns["DtMatricula"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            DgvUsuarios.Columns["Email"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DgvUsuarios.Columns["Ativo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;



        }

        private void BtnCadastrarTlCad_Click(object sender, EventArgs e)
        {
            
            if (_userLogado.NivelAcesso != 1)
            {
                BtnCadastrarTlCad.Enabled = false;
                MessageBox.Show("Seu Nivel de acesso não permite cadastrar alunos",
                                "Erro de permissão",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }
            
            
            try
            {
                if (TxtEmailTlCad.Text != "" && TxtNomeTlCad.Text != "")
                {
                    Aluno aluno = new Aluno(0, TxtNomeTlCad.Text, DtpDtNascimentoTlCad.Value, DtpDtMatriculaTlCad.Value, TxtEmailTlCad.Text, "123", true);
                    aluno.Cadastrar(_usuarios);
                    MessageBox.Show($"Aluno(a) {aluno.Nome} cadastrado com sucesso!!",
                                    "Cadastro",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Os campos Nome e E-mail precisam ser preenchidos.",
                                    "Campo Obrigatório",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK);
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            TxtNomeTlCad.Clear();
            TxtEmailTlCad.Clear();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TelaCadastroAluno_Load(object sender, EventArgs e)
        {
            try
            {
                ConfiguraDgvUsuarios();

                List<Aluno> alunos = Usuario.BuscarUsuarios().ConvertAll(u => (Aluno)u);
                DgvUsuarios.DataSource = alunos;
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
