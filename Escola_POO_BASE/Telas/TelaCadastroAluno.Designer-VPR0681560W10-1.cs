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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastroAluno));
            this.LblNomeCadAluno = new System.Windows.Forms.Label();
            this.LblDtNasc = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.LblDtMatricula = new System.Windows.Forms.Label();
            this.GpbCadAluno = new System.Windows.Forms.GroupBox();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.DtpDtMatriculaTlCad = new System.Windows.Forms.DateTimePicker();
            this.DtpDtNascimentoTlCad = new System.Windows.Forms.DateTimePicker();
            this.CkbAtivoTlCadastro = new System.Windows.Forms.CheckBox();
            this.BtnCadastrarTlCad = new System.Windows.Forms.Button();
            this.TxtEmailTlCad = new System.Windows.Forms.TextBox();
            this.TxtNomeTlCad = new System.Windows.Forms.TextBox();
            this.TxtIdCadastro = new System.Windows.Forms.TextBox();
            this.LblId = new System.Windows.Forms.Label();
            this.DgvUsuarios = new System.Windows.Forms.DataGridView();
            this.GpbCadAluno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // LblNomeCadAluno
            // 
            this.LblNomeCadAluno.AutoSize = true;
            this.LblNomeCadAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNomeCadAluno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(139)))), ((int)(((byte)(31)))));
            this.LblNomeCadAluno.Location = new System.Drawing.Point(6, 66);
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
            this.LblDtNasc.Location = new System.Drawing.Point(6, 109);
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
            this.LblEmail.Location = new System.Drawing.Point(6, 157);
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
            this.LblDtMatricula.Location = new System.Drawing.Point(3, 198);
            this.LblDtMatricula.Name = "LblDtMatricula";
            this.LblDtMatricula.Size = new System.Drawing.Size(129, 15);
            this.LblDtMatricula.TabIndex = 4;
            this.LblDtMatricula.Text = "Data de Matrícula :";
            // 
            // GpbCadAluno
            // 
            this.GpbCadAluno.Controls.Add(this.BtnCancelar);
            this.GpbCadAluno.Controls.Add(this.BtnLimpar);
            this.GpbCadAluno.Controls.Add(this.DtpDtMatriculaTlCad);
            this.GpbCadAluno.Controls.Add(this.DtpDtNascimentoTlCad);
            this.GpbCadAluno.Controls.Add(this.CkbAtivoTlCadastro);
            this.GpbCadAluno.Controls.Add(this.BtnCadastrarTlCad);
            this.GpbCadAluno.Controls.Add(this.TxtEmailTlCad);
            this.GpbCadAluno.Controls.Add(this.TxtNomeTlCad);
            this.GpbCadAluno.Controls.Add(this.TxtIdCadastro);
            this.GpbCadAluno.Controls.Add(this.LblId);
            this.GpbCadAluno.Controls.Add(this.LblNomeCadAluno);
            this.GpbCadAluno.Controls.Add(this.LblDtNasc);
            this.GpbCadAluno.Controls.Add(this.LblEmail);
            this.GpbCadAluno.Controls.Add(this.LblDtMatricula);
            this.GpbCadAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GpbCadAluno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(141)))));
            this.GpbCadAluno.Location = new System.Drawing.Point(12, 12);
            this.GpbCadAluno.Name = "GpbCadAluno";
            this.GpbCadAluno.Size = new System.Drawing.Size(422, 295);
            this.GpbCadAluno.TabIndex = 7;
            this.GpbCadAluno.TabStop = false;
            this.GpbCadAluno.Text = "CADASTRO :";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(139)))), ((int)(((byte)(31)))));
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Location = new System.Drawing.Point(6, 250);
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
            this.BtnLimpar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(139)))), ((int)(((byte)(31)))));
            this.BtnLimpar.Location = new System.Drawing.Point(298, 250);
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
            this.DtpDtMatriculaTlCad.Location = new System.Drawing.Point(153, 198);
            this.DtpDtMatriculaTlCad.Name = "DtpDtMatriculaTlCad";
            this.DtpDtMatriculaTlCad.Size = new System.Drawing.Size(257, 20);
            this.DtpDtMatriculaTlCad.TabIndex = 17;
            // 
            // DtpDtNascimentoTlCad
            // 
            this.DtpDtNascimentoTlCad.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpDtNascimentoTlCad.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.DtpDtNascimentoTlCad.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.DtpDtNascimentoTlCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpDtNascimentoTlCad.Location = new System.Drawing.Point(153, 100);
            this.DtpDtNascimentoTlCad.Name = "DtpDtNascimentoTlCad";
            this.DtpDtNascimentoTlCad.Size = new System.Drawing.Size(257, 20);
            this.DtpDtNascimentoTlCad.TabIndex = 16;
            // 
            // CkbAtivoTlCadastro
            // 
            this.CkbAtivoTlCadastro.AutoSize = true;
            this.CkbAtivoTlCadastro.Checked = true;
            this.CkbAtivoTlCadastro.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CkbAtivoTlCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CkbAtivoTlCadastro.Location = new System.Drawing.Point(341, 23);
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
            this.BtnCadastrarTlCad.Location = new System.Drawing.Point(153, 250);
            this.BtnCadastrarTlCad.Name = "BtnCadastrarTlCad";
            this.BtnCadastrarTlCad.Size = new System.Drawing.Size(112, 30);
            this.BtnCadastrarTlCad.TabIndex = 14;
            this.BtnCadastrarTlCad.Text = "CADASTRAR";
            this.BtnCadastrarTlCad.UseVisualStyleBackColor = false;
            this.BtnCadastrarTlCad.Click += new System.EventHandler(this.BtnCadastrarTlCad_Click);
            // 
            // TxtEmailTlCad
            // 
            this.TxtEmailTlCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmailTlCad.Location = new System.Drawing.Point(153, 148);
            this.TxtEmailTlCad.Name = "TxtEmailTlCad";
            this.TxtEmailTlCad.Size = new System.Drawing.Size(257, 24);
            this.TxtEmailTlCad.TabIndex = 11;
            // 
            // TxtNomeTlCad
            // 
            this.TxtNomeTlCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNomeTlCad.Location = new System.Drawing.Point(153, 57);
            this.TxtNomeTlCad.Name = "TxtNomeTlCad";
            this.TxtNomeTlCad.Size = new System.Drawing.Size(257, 24);
            this.TxtNomeTlCad.TabIndex = 9;
            // 
            // TxtIdCadastro
            // 
            this.TxtIdCadastro.BackColor = System.Drawing.SystemColors.Control;
            this.TxtIdCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIdCadastro.Location = new System.Drawing.Point(153, 23);
            this.TxtIdCadastro.Name = "TxtIdCadastro";
            this.TxtIdCadastro.Size = new System.Drawing.Size(95, 24);
            this.TxtIdCadastro.TabIndex = 8;
            this.TxtIdCadastro.Visible = false;
            // 
            // LblId
            // 
            this.LblId.AutoSize = true;
            this.LblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(139)))), ((int)(((byte)(31)))));
            this.LblId.Location = new System.Drawing.Point(6, 32);
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
            this.DgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvUsuarios.Location = new System.Drawing.Point(440, 112);
            this.DgvUsuarios.MultiSelect = false;
            this.DgvUsuarios.Name = "DgvUsuarios";
            this.DgvUsuarios.ReadOnly = true;
            this.DgvUsuarios.RowHeadersVisible = false;
            this.DgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvUsuarios.Size = new System.Drawing.Size(397, 195);
            this.DgvUsuarios.TabIndex = 9;
            // 
            // TelaCadastroAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 319);
            this.Controls.Add(this.DgvUsuarios);
            this.Controls.Add(this.GpbCadAluno);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaCadastroAluno";
            this.Text = "TelaCadastroAluno";
            this.Load += new System.EventHandler(this.TelaCadastroAluno_Load);
            this.GpbCadAluno.ResumeLayout(false);
            this.GpbCadAluno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuarios)).EndInit();
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
        private System.Windows.Forms.TextBox TxtIdCadastro;
        private System.Windows.Forms.DateTimePicker DtpDtMatriculaTlCad;
        private System.Windows.Forms.DateTimePicker DtpDtNascimentoTlCad;
        private System.Windows.Forms.CheckBox CkbAtivoTlCadastro;
        private System.Windows.Forms.Button BtnCadastrarTlCad;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.DataGridView DgvUsuarios;
    }
}