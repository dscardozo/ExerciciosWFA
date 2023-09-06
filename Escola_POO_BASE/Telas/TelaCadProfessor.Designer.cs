namespace Escola_POO_BASE.Telas
{
    partial class TelaCadProfessor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadProfessor));
            this.DgvUsuariosP = new System.Windows.Forms.DataGridView();
            this.GpbCadAluno = new System.Windows.Forms.GroupBox();
            this.LblNivelAcessoP = new System.Windows.Forms.Label();
            this.BtnReativar = new System.Windows.Forms.Button();
            this.LblIdProf = new System.Windows.Forms.Label();
            this.LblNivelAcesso = new System.Windows.Forms.Label();
            this.TxtCpf = new System.Windows.Forms.TextBox();
            this.DtpDtNascimentoTlCadP = new System.Windows.Forms.DateTimePicker();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.CkbAtivoTlCadastro = new System.Windows.Forms.CheckBox();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.TxtEmailTlCadP = new System.Windows.Forms.TextBox();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.TxtNomeTlCadP = new System.Windows.Forms.TextBox();
            this.BtnCadastrarTlCad = new System.Windows.Forms.Button();
            this.LblId = new System.Windows.Forms.Label();
            this.LblDtNasc = new System.Windows.Forms.Label();
            this.LblCpf = new System.Windows.Forms.Label();
            this.LblNomeCadAluno = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnLimparBusca = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.CbbBuscar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuariosP)).BeginInit();
            this.GpbCadAluno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvUsuariosP
            // 
            this.DgvUsuariosP.AllowUserToAddRows = false;
            this.DgvUsuariosP.AllowUserToDeleteRows = false;
            this.DgvUsuariosP.AllowUserToResizeRows = false;
            this.DgvUsuariosP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvUsuariosP.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvUsuariosP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvUsuariosP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvUsuariosP.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvUsuariosP.Location = new System.Drawing.Point(12, 254);
            this.DgvUsuariosP.MultiSelect = false;
            this.DgvUsuariosP.Name = "DgvUsuariosP";
            this.DgvUsuariosP.ReadOnly = true;
            this.DgvUsuariosP.RowHeadersVisible = false;
            this.DgvUsuariosP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvUsuariosP.Size = new System.Drawing.Size(961, 382);
            this.DgvUsuariosP.TabIndex = 10;
            this.DgvUsuariosP.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvUsuariosP_CellFormatting);
            this.DgvUsuariosP.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvUsuariosP_CellMouseDoubleClick);
            this.DgvUsuariosP.SelectionChanged += new System.EventHandler(this.DgvUsuariosP_SelectionChanged);
            // 
            // GpbCadAluno
            // 
            this.GpbCadAluno.BackColor = System.Drawing.Color.LightSteelBlue;
            this.GpbCadAluno.Controls.Add(this.LblNivelAcessoP);
            this.GpbCadAluno.Controls.Add(this.BtnReativar);
            this.GpbCadAluno.Controls.Add(this.LblIdProf);
            this.GpbCadAluno.Controls.Add(this.LblNivelAcesso);
            this.GpbCadAluno.Controls.Add(this.TxtCpf);
            this.GpbCadAluno.Controls.Add(this.DtpDtNascimentoTlCadP);
            this.GpbCadAluno.Controls.Add(this.BtnNovo);
            this.GpbCadAluno.Controls.Add(this.BtnLimpar);
            this.GpbCadAluno.Controls.Add(this.CkbAtivoTlCadastro);
            this.GpbCadAluno.Controls.Add(this.BtnCancelar);
            this.GpbCadAluno.Controls.Add(this.TxtEmailTlCadP);
            this.GpbCadAluno.Controls.Add(this.BtnAlterar);
            this.GpbCadAluno.Controls.Add(this.TxtNomeTlCadP);
            this.GpbCadAluno.Controls.Add(this.BtnCadastrarTlCad);
            this.GpbCadAluno.Controls.Add(this.LblId);
            this.GpbCadAluno.Controls.Add(this.LblDtNasc);
            this.GpbCadAluno.Controls.Add(this.LblCpf);
            this.GpbCadAluno.Controls.Add(this.LblNomeCadAluno);
            this.GpbCadAluno.Controls.Add(this.LblEmail);
            this.GpbCadAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GpbCadAluno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(141)))));
            this.GpbCadAluno.Location = new System.Drawing.Point(12, 12);
            this.GpbCadAluno.Name = "GpbCadAluno";
            this.GpbCadAluno.Size = new System.Drawing.Size(692, 167);
            this.GpbCadAluno.TabIndex = 11;
            this.GpbCadAluno.TabStop = false;
            this.GpbCadAluno.Text = "CADASTRO :";
            // 
            // LblNivelAcessoP
            // 
            this.LblNivelAcessoP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblNivelAcessoP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(141)))));
            this.LblNivelAcessoP.Location = new System.Drawing.Point(259, 17);
            this.LblNivelAcessoP.Name = "LblNivelAcessoP";
            this.LblNivelAcessoP.Size = new System.Drawing.Size(32, 26);
            this.LblNivelAcessoP.TabIndex = 27;
            this.LblNivelAcessoP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnReativar
            // 
            this.BtnReativar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(141)))));
            this.BtnReativar.FlatAppearance.BorderColor = System.Drawing.Color.Salmon;
            this.BtnReativar.FlatAppearance.BorderSize = 3;
            this.BtnReativar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReativar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReativar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(139)))), ((int)(((byte)(31)))));
            this.BtnReativar.Location = new System.Drawing.Point(295, 95);
            this.BtnReativar.Name = "BtnReativar";
            this.BtnReativar.Size = new System.Drawing.Size(121, 29);
            this.BtnReativar.TabIndex = 26;
            this.BtnReativar.Text = "Reativar";
            this.BtnReativar.UseVisualStyleBackColor = true;
            this.BtnReativar.Click += new System.EventHandler(this.BtnReativar_Click);
            // 
            // LblIdProf
            // 
            this.LblIdProf.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblIdProf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(141)))));
            this.LblIdProf.Location = new System.Drawing.Point(99, 17);
            this.LblIdProf.Name = "LblIdProf";
            this.LblIdProf.Size = new System.Drawing.Size(32, 26);
            this.LblIdProf.TabIndex = 25;
            this.LblIdProf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblNivelAcesso
            // 
            this.LblNivelAcesso.AutoSize = true;
            this.LblNivelAcesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNivelAcesso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(139)))), ((int)(((byte)(31)))));
            this.LblNivelAcesso.Location = new System.Drawing.Point(137, 23);
            this.LblNivelAcesso.Name = "LblNivelAcesso";
            this.LblNivelAcesso.Size = new System.Drawing.Size(116, 15);
            this.LblNivelAcesso.TabIndex = 23;
            this.LblNivelAcesso.Text = "Nível de Acesso :";
            // 
            // TxtCpf
            // 
            this.TxtCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCpf.Location = new System.Drawing.Point(533, 61);
            this.TxtCpf.Name = "TxtCpf";
            this.TxtCpf.Size = new System.Drawing.Size(145, 24);
            this.TxtCpf.TabIndex = 22;
            // 
            // DtpDtNascimentoTlCadP
            // 
            this.DtpDtNascimentoTlCadP.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpDtNascimentoTlCadP.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.DtpDtNascimentoTlCadP.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.DtpDtNascimentoTlCadP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpDtNascimentoTlCadP.Location = new System.Drawing.Point(9, 106);
            this.DtpDtNascimentoTlCadP.Name = "DtpDtNascimentoTlCadP";
            this.DtpDtNascimentoTlCadP.Size = new System.Drawing.Size(254, 20);
            this.DtpDtNascimentoTlCadP.TabIndex = 16;
            // 
            // BtnNovo
            // 
            this.BtnNovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(141)))));
            this.BtnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNovo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(139)))), ((int)(((byte)(31)))));
            this.BtnNovo.Location = new System.Drawing.Point(427, 95);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(121, 29);
            this.BtnNovo.TabIndex = 20;
            this.BtnNovo.Text = "NOVO";
            this.BtnNovo.UseVisualStyleBackColor = false;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(141)))));
            this.BtnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(139)))), ((int)(((byte)(31)))));
            this.BtnLimpar.Location = new System.Drawing.Point(295, 130);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(121, 29);
            this.BtnLimpar.TabIndex = 18;
            this.BtnLimpar.Text = "LIMPAR";
            this.BtnLimpar.UseVisualStyleBackColor = false;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // CkbAtivoTlCadastro
            // 
            this.CkbAtivoTlCadastro.AutoSize = true;
            this.CkbAtivoTlCadastro.Checked = true;
            this.CkbAtivoTlCadastro.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CkbAtivoTlCadastro.Enabled = false;
            this.CkbAtivoTlCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CkbAtivoTlCadastro.Location = new System.Drawing.Point(622, 17);
            this.CkbAtivoTlCadastro.Name = "CkbAtivoTlCadastro";
            this.CkbAtivoTlCadastro.Size = new System.Drawing.Size(56, 19);
            this.CkbAtivoTlCadastro.TabIndex = 15;
            this.CkbAtivoTlCadastro.Text = "Ativo";
            this.CkbAtivoTlCadastro.UseVisualStyleBackColor = true;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(141)))));
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(139)))), ((int)(((byte)(31)))));
            this.BtnCancelar.Location = new System.Drawing.Point(559, 130);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(121, 29);
            this.BtnCancelar.TabIndex = 19;
            this.BtnCancelar.Text = "CANCELAR";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // TxtEmailTlCadP
            // 
            this.TxtEmailTlCadP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmailTlCadP.Location = new System.Drawing.Point(271, 61);
            this.TxtEmailTlCadP.Name = "TxtEmailTlCadP";
            this.TxtEmailTlCadP.Size = new System.Drawing.Size(257, 24);
            this.TxtEmailTlCadP.TabIndex = 11;
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(141)))));
            this.BtnAlterar.Enabled = false;
            this.BtnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAlterar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(139)))), ((int)(((byte)(31)))));
            this.BtnAlterar.Location = new System.Drawing.Point(559, 95);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(121, 29);
            this.BtnAlterar.TabIndex = 21;
            this.BtnAlterar.Text = "ALTERAR";
            this.BtnAlterar.UseVisualStyleBackColor = false;
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // TxtNomeTlCadP
            // 
            this.TxtNomeTlCadP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNomeTlCadP.Location = new System.Drawing.Point(9, 61);
            this.TxtNomeTlCadP.Name = "TxtNomeTlCadP";
            this.TxtNomeTlCadP.Size = new System.Drawing.Size(257, 24);
            this.TxtNomeTlCadP.TabIndex = 9;
            // 
            // BtnCadastrarTlCad
            // 
            this.BtnCadastrarTlCad.AutoSize = true;
            this.BtnCadastrarTlCad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(141)))));
            this.BtnCadastrarTlCad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCadastrarTlCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCadastrarTlCad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(139)))), ((int)(((byte)(31)))));
            this.BtnCadastrarTlCad.Location = new System.Drawing.Point(427, 130);
            this.BtnCadastrarTlCad.Name = "BtnCadastrarTlCad";
            this.BtnCadastrarTlCad.Size = new System.Drawing.Size(121, 29);
            this.BtnCadastrarTlCad.TabIndex = 14;
            this.BtnCadastrarTlCad.Text = "CADASTRAR";
            this.BtnCadastrarTlCad.UseVisualStyleBackColor = false;
            this.BtnCadastrarTlCad.Click += new System.EventHandler(this.BtnCadastrarTlCad_Click);
            // 
            // LblId
            // 
            this.LblId.AutoSize = true;
            this.LblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(139)))), ((int)(((byte)(31)))));
            this.LblId.Location = new System.Drawing.Point(5, 23);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(88, 15);
            this.LblId.TabIndex = 7;
            this.LblId.Text = "Nº Registro :";
            // 
            // LblDtNasc
            // 
            this.LblDtNasc.AutoSize = true;
            this.LblDtNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDtNasc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(139)))), ((int)(((byte)(31)))));
            this.LblDtNasc.Location = new System.Drawing.Point(6, 88);
            this.LblDtNasc.Name = "LblDtNasc";
            this.LblDtNasc.Size = new System.Drawing.Size(145, 15);
            this.LblDtNasc.TabIndex = 1;
            this.LblDtNasc.Text = "Data de Nascimento :";
            // 
            // LblCpf
            // 
            this.LblCpf.AutoSize = true;
            this.LblCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCpf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(139)))), ((int)(((byte)(31)))));
            this.LblCpf.Location = new System.Drawing.Point(530, 43);
            this.LblCpf.Name = "LblCpf";
            this.LblCpf.Size = new System.Drawing.Size(41, 15);
            this.LblCpf.TabIndex = 4;
            this.LblCpf.Text = "CPF :";
            // 
            // LblNomeCadAluno
            // 
            this.LblNomeCadAluno.AutoSize = true;
            this.LblNomeCadAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNomeCadAluno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(139)))), ((int)(((byte)(31)))));
            this.LblNomeCadAluno.Location = new System.Drawing.Point(6, 43);
            this.LblNomeCadAluno.Name = "LblNomeCadAluno";
            this.LblNomeCadAluno.Size = new System.Drawing.Size(118, 15);
            this.LblNomeCadAluno.TabIndex = 0;
            this.LblNomeCadAluno.Text = "Nome Completo :";
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(139)))), ((int)(((byte)(31)))));
            this.LblEmail.Location = new System.Drawing.Point(268, 43);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(57, 15);
            this.LblEmail.TabIndex = 2;
            this.LblEmail.Text = "E-mail :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Escola_POO_BASE.Properties.Resources.LogoCad;
            this.pictureBox1.Location = new System.Drawing.Point(731, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 167);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox1.Controls.Add(this.BtnLimparBusca);
            this.groupBox1.Controls.Add(this.BtnBuscar);
            this.groupBox1.Controls.Add(this.TxtBuscar);
            this.groupBox1.Controls.Add(this.CbbBuscar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(141)))));
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox1.Location = new System.Drawing.Point(12, 185);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(961, 63);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Painel de Busca";
            // 
            // BtnLimparBusca
            // 
            this.BtnLimparBusca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(141)))));
            this.BtnLimparBusca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimparBusca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(139)))), ((int)(((byte)(31)))));
            this.BtnLimparBusca.Location = new System.Drawing.Point(719, 22);
            this.BtnLimparBusca.Name = "BtnLimparBusca";
            this.BtnLimparBusca.Size = new System.Drawing.Size(141, 29);
            this.BtnLimparBusca.TabIndex = 26;
            this.BtnLimparBusca.Text = "LIMPAR BUSCA";
            this.BtnLimparBusca.UseVisualStyleBackColor = false;
            this.BtnLimparBusca.Click += new System.EventHandler(this.BtnLimparBusca_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(141)))));
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(139)))), ((int)(((byte)(31)))));
            this.BtnBuscar.Location = new System.Drawing.Point(566, 22);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(112, 30);
            this.BtnBuscar.TabIndex = 3;
            this.BtnBuscar.Text = "BUSCAR";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(280, 29);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(257, 24);
            this.TxtBuscar.TabIndex = 2;
            this.TxtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBuscar_KeyPress);
            // 
            // CbbBuscar
            // 
            this.CbbBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbbBuscar.FormattingEnabled = true;
            this.CbbBuscar.Items.AddRange(new object[] {
            "Nome",
            "E-mail",
            "Nº Registro",
            ""});
            this.CbbBuscar.Location = new System.Drawing.Point(100, 26);
            this.CbbBuscar.Name = "CbbBuscar";
            this.CbbBuscar.Size = new System.Drawing.Size(161, 26);
            this.CbbBuscar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(139)))), ((int)(((byte)(31)))));
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar Por :";
            // 
            // TelaCadProfessor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(981, 648);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.GpbCadAluno);
            this.Controls.Add(this.DgvUsuariosP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaCadProfessor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Tela de Cadastro de Professores";
            this.Load += new System.EventHandler(this.TelaCadProfessor_Load);
            this.Shown += new System.EventHandler(this.TelaCadProfessor_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuariosP)).EndInit();
            this.GpbCadAluno.ResumeLayout(false);
            this.GpbCadAluno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvUsuariosP;
        private System.Windows.Forms.GroupBox GpbCadAluno;
        private System.Windows.Forms.Button BtnAlterar;
        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.DateTimePicker DtpDtNascimentoTlCadP;
        private System.Windows.Forms.CheckBox CkbAtivoTlCadastro;
        private System.Windows.Forms.Button BtnCadastrarTlCad;
        private System.Windows.Forms.TextBox TxtEmailTlCadP;
        private System.Windows.Forms.TextBox TxtNomeTlCadP;
        private System.Windows.Forms.Label LblId;
        private System.Windows.Forms.Label LblNomeCadAluno;
        private System.Windows.Forms.Label LblDtNasc;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Label LblCpf;
        private System.Windows.Forms.TextBox TxtCpf;
        private System.Windows.Forms.Label LblNivelAcesso;
        private System.Windows.Forms.Label LblIdProf;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.ComboBox CbbBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnLimparBusca;
        private System.Windows.Forms.Button BtnReativar;
        private System.Windows.Forms.Label LblNivelAcessoP;
    }
}