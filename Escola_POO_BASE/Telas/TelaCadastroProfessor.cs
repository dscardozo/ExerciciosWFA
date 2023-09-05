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
    public partial class TelaCadastroProfessor : Form
    {
        //private List<Usuario> _usuarios;
        private List<Professor> _professores;
        private Professor _userLogado;



        public TelaCadastroProfessor()
        {
            
        }
        public TelaCadastroProfessor(Usuario userLogado)
        {
            InitializeComponent();
            //_usuarios = usuarios;
            _userLogado = (Professor)userLogado;


            try
            {
                _professores = Usuario.BuscarUsuarios("").ConvertAll(u => (Professor)u);
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
            DgvUsuarios.Columns["DtNascimento"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            DgvUsuarios.Columns["Cpf"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DgvUsuarios.Columns["Email"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DgvUsuarios.Columns["NivelAcesso"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DgvUsuarios.Columns["Ativo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

            //Configuarar tamanho em altura das linhas
            DgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DgvUsuarios.ColumnHeadersHeight = 35;
            DgvUsuarios.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;



        }

        // Método para carregar o DvgUsuarios com os dados da lista
        private void CarregaDgvUsuarios()
        {
            DgvUsuarios.Rows.Clear();

            foreach (Professor professor in _professores)
            {
                DgvUsuarios.Rows.Add(professor.Id, professor.Nome, professor.DtNascimento.ToString("dd/MM/yyyy"), professor.Cpf, professor.Email, professor.NivelAcesso, professor.Ativo);
            }

        }

        private void TelaCadastroProfessor_Load(object sender, EventArgs e)
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

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            TxtNomeTlCadProf.Clear();
            TxtEmailTlCadProf.Clear();
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
                if (TxtEmailTlCadProf.Text != "" && TxtNomeTlCadProf.Text != "")
                {
                    Professor professor = new Professor(0, TxtNomeTlCadProf.Text, DtpDtNascimentoTlCadProf.Value, TxtCpf.Text, TxtEmailTlCadProf.Text, "123", 1, true);
                    professor.Cadastrar(_professores);
                    MessageBox.Show($"Professor(a) {professor.Nome} cadastrado com sucesso!!",
                                    "Cadastro",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Information);
                    CarregaDgvUsuarios();
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

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }

        public void LimpaCampos()
        {
            LblIdProf.Text = "";
            TxtNomeTlCadProf.Clear();
            TxtEmailTlCadProf.Clear();
            DtpDtNascimentoTlCadProf.Value = new DateTime(1900, 1, 1);
            TxtCpf.Clear();
            TxtNivelAcesso.Clear();
            CkbAtivoTlCadastroProf.Checked = true;

            DgvUsuarios.ClearSelection();
            BtnCadastrarTlCad.Enabled = true;
            BtnAlterar.Enabled = false;
        }

        private void DgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            if (DgvUsuarios.Rows.Count < 1 || DgvUsuarios.SelectedRows.Count < 1)
            {
                return;
            }
            try
            {
                Professor professorSelecionado = _professores.Find(a => a.Id == (int)DgvUsuarios.SelectedRows[0].Cells[0].Value);
                LblIdProf.Text = professorSelecionado.Id.ToString();
                TxtNomeTlCadProf.Text = professorSelecionado.Nome;
                TxtEmailTlCadProf.Text = professorSelecionado.Email;
                DtpDtNascimentoTlCadProf.Value = professorSelecionado.DtNascimento;
                TxtCpf.Text = professorSelecionado.Cpf;
                TxtNivelAcesso.Text = professorSelecionado.NivelAcesso.ToString();
                CkbAtivoTlCadastroProf.Checked = professorSelecionado.Ativo;

                BtnCadastrarTlCad.Enabled = false;
                BtnAlterar.Enabled = true;
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

        }

        private void DgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
