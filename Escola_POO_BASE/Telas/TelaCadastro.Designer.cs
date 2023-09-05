namespace Escola_POO_BASE.Telas
{
    partial class TelaCadastro
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
            this.GbxSelecao = new System.Windows.Forms.GroupBox();
            this.RdbCadastroProfessor = new System.Windows.Forms.RadioButton();
            this.RdbCadastroAluno = new System.Windows.Forms.RadioButton();
            this.LblCadId = new System.Windows.Forms.Label();
            this.LblCadNome = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblCadEmail = new System.Windows.Forms.Label();
            this.LblCadSenha = new System.Windows.Forms.Label();
            this.LblCadSenha2 = new System.Windows.Forms.Label();
            this.GpbTelaCadastro = new System.Windows.Forms.GroupBox();
            this.TxtCadNome = new System.Windows.Forms.TextBox();
            this.TxtCadNascimento = new System.Windows.Forms.TextBox();
            this.TxtCadEmail = new System.Windows.Forms.TextBox();
            this.TxtCadSenha1 = new System.Windows.Forms.TextBox();
            this.TxtCadSenha2 = new System.Windows.Forms.TextBox();
            this.BtnCadLimpar = new System.Windows.Forms.Button();
            this.BtnCadCadastrar = new System.Windows.Forms.Button();
            this.CkbCadSenha = new System.Windows.Forms.CheckBox();
            this.GbxSelecao.SuspendLayout();
            this.GpbTelaCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbxSelecao
            // 
            this.GbxSelecao.BackColor = System.Drawing.Color.Transparent;
            this.GbxSelecao.Controls.Add(this.RdbCadastroProfessor);
            this.GbxSelecao.Controls.Add(this.RdbCadastroAluno);
            this.GbxSelecao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbxSelecao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(141)))));
            this.GbxSelecao.Location = new System.Drawing.Point(6, 12);
            this.GbxSelecao.Name = "GbxSelecao";
            this.GbxSelecao.Size = new System.Drawing.Size(112, 74);
            this.GbxSelecao.TabIndex = 0;
            this.GbxSelecao.TabStop = false;
            this.GbxSelecao.Text = "Selecione :";
            // 
            // RdbCadastroProfessor
            // 
            this.RdbCadastroProfessor.AutoSize = true;
            this.RdbCadastroProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdbCadastroProfessor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(139)))), ((int)(((byte)(31)))));
            this.RdbCadastroProfessor.Location = new System.Drawing.Point(6, 49);
            this.RdbCadastroProfessor.Name = "RdbCadastroProfessor";
            this.RdbCadastroProfessor.Size = new System.Drawing.Size(101, 22);
            this.RdbCadastroProfessor.TabIndex = 2;
            this.RdbCadastroProfessor.Text = "Professor";
            this.RdbCadastroProfessor.UseVisualStyleBackColor = true;
            // 
            // RdbCadastroAluno
            // 
            this.RdbCadastroAluno.AutoSize = true;
            this.RdbCadastroAluno.Checked = true;
            this.RdbCadastroAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdbCadastroAluno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(139)))), ((int)(((byte)(31)))));
            this.RdbCadastroAluno.Location = new System.Drawing.Point(6, 21);
            this.RdbCadastroAluno.Name = "RdbCadastroAluno";
            this.RdbCadastroAluno.Size = new System.Drawing.Size(68, 22);
            this.RdbCadastroAluno.TabIndex = 1;
            this.RdbCadastroAluno.TabStop = true;
            this.RdbCadastroAluno.Text = "Aluno";
            this.RdbCadastroAluno.UseVisualStyleBackColor = true;
            // 
            // LblCadId
            // 
            this.LblCadId.AutoSize = true;
            this.LblCadId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCadId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(139)))), ((int)(((byte)(31)))));
            this.LblCadId.Location = new System.Drawing.Point(24, 50);
            this.LblCadId.Name = "LblCadId";
            this.LblCadId.Size = new System.Drawing.Size(167, 18);
            this.LblCadId.TabIndex = 1;
            this.LblCadId.Text = "Id gerado automático";
            // 
            // LblCadNome
            // 
            this.LblCadNome.AutoSize = true;
            this.LblCadNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCadNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(139)))), ((int)(((byte)(31)))));
            this.LblCadNome.Location = new System.Drawing.Point(24, 84);
            this.LblCadNome.Name = "LblCadNome";
            this.LblCadNome.Size = new System.Drawing.Size(141, 18);
            this.LblCadNome.TabIndex = 2;
            this.LblCadNome.Text = "Nome Completo :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(139)))), ((int)(((byte)(31)))));
            this.label3.Location = new System.Drawing.Point(24, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Data de Nascimento";
            // 
            // LblCadEmail
            // 
            this.LblCadEmail.AutoSize = true;
            this.LblCadEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCadEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(139)))), ((int)(((byte)(31)))));
            this.LblCadEmail.Location = new System.Drawing.Point(24, 184);
            this.LblCadEmail.Name = "LblCadEmail";
            this.LblCadEmail.Size = new System.Drawing.Size(66, 18);
            this.LblCadEmail.TabIndex = 4;
            this.LblCadEmail.Text = "E-mail :";
            // 
            // LblCadSenha
            // 
            this.LblCadSenha.AutoSize = true;
            this.LblCadSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCadSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(139)))), ((int)(((byte)(31)))));
            this.LblCadSenha.Location = new System.Drawing.Point(24, 234);
            this.LblCadSenha.Name = "LblCadSenha";
            this.LblCadSenha.Size = new System.Drawing.Size(328, 18);
            this.LblCadSenha.TabIndex = 5;
            this.LblCadSenha.Text = "Informe uma senha numérica de 6 dígitos :";
            // 
            // LblCadSenha2
            // 
            this.LblCadSenha2.AutoSize = true;
            this.LblCadSenha2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCadSenha2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(139)))), ((int)(((byte)(31)))));
            this.LblCadSenha2.Location = new System.Drawing.Point(24, 284);
            this.LblCadSenha2.Name = "LblCadSenha2";
            this.LblCadSenha2.Size = new System.Drawing.Size(190, 18);
            this.LblCadSenha2.TabIndex = 6;
            this.LblCadSenha2.Text = "Repita a mesma senha :";
            // 
            // GpbTelaCadastro
            // 
            this.GpbTelaCadastro.BackColor = System.Drawing.Color.Transparent;
            this.GpbTelaCadastro.Controls.Add(this.CkbCadSenha);
            this.GpbTelaCadastro.Controls.Add(this.TxtCadSenha2);
            this.GpbTelaCadastro.Controls.Add(this.TxtCadSenha1);
            this.GpbTelaCadastro.Controls.Add(this.TxtCadEmail);
            this.GpbTelaCadastro.Controls.Add(this.TxtCadNascimento);
            this.GpbTelaCadastro.Controls.Add(this.TxtCadNome);
            this.GpbTelaCadastro.Controls.Add(this.LblCadNome);
            this.GpbTelaCadastro.Controls.Add(this.LblCadSenha2);
            this.GpbTelaCadastro.Controls.Add(this.LblCadId);
            this.GpbTelaCadastro.Controls.Add(this.LblCadSenha);
            this.GpbTelaCadastro.Controls.Add(this.label3);
            this.GpbTelaCadastro.Controls.Add(this.LblCadEmail);
            this.GpbTelaCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GpbTelaCadastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(141)))));
            this.GpbTelaCadastro.Location = new System.Drawing.Point(6, 129);
            this.GpbTelaCadastro.Name = "GpbTelaCadastro";
            this.GpbTelaCadastro.Size = new System.Drawing.Size(418, 344);
            this.GpbTelaCadastro.TabIndex = 7;
            this.GpbTelaCadastro.TabStop = false;
            this.GpbTelaCadastro.Text = "Cadastre suas informações :";
            // 
            // TxtCadNome
            // 
            this.TxtCadNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(141)))));
            this.TxtCadNome.Location = new System.Drawing.Point(27, 105);
            this.TxtCadNome.Name = "TxtCadNome";
            this.TxtCadNome.Size = new System.Drawing.Size(364, 26);
            this.TxtCadNome.TabIndex = 7;
            // 
            // TxtCadNascimento
            // 
            this.TxtCadNascimento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtCadNascimento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(141)))));
            this.TxtCadNascimento.Location = new System.Drawing.Point(27, 155);
            this.TxtCadNascimento.Name = "TxtCadNascimento";
            this.TxtCadNascimento.Size = new System.Drawing.Size(123, 26);
            this.TxtCadNascimento.TabIndex = 8;
            // 
            // TxtCadEmail
            // 
            this.TxtCadEmail.BackColor = System.Drawing.SystemColors.Window;
            this.TxtCadEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(141)))));
            this.TxtCadEmail.Location = new System.Drawing.Point(27, 205);
            this.TxtCadEmail.Name = "TxtCadEmail";
            this.TxtCadEmail.Size = new System.Drawing.Size(261, 26);
            this.TxtCadEmail.TabIndex = 9;
            // 
            // TxtCadSenha1
            // 
            this.TxtCadSenha1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(141)))));
            this.TxtCadSenha1.Location = new System.Drawing.Point(27, 255);
            this.TxtCadSenha1.Name = "TxtCadSenha1";
            this.TxtCadSenha1.Size = new System.Drawing.Size(100, 26);
            this.TxtCadSenha1.TabIndex = 10;
            this.TxtCadSenha1.UseSystemPasswordChar = true;
            // 
            // TxtCadSenha2
            // 
            this.TxtCadSenha2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(141)))));
            this.TxtCadSenha2.Location = new System.Drawing.Point(27, 305);
            this.TxtCadSenha2.Name = "TxtCadSenha2";
            this.TxtCadSenha2.Size = new System.Drawing.Size(100, 26);
            this.TxtCadSenha2.TabIndex = 11;
            this.TxtCadSenha2.UseSystemPasswordChar = true;
            // 
            // BtnCadLimpar
            // 
            this.BtnCadLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(141)))));
            this.BtnCadLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCadLimpar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(139)))), ((int)(((byte)(31)))));
            this.BtnCadLimpar.Location = new System.Drawing.Point(78, 499);
            this.BtnCadLimpar.Name = "BtnCadLimpar";
            this.BtnCadLimpar.Size = new System.Drawing.Size(93, 35);
            this.BtnCadLimpar.TabIndex = 12;
            this.BtnCadLimpar.Text = "LIMPAR";
            this.BtnCadLimpar.UseVisualStyleBackColor = false;
            this.BtnCadLimpar.Click += new System.EventHandler(this.BtnCadLimpar_Click);
            // 
            // BtnCadCadastrar
            // 
            this.BtnCadCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(141)))));
            this.BtnCadCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCadCadastrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(139)))), ((int)(((byte)(31)))));
            this.BtnCadCadastrar.Location = new System.Drawing.Point(226, 499);
            this.BtnCadCadastrar.Name = "BtnCadCadastrar";
            this.BtnCadCadastrar.Size = new System.Drawing.Size(116, 35);
            this.BtnCadCadastrar.TabIndex = 13;
            this.BtnCadCadastrar.Text = "CADASTRAR";
            this.BtnCadCadastrar.UseVisualStyleBackColor = false;
            this.BtnCadCadastrar.Click += new System.EventHandler(this.BtnCadCadastrar_Click);
            // 
            // CkbCadSenha
            // 
            this.CkbCadSenha.AutoSize = true;
            this.CkbCadSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CkbCadSenha.Location = new System.Drawing.Point(133, 257);
            this.CkbCadSenha.Name = "CkbCadSenha";
            this.CkbCadSenha.Size = new System.Drawing.Size(89, 19);
            this.CkbCadSenha.TabIndex = 12;
            this.CkbCadSenha.Text = "Visualizar";
            this.CkbCadSenha.UseVisualStyleBackColor = true;
            this.CkbCadSenha.CheckedChanged += new System.EventHandler(this.CkbCadSenha_CheckedChanged);
            // 
            // TelaCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Escola_POO_BASE.Properties.Resources.LogoSenac;
            this.ClientSize = new System.Drawing.Size(430, 588);
            this.Controls.Add(this.BtnCadCadastrar);
            this.Controls.Add(this.GpbTelaCadastro);
            this.Controls.Add(this.BtnCadLimpar);
            this.Controls.Add(this.GbxSelecao);
            this.Name = "TelaCadastro";
            this.Text = "TelaCadastro";
            this.GbxSelecao.ResumeLayout(false);
            this.GbxSelecao.PerformLayout();
            this.GpbTelaCadastro.ResumeLayout(false);
            this.GpbTelaCadastro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbxSelecao;
        private System.Windows.Forms.RadioButton RdbCadastroProfessor;
        private System.Windows.Forms.RadioButton RdbCadastroAluno;
        private System.Windows.Forms.Label LblCadId;
        private System.Windows.Forms.Label LblCadNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblCadEmail;
        private System.Windows.Forms.Label LblCadSenha;
        private System.Windows.Forms.Label LblCadSenha2;
        private System.Windows.Forms.GroupBox GpbTelaCadastro;
        private System.Windows.Forms.TextBox TxtCadSenha2;
        private System.Windows.Forms.TextBox TxtCadSenha1;
        private System.Windows.Forms.TextBox TxtCadEmail;
        private System.Windows.Forms.TextBox TxtCadNascimento;
        private System.Windows.Forms.TextBox TxtCadNome;
        private System.Windows.Forms.Button BtnCadLimpar;
        private System.Windows.Forms.Button BtnCadCadastrar;
        private System.Windows.Forms.CheckBox CkbCadSenha;
    }
}