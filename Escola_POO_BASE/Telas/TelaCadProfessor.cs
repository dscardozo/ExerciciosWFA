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
    public partial class TelaCadProfessor : Form
    {

        private List<Usuario> _usuarios;
        private List<Professor> _professores;
        private Professor _userLogado;
        private Professor _professorSelecionado;
        public TelaCadProfessor(Usuario userLogado)
        {
            InitializeComponent();
            _userLogado = (Professor)userLogado;

            try
            {
                _professores = Usuario.BuscarUsuariosP().ConvertAll(u => (Professor)u);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,
                                   "Erro",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
            }
        }

        private void ConfiguraDgvUsuarios()
        {
            // Criação das colunas no DgvUsuarios
            DgvUsuarios.Columns.Add("Id", "Matrícula");
            DgvUsuarios.Columns.Add("Nome", "Nome");
            DgvUsuarios.Columns.Add("Dtnascimento", "Data Nascimento");
            DgvUsuarios.Columns.Add("Cpf", "CPF");
            DgvUsuarios.Columns.Add("Email", "E-mail");
            DgvUsuarios.Columns.Add("NivelAcesso", "Nível de Acesso");
            DgvUsuarios.Columns.Add("Ativo", "Ativo");


            //Configuração dos alinhamentos de cada coluna no DgvUsuarios
            DgvUsuarios.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvUsuarios.Columns["Nome"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvUsuarios.Columns["Dtnascimento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvUsuarios.Columns["Cpf"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvUsuarios.Columns["Email"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvUsuarios.Columns["NivelAcesso"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvUsuarios.Columns["Ativo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //Configuração dos tamanhos de cada coluna do DgvUsuarios
            DgvUsuarios.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            DgvUsuarios.Columns["Nome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DgvUsuarios.Columns["DtNascimento"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DgvUsuarios.Columns["Cpf"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DgvUsuarios.Columns["NivelAcesso"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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
        private void CarregaDgvUsuarios(List<Professor> professores = null)
        {
            DgvUsuarios.Rows.Clear();

            foreach (Professor professor in professores == null ? _professores : professores)
            {
                DgvUsuarios.Rows.Add(professor.Id, professor.Nome, professor.DtNascimento.ToString("dd/MM/yyyy"), professor.Cpf, professor.Email,professor.NivelAcesso, professor.Ativo);
                if (!professor.Ativo)
                    DgvUsuarios.Rows[DgvUsuarios.Rows.Count - 1].DefaultCellStyle.BackColor = Color.LightCoral;
            }
        }

        // Método que limpa os campos da tela

        public void LimpaCampos()
        {
            LblIdProf.Text = "";
            TxtNomeTlCadP.Clear();
            TxtEmailTlCadP.Clear();
            DtpDtNascimentoTlCadP.Value = new DateTime(1900, 1, 1);
            TxtCpf.Clear();
            LblNivelAcessoP.Text = "";
            CkbAtivoTlCadastro.Checked = true;
            CkbAtivoTlCadastro.Enabled = false;

            DgvUsuarios.ClearSelection();
            BtnCadastrarTlCad.Enabled = true;
            BtnAlterar.Enabled = false;
            BtnReativar.Enabled = false;
            BtnReativar.FlatAppearance.BorderColor = Color.Salmon;
            CbbBuscar.SelectedIndex = 0;
        }

        private void TelaCadProfessor_Load(object sender, EventArgs e)
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

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            TxtNomeTlCadP.Clear();
            TxtEmailTlCadP.Clear();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                _professorSelecionado.Nome = TxtNomeTlCadP.Text;
                _professorSelecionado.Email = TxtEmailTlCadP.Text;
                _professorSelecionado.DtNascimento = DtpDtNascimentoTlCadP.Value;
                _professorSelecionado.NivelAcesso = Convert.ToInt32(LblNivelAcessoP.Text);

                _professorSelecionado.Alterar();
                CarregaDgvUsuarios();
                
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

        private void DgvUsuariosP_SelectionChanged(object sender, EventArgs e)
        {
            if (DgvUsuarios.Rows.Count < 1 || DgvUsuarios.SelectedRows.Count < 1)
            {
                return;
            }
            try
            {
                _professorSelecionado = _professores.Find(a => a.Id == (int)DgvUsuarios.SelectedRows[0].Cells[0].Value);
                LblIdProf.Text = _professorSelecionado.Id.ToString();
                TxtNomeTlCadP.Text = _professorSelecionado.Nome;
                TxtEmailTlCadP.Text = _professorSelecionado.Email;
                TxtCpf.Text = _professorSelecionado.Cpf;
                LblNivelAcessoP.Text = _professorSelecionado.NivelAcesso.ToString();
                CkbAtivoTlCadastro.Checked = _professorSelecionado.Ativo;


                BtnCadastrarTlCad.Enabled = false;
                BtnAlterar.Enabled = true;

                if (_professorSelecionado.Ativo == false)
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

        private void DgvUsuariosP_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (_professorSelecionado.Ativo != true)
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
                    DialogResult dr = MessageBox.Show($"Você realmente deseja desativar o Professor(a) {_professorSelecionado.Nome}?"
                                  , "Remover Professor"
                                  , MessageBoxButtons.YesNo
                                  , MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        _professorSelecionado.Ativo = false;
                        _professorSelecionado.Excluir();
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

        private void DgvUsuariosP_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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
                if (TxtEmailTlCadP.Text != "" && TxtNomeTlCadP.Text != "")
                {
                    Professor professor = new Professor(0
                                            , TxtNomeTlCadP.Text
                                            , DtpDtNascimentoTlCadP.Value
                                            , TxtCpf.Text
                                            , TxtEmailTlCadP.Text
                                            , "123"
                                            , 1
                                            , true);

                    professor.Cadastrar(_professores);
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

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            List<Professor> listaProfessoresFiltrada = Professor.Buscar(_professores, CbbBuscar.SelectedIndex, TxtBuscar.Text);
            CarregaDgvUsuarios(listaProfessoresFiltrada);
        }

        private void BtnLimparBusca_Click(object sender, EventArgs e)
        {
            TxtBuscar.Clear();
            
        }

        private void BtnReativar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show($"Você realmente deseja reativar o Professor(a) {_professorSelecionado.Nome}?"
                              , "Reativar Professor"
                              , MessageBoxButtons.YesNo
                              , MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    _professorSelecionado.Ativo = true;
                    _professorSelecionado.Reativar();
                   
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

        private void TelaCadProfessor_Shown(object sender, EventArgs e)
        {
            TxtBuscar.Focus();
        }
    }
}
