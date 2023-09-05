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
    public partial class TelaCadastroAluno : Form
    {
        private List<Usuario> _usuarios;
        private List<Aluno> _alunos;
        private Professor _userLogado;
        private Aluno _alunoSelecionado;

        public TelaCadastroAluno(Usuario userLogado)
        {
            InitializeComponent();
            _userLogado = (Professor)userLogado;

            try
            {
                _alunos = Usuario.BuscarUsuarios().ConvertAll(u => (Aluno)u);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,
                                   "Erro",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
            }
        }

        // Método de formulário que ira configurar o DgvUsuarios

        private void ConfiguraDgvUsuarios()
        {
            // Criação das colunas no DgvUsuarios
            DgvUsuarios.Columns.Add("Id", "Matrícula");
            DgvUsuarios.Columns.Add("Nome", "Nome");
            DgvUsuarios.Columns.Add("Dtnascimento", "Data Nascimento");
            DgvUsuarios.Columns.Add("DtMatricula", "Data Matrícula");
            DgvUsuarios.Columns.Add("Email", "E-mail");
            DgvUsuarios.Columns.Add("Ativo", "Ativo");


            //Configuração dos alinhamentos de cada coluna no DgvUsuarios
            DgvUsuarios.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvUsuarios.Columns["Nome"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvUsuarios.Columns["Dtnascimento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvUsuarios.Columns["DtMatricula"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvUsuarios.Columns["Email"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvUsuarios.Columns["Ativo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //Configuração dos tamanhos de cada coluna do DgvUsuarios
            DgvUsuarios.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            DgvUsuarios.Columns["Nome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DgvUsuarios.Columns["DtNascimento"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DgvUsuarios.Columns["DtMatricula"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DgvUsuarios.Columns["Email"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DgvUsuarios.Columns["Ativo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

            //Configuarar tamanho em altura das linhas
            DgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DgvUsuarios.ColumnHeadersHeight = 35;
            DgvUsuarios.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            //Configurar cor para intercalar linahs
            DgvUsuarios.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;



        }

        // Método para carregar o DvgUsuarios com os dados da lista
        private void CarregaDgvUsuarios(List<Aluno> alunos = null)
        {
            DgvUsuarios.Rows.Clear();

            foreach (Aluno aluno in alunos == null ? _alunos : alunos)
            {
                DgvUsuarios.Rows.Add(aluno.Id, aluno.Nome, aluno.DtNascimento.ToString("dd/MM/yyyy"), aluno.DtMatricula, aluno.Email, aluno.Ativo);
                if (!aluno.Ativo)
                    DgvUsuarios.Rows[DgvUsuarios.Rows.Count - 1].DefaultCellStyle.BackColor = Color.LightCoral;
            }
        }

        // Método que limpa os campos da tela

        public void LimpaCampos()
        {
            LblIdAluno.Text = "";
            TxtNomeTlCad.Clear();
            TxtEmailTlCad.Clear();
            DtpDtNascimentoTlCad.Value = new DateTime(1900, 1, 1);
            DtpDtMatriculaTlCad.Value = DateTime.Now;
            CkbAtivoTlCadastro.Checked = true;
            CkbAtivoTlCadastro.Enabled = false;

            DgvUsuarios.ClearSelection();
            BtnCadastrarTlCad.Enabled = true;
            BtnAlterar.Enabled = false;
            BtnReativar.Enabled = false;
            BtnReativar.FlatAppearance.BorderColor = Color.Salmon;
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
                return; // Mata o método (Encerra)
            }


            try
            {
                if (TxtEmailTlCad.Text != "" && TxtNomeTlCad.Text != "")
                {
                    Aluno aluno = new Aluno(0
                                            , TxtNomeTlCad.Text
                                            , DtpDtNascimentoTlCad.Value
                                            , DtpDtMatriculaTlCad.Value
                                            , TxtEmailTlCad.Text
                                            , "123"
                                            , true);

                    aluno.Cadastrar(_alunos);
                    CarregaDgvUsuarios();
                    LimpaCampos();
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
            
            LimpaCampos();
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
                CarregaDgvUsuarios();
                LimpaCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                                   "Erro",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
            }
        }
        private void BtnNovo_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }
        private void DgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {

            if (DgvUsuarios.Rows.Count < 1 || DgvUsuarios.SelectedRows.Count < 1)
            {
                return;
            }
            try
            {
                _alunoSelecionado = _alunos.Find(a => a.Id == (int)DgvUsuarios.SelectedRows[0].Cells[0].Value);
                LblIdAluno.Text = _alunoSelecionado.Id.ToString();
                TxtNomeTlCad.Text = _alunoSelecionado.Nome;
                TxtEmailTlCad.Text = _alunoSelecionado.Email;
                DtpDtNascimentoTlCad.Value = _alunoSelecionado.DtNascimento;
                DtpDtMatriculaTlCad.Value = _alunoSelecionado.DtMatricula;
                CkbAtivoTlCadastro.Checked = _alunoSelecionado.Ativo;


                BtnCadastrarTlCad.Enabled = false;
                BtnAlterar.Enabled = true;

                if (_alunoSelecionado.Ativo == false)
                { 
                    BtnReativar.Enabled = true;
                    BtnReativar.FlatAppearance.BorderColor = Color.Green;
                }
                else

                {
                    BtnReativar.Enabled = false;
                    BtnReativar.FlatAppearance.BorderColor = Color.Salmon;
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
        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                _alunoSelecionado.Nome = TxtNomeTlCad.Text;
                _alunoSelecionado.Email = TxtEmailTlCad.Text;
                _alunoSelecionado.DtNascimento = DtpDtNascimentoTlCad.Value;
                _alunoSelecionado.DtMatricula = DtpDtMatriculaTlCad.Value;

                _alunoSelecionado.Alterar(_alunos);
                CarregaDgvUsuarios();
                LimpaCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                                   "Erro",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
            }
        }
        private void DgvUsuarios_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (_alunoSelecionado.Ativo != true)
            {
                try
                {

                    BtnReativar.Enabled = true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,
                                    "Erro",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    DialogResult dr = MessageBox.Show($"Você realmente deseja desativar o Aluno(a) {_alunoSelecionado.Nome}?"
                                  , "Remover Aluno"
                                  , MessageBoxButtons.YesNo
                                  , MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        _alunoSelecionado.Ativo = false;
                        _alunoSelecionado.Excluir();
                        CarregaDgvUsuarios();
                        LimpaCampos();
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
        private void DgvUsuarios_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == DgvUsuarios.Columns["Ativo"].Index) // Verifica se é uma célula válida na coluna "Ativo"
            {
                DataGridViewRow row = DgvUsuarios.Rows[e.RowIndex];
                bool ativo = Convert.ToBoolean(row.Cells["Ativo"].Value);

                if (!ativo)
                {
                    // Define o estilo da linha correspondente para vermelho claro
                    row.DefaultCellStyle.BackColor = Color.LightCoral;
                }
            }
        }
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            List<Aluno> listaAlunosFiltrada = Aluno.Buscar(_alunos, CbbBuscar.SelectedIndex, TxtBuscar.Text);
            CarregaDgvUsuarios(listaAlunosFiltrada);

        }
        private void BtnLimparBusca_Click(object sender, EventArgs e)
        {
            TxtBuscar.Clear();
        }

        private void BtnReativar_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult dr = MessageBox.Show($"Você realmente deseja reativar o Aluno(a) {_alunoSelecionado.Nome}?"
                              , "Reativar Aluno"
                              , MessageBoxButtons.YesNo
                              , MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    _alunoSelecionado.Ativo = true;
                    _alunoSelecionado.Reativar();
                    
                    
                    CarregaDgvUsuarios();
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

        private void TxtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                BtnBuscar.PerformClick();
            }
        }
    }
}
