namespace Escola_POO_BASE.Telas
{
    partial class TelaCadastroAluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastroAluno));
            this.LblNomeCadAluno = new System.Windows.Forms.Label();
            this.LblDtNasc = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.LblDtMatricula = new System.Windows.Forms.Label();
            this.GpbCadAluno = new System.Windows.Forms.GroupBox();
            this.BtnReativar = new System.Windows.Forms.Button();
            this.LblIdAluno = new System.Windows.Forms.Label();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.DtpDtMatriculaTlCad = new System.Windows.Forms.DateTimePicker();
            this.DtpDtNascimentoTlCad = new System.Windows.Forms.DateTimePicker();
            this.CkbAtivoTlCadastro = new System.Windows.Forms.CheckBox();
            this.BtnCadastrarTlCad = new System.Windows.Forms.Button();
            this.TxtEmailTlCad = new System.Windows.Forms.TextBox();
            this.TxtNomeTlCad = new System.Windows.Forms.TextBox();
            this.LblId = new System.Windows.Forms.Label();
            this.DgvUsuarios = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnLimparBusca = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.CbbBuscar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GpbCadAluno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblNomeCadAluno
            // 
            this.LblNomeCadAluno.AutoSize = true;
            this.LblNomeCadAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNomeCadAluno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(139)))), ((int)(((byte)(31)))));
            this.LblNomeCadAluno.Location = new System.Drawing.Point(6, 45);
            this.LblNomeCadAluno.Name = "LblNomeCadAluno";
            this.LblNomeCadAluno.Size = new System.Drawing.Size(118, 15);
            this.LblNomeCadAluno.TabIndex = 0;
            this.LblNomeCadAluno.Text = "Nome Completo :";
            // 
            // LblDtNasc
            // 
            this.LblDtNasc.AutoSize = true;
            this.LblDtNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDtNasc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(139)))), ((int)(((byte)(31)))));
            this.LblDtNasc.Location = new System.Drawing.Point(331, 45);
            this.LblDtNasc.Name = "LblDtNasc";
            this.LblDtNasc.Size = new System.Drawing.Size(145, 15);
            this.LblDtNasc.TabIndex = 1;
            this.LblDtNasc.Text = "Data de Nascimento :";
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(139)))), ((int)(((byte)(31)))));
            this.LblEmail.Location = new System.Drawing.Point(7, 90);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(57, 15);
            this.LblEmail.TabIndex = 2;
            this.LblEmail.Text = "E-mail :";
            // 
            // LblDtMatricula
            // 
            this.LblDtMatricula.AutoSize = true;
            this.LblDtMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDtMatricula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(139)))), ((int)(((byte)(31)))));
            this.LblDtMatricula.Location = new System.Drawing.Point(331, 90);
            this.LblDtMatricula.Name = "LblDtMatricula";
            this.LblDtMatricula.Size = new System.Drawing.Size(129, 15);
            this.LblDtMatricula.TabIndex = 4;
            this.LblDtMatricula.Text = "Data de Matrícula :";
            // 
            // GpbCadAluno
            // 
            this.GpbCadAluno.BackColor = System.Drawing.Color.LightSteelBlue;
            this.GpbCadAluno.Controls.Add(this.BtnReativar);
            this.GpbCadAluno.Controls.Add(this.LblIdAluno);
            this.GpbCadAluno.Controls.Add(this.DtpDtMatriculaTlCad);
            this.GpbCadAluno.Controls.Add(this.CkbAtivoTlCadastro);
            this.GpbCadAluno.Controls.Add(this.LblId);
            this.GpbCadAluno.Controls.Add(this.BtnAlterar);
            this.GpbCadAluno.Controls.Add(this.DtpDtNascimentoTlCad);
            this.GpbCadAluno.Controls.Add(this.TxtNomeTlCad);
            this.GpbCadAluno.Controls.Add(this.BtnCancelar);
            this.GpbCadAluno.Controls.Add(this.LblNomeCadAluno);
            this.GpbCadAluno.Controls.Add(this.BtnCadastrarTlCad);
            this.GpbCadAluno.Controls.Add(this.LblDtMatricula);
            this.GpbCadAluno.Controls.Add(this.BtnNovo);
            this.GpbCadAluno.Controls.Add(this.TxtEmailTlCad);
            this.GpbCadAluno.Controls.Add(this.LblDtNasc);
            this.GpbCadAluno.Controls.Add(this.LblEmail);
            this.GpbCadAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GpbCadAluno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(141)))));
            this.GpbCadAluno.Location = new System.Drawing.Point(12, 12);
            this.GpbCadAluno.Name = "GpbCadAluno";
            this.GpbCadAluno.Size = new System.Drawing.Size(670, 174);
            this.GpbCadAluno.TabIndex = 7;
            this.GpbCadAluno.TabStop = false;
            this.GpbCadAluno.Text = "CADASTRO :";
            // 
            // BtnReativar
            // 
            this.BtnReativar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(141)))));
            this.BtnReativar.FlatAppearance.BorderSize = 3;
            this.BtnReativar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReativar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReativar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(139)))), ((int)(((byte)(31)))));
            this.BtnReativar.Location = new System.Drawing.Point(549, 140);
            this.BtnReativar.Name = "BtnReativar";
            this.BtnReativar.Size = new System.Drawing.Size(112, 30);
            this.BtnReativar.TabIndex = 23;
            this.BtnReativar.Text = "Reativar";
            this.BtnReativar.UseVisualStyleBackColor = false;
            this.BtnReativar.Click += new System.EventHandler(this.BtnReativar_Click);
            // 
            // LblIdAluno
            // 
            this.LblIdAluno.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblIdAluno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(141)))));
            this.LblIdAluno.Location = new System.Drawing.Point(111, 16);
            this.LblIdAluno.Name = "LblIdAluno";
            this.LblIdAluno.Size = new System.Drawing.Size(34, 24);
            this.LblIdAluno.TabIndex = 22;
            this.LblIdAluno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(141)))));
            this.BtnAlterar.Enabled = false;
            this.BtnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAlterar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(139)))), ((int)(((byte)(31)))));
            this.BtnAlterar.Location = new System.Drawing.Point(280, 139);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(112, 29);
            this.BtnAlterar.TabIndex = 21;
            this.BtnAlterar.Text = "ALTERAR";
            this.BtnAlterar.UseVisualStyleBackColor = false;
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // BtnNovo
            // 
            this.BtnNovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(141)))));
            this.BtnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNovo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(139)))), ((int)(((byte)(31)))));
            this.BtnNovo.Location = new System.Drawing.Point(7, 139);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(112, 29);
            this.BtnNovo.TabIndex = 20;
            this.BtnNovo.Text = "NOVO";
            this.BtnNovo.UseVisualStyleBackColor = false;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(141)))));
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(139)))), ((int)(((byte)(31)))));
            this.BtnCancelar.Location = new System.Drawing.Point(414, 140);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(112, 29);
            this.BtnCancelar.TabIndex = 19;
            this.BtnCancelar.Text = "CANCELAR";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(141)))));
            this.BtnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(139)))), ((int)(((byte)(31)))));
            this.BtnLimpar.Location = new System.Drawing.Point(195, 466);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(112, 30);
            this.BtnLimpar.TabIndex = 18;
            this.BtnLimpar.Text = "LIMPAR";
            this.BtnLimpar.UseVisualStyleBackColor = false;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // DtpDtMatriculaTlCad
            // 
            this.DtpDtMatriculaTlCad.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpDtMatriculaTlCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpDtMatriculaTlCad.Location = new System.Drawing.Point(324, 108);
            this.DtpDtMatriculaTlCad.Name = "DtpDtMatriculaTlCad";
            this.DtpDtMatriculaTlCad.Size = new System.Drawing.Size(267, 20);
            this.DtpDtMatriculaTlCad.TabIndex = 17;
            // 
            // DtpDtNascimentoTlCad
            // 
            this.DtpDtNascimentoTlCad.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpDtNascimentoTlCad.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.DtpDtNascimentoTlCad.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.DtpDtNascimentoTlCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpDtNascimentoTlCad.Location = new System.Drawing.Point(321, 63);
            this.DtpDtNascimentoTlCad.Name = "DtpDtNascimentoTlCad";
            this.DtpDtNascimentoTlCad.Size = new System.Drawing.Size(270, 20);
            this.DtpDtNascimentoTlCad.TabIndex = 16;
            // 
            // CkbAtivoTlCadastro
            // 
            this.CkbAtivoTlCadastro.AutoSize = true;
            this.CkbAtivoTlCadastro.Checked = true;
            this.CkbAtivoTlCadastro.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CkbAtivoTlCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CkbAtivoTlCadastro.Location = new System.Drawing.Point(605, 16);
            this.CkbAtivoTlCadastro.Name = "CkbAtivoTlCadastro";
            this.CkbAtivoTlCadastro.Size = new System.Drawing.Size(56, 19);
            this.CkbAtivoTlCadastro.TabIndex = 15;
            this.CkbAtivoTlCadastro.Text = "Ativo";
            this.CkbAtivoTlCadastro.UseVisualStyleBackColor = true;
            // 
            // BtnCadastrarTlCad
            // 
            this.BtnCadastrarTlCad.AutoSize = true;
            this.BtnCadastrarTlCad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(141)))));
            this.BtnCadastrarTlCad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCadastrarTlCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCadastrarTlCad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(139)))), ((int)(((byte)(31)))));
            this.BtnCadastrarTlCad.Location = new System.Drawing.Point(144, 140);
            this.BtnCadastrarTlCad.Name = "BtnCadastrarTlCad";
            this.BtnCadastrarTlCad.Size = new System.Drawing.Size(112, 28);
            this.BtnCadastrarTlCad.TabIndex = 14;
            this.BtnCadastrarTlCad.Text = "CADASTRAR";
            this.BtnCadastrarTlCad.UseVisualStyleBackColor = false;
            this.BtnCadastrarTlCad.Click += new System.EventHandler(this.BtnCadastrarTlCad_Click);
            // 
            // TxtEmailTlCad
            // 
            this.TxtEmailTlCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmailTlCad.Location = new System.Drawing.Point(10, 108);
            this.TxtEmailTlCad.Name = "TxtEmailTlCad";
            this.TxtEmailTlCad.Size = new System.Drawing.Size(285, 24);
            this.TxtEmailTlCad.TabIndex = 11;
            // 
            // TxtNomeTlCad
            // 
            this.TxtNomeTlCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNomeTlCad.Location = new System.Drawing.Point(9, 63);
            this.TxtNomeTlCad.Name = "TxtNomeTlCad";
            this.TxtNomeTlCad.Size = new System.Drawing.Size(286, 24);
            this.TxtNomeTlCad.TabIndex = 9;
            // 
            // LblId
            // 
            this.LblId.AutoSize = true;
            this.LblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(139)))), ((int)(((byte)(31)))));
            this.LblId.Location = new System.Drawing.Point(6, 21);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(99, 15);
            this.LblId.TabIndex = 7;
            this.LblId.Text = "Matrícula(ID) :";
            // 
            // DgvUsuarios
            // 
            this.DgvUsuarios.AllowUserToAddRows = false;
            this.DgvUsuarios.AllowUserToDeleteRows = false;
            this.DgvUsuarios.AllowUserToResizeRows = false;
            this.DgvUsuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvUsuarios.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvUsuarios.Location = new System.Drawing.Point(12, 261);
            this.DgvUsuarios.MultiSelect = false;
            this.DgvUsuarios.Name = "DgvUsuarios";
            this.DgvUsuarios.ReadOnly = true;
            this.DgvUsuarios.RowHeadersVisible = false;
            this.DgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvUsuarios.Size = new System.Drawing.Size(966, 417);
            this.DgvUsuarios.TabIndex = 9;
            this.DgvUsuarios.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvUsuarios_CellFormatting);
            this.DgvUsuarios.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvUsuarios_CellMouseDoubleClick);
            this.DgvUsuarios.SelectionChanged += new System.EventHandler(this.DgvUsuarios_SelectionChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Escola_POO_BASE.Properties.Resources.LogoCad;
            this.pictureBox1.Location = new System.Drawing.Point(727, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 167);
            this.pictureBox1.TabIndex = 27;
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
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(141)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 192);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(957, 63);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Painel de Busca";
            // 
            // BtnLimparBusca
            // 
            this.BtnLimparBusca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(141)))));
            this.BtnLimparBusca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimparBusca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(139)))), ((int)(((byte)(31)))));
            this.BtnLimparBusca.Location = new System.Drawing.Point(715, 20);
            this.BtnLimparBusca.Name = "BtnLimparBusca";
            this.BtnLimparBusca.Size = new System.Drawing.Size(141, 29);
            this.BtnLimparBusca.TabIndex = 27;
            this.BtnLimparBusca.Text = "LIMPAR BUSCA";
            this.BtnLimparBusca.UseVisualStyleBackColor = false;
            this.BtnLimparBusca.Click += new System.EventHandler(this.BtnLimparBusca_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(141)))));
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(139)))), ((int)(((byte)(31)))));
            this.BtnBuscar.Location = new System.Drawing.Point(585, 19);
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
            this.TxtBuscar.Size = new System.Drawing.Size(257, 20);
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
            "Matrícula",
            ""});
            this.CbbBuscar.Location = new System.Drawing.Point(89, 28);
            this.CbbBuscar.Name = "CbbBuscar";
            this.CbbBuscar.Size = new System.Drawing.Size(161, 21);
            this.CbbBuscar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(139)))), ((int)(((byte)(31)))));
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar Por :";
            // 
            // TelaCadastroAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(981, 648);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DgvUsuarios);
            this.Controls.Add(this.GpbCadAluno);
            this.Controls.Add(this.BtnLimpar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaCadastroAluno";
            this.Text = "TelaCadastroAluno";
            this.Load += new System.EventHandler(this.TelaCadastroAluno_Load);
            this.GpbCadAluno.ResumeLayout(false);
            this.GpbCadAluno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblNomeCadAluno;
        private System.Windows.Forms.Label LblDtNasc;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Label LblDtMatricula;
        private System.Windows.Forms.GroupBox GpbCadAluno;
        private System.Windows.Forms.Label LblId;
        private System.Windows.Forms.TextBox TxtEmailTlCad;
        private System.Windows.Forms.TextBox TxtNomeTlCad;
        private System.Windows.Forms.DateTimePicker DtpDtMatriculaTlCad;
        private System.Windows.Forms.DateTimePicker DtpDtNascimentoTlCad;
        private System.Windows.Forms.CheckBox CkbAtivoTlCadastro;
        private System.Windows.Forms.Button BtnCadastrarTlCad;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.DataGridView DgvUsuarios;
        private System.Windows.Forms.Button BtnAlterar;
        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.Label LblIdAluno;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.ComboBox CbbBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnLimparBusca;
        private System.Windows.Forms.Button BtnReativar;
    }
}