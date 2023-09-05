namespace Escola_POO_BASE.Telas
{
    partial class TelaCadastroProfessor
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
            this.DgvUsuarios = new System.Windows.Forms.DataGridView();
            this.GpbCadProfessor = new System.Windows.Forms.GroupBox();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.TxtNivelAcesso = new System.Windows.Forms.TextBox();
            this.LblNivelAcesso = new System.Windows.Forms.Label();
            this.TxtCpf = new System.Windows.Forms.TextBox();
            this.LblIdProf = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.DtpDtNascimentoTlCadProf = new System.Windows.Forms.DateTimePicker();
            this.CkbAtivoTlCadastroProf = new System.Windows.Forms.CheckBox();
            this.BtnCadastrarTlCad = new System.Windows.Forms.Button();
            this.TxtEmailTlCadProf = new System.Windows.Forms.TextBox();
            this.TxtNomeTlCadProf = new System.Windows.Forms.TextBox();
            this.LblId = new System.Windows.Forms.Label();
            this.LblNomeCadProf = new System.Windows.Forms.Label();
            this.LblDtNascProf = new System.Windows.Forms.Label();
            this.LblEmailProf = new System.Windows.Forms.Label();
            this.LblCPF = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuarios)).BeginInit();
            this.GpbCadProfessor.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvUsuarios
            // 
            this.DgvUsuarios.AllowUserToAddRows = false;
            this.DgvUsuarios.AllowUserToDeleteRows = false;
            this.DgvUsuarios.AllowUserToResizeRows = false;
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
            this.DgvUsuarios.Location = new System.Drawing.Point(12, 214);
            this.DgvUsuarios.MultiSelect = false;
            this.DgvUsuarios.Name = "DgvUsuarios";
            this.DgvUsuarios.ReadOnly = true;
            this.DgvUsuarios.RowHeadersVisible = false;
            this.DgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvUsuarios.Size = new System.Drawing.Size(697, 325);
            this.DgvUsuarios.TabIndex = 10;
            this.DgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvUsuarios_CellClick);
            this.DgvUsuarios.SelectionChanged += new System.EventHandler(this.DgvUsuarios_SelectionChanged);
            // 
            // GpbCadProfessor
            // 
            this.GpbCadProfessor.Controls.Add(this.BtnNovo);
            this.GpbCadProfessor.Controls.Add(this.BtnAlterar);
            this.GpbCadProfessor.Controls.Add(this.TxtNivelAcesso);
            this.GpbCadProfessor.Controls.Add(this.LblNivelAcesso);
            this.GpbCadProfessor.Controls.Add(this.TxtCpf);
            this.GpbCadProfessor.Controls.Add(this.LblIdProf);
            this.GpbCadProfessor.Controls.Add(this.BtnCancelar);
            this.GpbCadProfessor.Controls.Add(this.BtnLimpar);
            this.GpbCadProfessor.Controls.Add(this.DtpDtNascimentoTlCadProf);
            this.GpbCadProfessor.Controls.Add(this.CkbAtivoTlCadastroProf);
            this.GpbCadProfessor.Controls.Add(this.BtnCadastrarTlCad);
            this.GpbCadProfessor.Controls.Add(this.TxtEmailTlCadProf);
            this.GpbCadProfessor.Controls.Add(this.TxtNomeTlCadProf);
            this.GpbCadProfessor.Controls.Add(this.LblId);
            this.GpbCadProfessor.Controls.Add(this.LblNomeCadProf);
            this.GpbCadProfessor.Controls.Add(this.LblDtNascProf);
            this.GpbCadProfessor.Controls.Add(this.LblEmailProf);
            this.GpbCadProfessor.Controls.Add(this.LblCPF);
            this.GpbCadProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GpbCadProfessor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(141)))));
            this.GpbCadProfessor.Location = new System.Drawing.Point(12, 12);
            this.GpbCadProfessor.Name = "GpbCadProfessor";
            this.GpbCadProfessor.Size = new System.Drawing.Size(697, 196);
            this.GpbCadProfessor.TabIndex = 11;
            this.GpbCadProfessor.TabStop = false;
            this.GpbCadProfessor.Text = "CADASTRO :";
            // 
            // BtnNovo
            // 
            this.BtnNovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(139)))), ((int)(((byte)(31)))));
            this.BtnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNovo.Location = new System.Drawing.Point(6, 144);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(112, 30);
            this.BtnNovo.TabIndex = 24;
            this.BtnNovo.Text = "NOVO";
            this.BtnNovo.UseVisualStyleBackColor = false;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(139)))), ((int)(((byte)(31)))));
            this.BtnAlterar.Enabled = false;
            this.BtnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAlterar.Location = new System.Drawing.Point(172, 144);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(112, 30);
            this.BtnAlterar.TabIndex = 23;
            this.BtnAlterar.Text = "ALTERAR";
            this.BtnAlterar.UseVisualStyleBackColor = false;
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // TxtNivelAcesso
            // 
            this.TxtNivelAcesso.Location = new System.Drawing.Point(549, 104);
            this.TxtNivelAcesso.Name = "TxtNivelAcesso";
            this.TxtNivelAcesso.Size = new System.Drawing.Size(43, 24);
            this.TxtNivelAcesso.TabIndex = 22;
            // 
            // LblNivelAcesso
            // 
            this.LblNivelAcesso.AutoSize = true;
            this.LblNivelAcesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNivelAcesso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(139)))), ((int)(((byte)(31)))));
            this.LblNivelAcesso.Location = new System.Drawing.Point(546, 84);
            this.LblNivelAcesso.Name = "LblNivelAcesso";
            this.LblNivelAcesso.Size = new System.Drawing.Size(116, 15);
            this.LblNivelAcesso.TabIndex = 21;
            this.LblNivelAcesso.Text = "Nivel de Acesso :";
            // 
            // TxtCpf
            // 
            this.TxtCpf.Location = new System.Drawing.Point(425, 104);
            this.TxtCpf.Name = "TxtCpf";
            this.TxtCpf.Size = new System.Drawing.Size(100, 24);
            this.TxtCpf.TabIndex = 20;
            // 
            // LblIdProf
            // 
            this.LblIdProf.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblIdProf.Location = new System.Drawing.Point(9, 104);
            this.LblIdProf.Name = "LblIdProf";
            this.LblIdProf.Size = new System.Drawing.Size(82, 24);
            this.LblIdProf.TabIndex = 3;
            this.LblIdProf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(139)))), ((int)(((byte)(31)))));
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Location = new System.Drawing.Point(307, 144);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(112, 30);
            this.BtnCancelar.TabIndex = 19;
            this.BtnCancelar.Text = "CANCELAR";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(141)))));
            this.BtnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(139)))), ((int)(((byte)(31)))));
            this.BtnLimpar.Location = new System.Drawing.Point(570, 144);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(112, 30);
            this.BtnLimpar.TabIndex = 18;
            this.BtnLimpar.Text = "LIMPAR";
            this.BtnLimpar.UseVisualStyleBackColor = false;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // DtpDtNascimentoTlCadProf
            // 
            this.DtpDtNascimentoTlCadProf.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpDtNascimentoTlCadProf.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.DtpDtNascimentoTlCadProf.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.DtpDtNascimentoTlCadProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpDtNascimentoTlCadProf.Location = new System.Drawing.Point(425, 61);
            this.DtpDtNascimentoTlCadProf.Name = "DtpDtNascimentoTlCadProf";
            this.DtpDtNascimentoTlCadProf.Size = new System.Drawing.Size(257, 20);
            this.DtpDtNascimentoTlCadProf.TabIndex = 16;
            // 
            // CkbAtivoTlCadastroProf
            // 
            this.CkbAtivoTlCadastroProf.AutoSize = true;
            this.CkbAtivoTlCadastroProf.Checked = true;
            this.CkbAtivoTlCadastroProf.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CkbAtivoTlCadastroProf.Enabled = false;
            this.CkbAtivoTlCadastroProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CkbAtivoTlCadastroProf.Location = new System.Drawing.Point(9, 61);
            this.CkbAtivoTlCadastroProf.Name = "CkbAtivoTlCadastroProf";
            this.CkbAtivoTlCadastroProf.Size = new System.Drawing.Size(56, 19);
            this.CkbAtivoTlCadastroProf.TabIndex = 15;
            this.CkbAtivoTlCadastroProf.Text = "Ativo";
            this.CkbAtivoTlCadastroProf.UseVisualStyleBackColor = true;
            // 
            // BtnCadastrarTlCad
            // 
            this.BtnCadastrarTlCad.AutoSize = true;
            this.BtnCadastrarTlCad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(141)))));
            this.BtnCadastrarTlCad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCadastrarTlCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCadastrarTlCad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(139)))), ((int)(((byte)(31)))));
            this.BtnCadastrarTlCad.Location = new System.Drawing.Point(437, 144);
            this.BtnCadastrarTlCad.Name = "BtnCadastrarTlCad";
            this.BtnCadastrarTlCad.Size = new System.Drawing.Size(112, 30);
            this.BtnCadastrarTlCad.TabIndex = 14;
            this.BtnCadastrarTlCad.Text = "CADASTRAR";
            this.BtnCadastrarTlCad.UseVisualStyleBackColor = false;
            this.BtnCadastrarTlCad.Click += new System.EventHandler(this.BtnCadastrarTlCad_Click);
            // 
            // TxtEmailTlCadProf
            // 
            this.TxtEmailTlCadProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmailTlCadProf.Location = new System.Drawing.Point(133, 104);
            this.TxtEmailTlCadProf.Name = "TxtEmailTlCadProf";
            this.TxtEmailTlCadProf.Size = new System.Drawing.Size(257, 24);
            this.TxtEmailTlCadProf.TabIndex = 11;
            // 
            // TxtNomeTlCadProf
            // 
            this.TxtNomeTlCadProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNomeTlCadProf.Location = new System.Drawing.Point(135, 61);
            this.TxtNomeTlCadProf.Name = "TxtNomeTlCadProf";
            this.TxtNomeTlCadProf.Size = new System.Drawing.Size(257, 24);
            this.TxtNomeTlCadProf.TabIndex = 9;
            // 
            // LblId
            // 
            this.LblId.AutoSize = true;
            this.LblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(139)))), ((int)(((byte)(31)))));
            this.LblId.Location = new System.Drawing.Point(6, 86);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(99, 15);
            this.LblId.TabIndex = 7;
            this.LblId.Text = "Matrícula(ID) :";
            // 
            // LblNomeCadProf
            // 
            this.LblNomeCadProf.AutoSize = true;
            this.LblNomeCadProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNomeCadProf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(139)))), ((int)(((byte)(31)))));
            this.LblNomeCadProf.Location = new System.Drawing.Point(132, 43);
            this.LblNomeCadProf.Name = "LblNomeCadProf";
            this.LblNomeCadProf.Size = new System.Drawing.Size(118, 15);
            this.LblNomeCadProf.TabIndex = 0;
            this.LblNomeCadProf.Text = "Nome Completo :";
            // 
            // LblDtNascProf
            // 
            this.LblDtNascProf.AutoSize = true;
            this.LblDtNascProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDtNascProf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(139)))), ((int)(((byte)(31)))));
            this.LblDtNascProf.Location = new System.Drawing.Point(422, 43);
            this.LblDtNascProf.Name = "LblDtNascProf";
            this.LblDtNascProf.Size = new System.Drawing.Size(145, 15);
            this.LblDtNascProf.TabIndex = 1;
            this.LblDtNascProf.Text = "Data de Nascimento :";
            // 
            // LblEmailProf
            // 
            this.LblEmailProf.AutoSize = true;
            this.LblEmailProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmailProf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(139)))), ((int)(((byte)(31)))));
            this.LblEmailProf.Location = new System.Drawing.Point(130, 86);
            this.LblEmailProf.Name = "LblEmailProf";
            this.LblEmailProf.Size = new System.Drawing.Size(57, 15);
            this.LblEmailProf.TabIndex = 2;
            this.LblEmailProf.Text = "E-mail :";
            // 
            // LblCPF
            // 
            this.LblCPF.AutoSize = true;
            this.LblCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCPF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(139)))), ((int)(((byte)(31)))));
            this.LblCPF.Location = new System.Drawing.Point(422, 84);
            this.LblCPF.Name = "LblCPF";
            this.LblCPF.Size = new System.Drawing.Size(41, 15);
            this.LblCPF.TabIndex = 4;
            this.LblCPF.Text = "CPF :";
            // 
            // TelaCadastroProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 550);
            this.Controls.Add(this.GpbCadProfessor);
            this.Controls.Add(this.DgvUsuarios);
            this.Name = "TelaCadastroProfessor";
            this.Text = "TelaCadastroProfessor";
            this.Load += new System.EventHandler(this.TelaCadastroProfessor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuarios)).EndInit();
            this.GpbCadProfessor.ResumeLayout(false);
            this.GpbCadProfessor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvUsuarios;
        private System.Windows.Forms.GroupBox GpbCadProfessor;
        private System.Windows.Forms.Label LblIdProf;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.DateTimePicker DtpDtNascimentoTlCadProf;
        private System.Windows.Forms.CheckBox CkbAtivoTlCadastroProf;
        private System.Windows.Forms.Button BtnCadastrarTlCad;
        private System.Windows.Forms.TextBox TxtEmailTlCadProf;
        private System.Windows.Forms.TextBox TxtNomeTlCadProf;
        private System.Windows.Forms.Label LblId;
        private System.Windows.Forms.Label LblNomeCadProf;
        private System.Windows.Forms.Label LblDtNascProf;
        private System.Windows.Forms.Label LblEmailProf;
        private System.Windows.Forms.Label LblCPF;
        private System.Windows.Forms.TextBox TxtNivelAcesso;
        private System.Windows.Forms.Label LblNivelAcesso;
        private System.Windows.Forms.TextBox TxtCpf;
        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.Button BtnAlterar;
    }
}