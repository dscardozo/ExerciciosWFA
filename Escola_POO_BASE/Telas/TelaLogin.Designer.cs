namespace Escola_POO_BASE.Telas
{
    partial class TelaLogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaLogin));
            this.LblEmail = new System.Windows.Forms.Label();
            this.LblSenha = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtSenha = new System.Windows.Forms.TextBox();
            this.GbxLogin = new System.Windows.Forms.GroupBox();
            this.ChkVisualizarSenha = new System.Windows.Forms.CheckBox();
            this.GbxSelecao = new System.Windows.Forms.GroupBox();
            this.RdbProfessor = new System.Windows.Forms.RadioButton();
            this.RdbAluno = new System.Windows.Forms.RadioButton();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.GbxLogin.SuspendLayout();
            this.GbxSelecao.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(139)))), ((int)(((byte)(31)))));
            this.LblEmail.Location = new System.Drawing.Point(7, 22);
            this.LblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(195, 24);
            this.LblEmail.TabIndex = 0;
            this.LblEmail.Text = "Informe seu e-mail :";
            // 
            // LblSenha
            // 
            this.LblSenha.AutoSize = true;
            this.LblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(139)))), ((int)(((byte)(31)))));
            this.LblSenha.Location = new System.Drawing.Point(7, 73);
            this.LblSenha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblSenha.Name = "LblSenha";
            this.LblSenha.Size = new System.Drawing.Size(180, 24);
            this.LblSenha.TabIndex = 1;
            this.LblSenha.Text = "Digite sua Senha :";
            // 
            // TxtEmail
            // 
            this.TxtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(139)))), ((int)(((byte)(31)))));
            this.TxtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(141)))));
            this.TxtEmail.Location = new System.Drawing.Point(12, 49);
            this.TxtEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(297, 21);
            this.TxtEmail.TabIndex = 0;
            this.TxtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtEmail_KeyPress);
            // 
            // TxtSenha
            // 
            this.TxtSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(139)))), ((int)(((byte)(31)))));
            this.TxtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(141)))));
            this.TxtSenha.Location = new System.Drawing.Point(12, 100);
            this.TxtSenha.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.Size = new System.Drawing.Size(116, 21);
            this.TxtSenha.TabIndex = 1;
            this.TxtSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtSenha.UseSystemPasswordChar = true;
            this.TxtSenha.WordWrap = false;
            this.TxtSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSenha_KeyPress);
            // 
            // GbxLogin
            // 
            this.GbxLogin.BackColor = System.Drawing.Color.LightSteelBlue;
            this.GbxLogin.Controls.Add(this.ChkVisualizarSenha);
            this.GbxLogin.Controls.Add(this.LblEmail);
            this.GbxLogin.Controls.Add(this.TxtSenha);
            this.GbxLogin.Controls.Add(this.LblSenha);
            this.GbxLogin.Controls.Add(this.TxtEmail);
            this.GbxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbxLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(141)))));
            this.GbxLogin.Location = new System.Drawing.Point(14, 98);
            this.GbxLogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GbxLogin.Name = "GbxLogin";
            this.GbxLogin.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GbxLogin.Size = new System.Drawing.Size(322, 158);
            this.GbxLogin.TabIndex = 1;
            this.GbxLogin.TabStop = false;
            this.GbxLogin.Text = "Faça seu Login :";
            // 
            // ChkVisualizarSenha
            // 
            this.ChkVisualizarSenha.AutoSize = true;
            this.ChkVisualizarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkVisualizarSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(139)))), ((int)(((byte)(31)))));
            this.ChkVisualizarSenha.Location = new System.Drawing.Point(11, 127);
            this.ChkVisualizarSenha.Name = "ChkVisualizarSenha";
            this.ChkVisualizarSenha.Size = new System.Drawing.Size(80, 17);
            this.ChkVisualizarSenha.TabIndex = 2;
            this.ChkVisualizarSenha.Text = "Visualizar";
            this.ChkVisualizarSenha.UseVisualStyleBackColor = true;
            this.ChkVisualizarSenha.CheckedChanged += new System.EventHandler(this.ChkVisualizarSenha_CheckedChanged);
            // 
            // GbxSelecao
            // 
            this.GbxSelecao.BackColor = System.Drawing.Color.LightSteelBlue;
            this.GbxSelecao.Controls.Add(this.RdbProfessor);
            this.GbxSelecao.Controls.Add(this.RdbAluno);
            this.GbxSelecao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbxSelecao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(141)))));
            this.GbxSelecao.Location = new System.Drawing.Point(14, 12);
            this.GbxSelecao.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GbxSelecao.Name = "GbxSelecao";
            this.GbxSelecao.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GbxSelecao.Size = new System.Drawing.Size(174, 80);
            this.GbxSelecao.TabIndex = 0;
            this.GbxSelecao.TabStop = false;
            this.GbxSelecao.Text = "Selecione :";
            // 
            // RdbProfessor
            // 
            this.RdbProfessor.AutoSize = true;
            this.RdbProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdbProfessor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(139)))), ((int)(((byte)(31)))));
            this.RdbProfessor.Location = new System.Drawing.Point(31, 45);
            this.RdbProfessor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RdbProfessor.Name = "RdbProfessor";
            this.RdbProfessor.Size = new System.Drawing.Size(92, 20);
            this.RdbProfessor.TabIndex = 0;
            this.RdbProfessor.TabStop = true;
            this.RdbProfessor.Text = "Professor";
            this.RdbProfessor.UseVisualStyleBackColor = true;
            this.RdbProfessor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RdbProfessor_KeyPress);
            // 
            // RdbAluno
            // 
            this.RdbAluno.AutoSize = true;
            this.RdbAluno.Checked = true;
            this.RdbAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdbAluno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(139)))), ((int)(((byte)(31)))));
            this.RdbAluno.Location = new System.Drawing.Point(31, 19);
            this.RdbAluno.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RdbAluno.Name = "RdbAluno";
            this.RdbAluno.Size = new System.Drawing.Size(64, 20);
            this.RdbAluno.TabIndex = 1;
            this.RdbAluno.TabStop = true;
            this.RdbAluno.Text = "Aluno";
            this.RdbAluno.UseVisualStyleBackColor = true;
            this.RdbAluno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RdbAluno_KeyPress);
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(141)))));
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(139)))), ((int)(((byte)(31)))));
            this.BtnLogin.Location = new System.Drawing.Point(26, 272);
            this.BtnLogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(128, 36);
            this.BtnLogin.TabIndex = 2;
            this.BtnLogin.Text = "LOGIN";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(141)))));
            this.BtnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(139)))), ((int)(((byte)(31)))));
            this.BtnLimpar.Location = new System.Drawing.Point(195, 272);
            this.BtnLimpar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(128, 36);
            this.BtnLimpar.TabIndex = 3;
            this.BtnLimpar.Text = "LIMPAR";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 319);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(349, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // TelaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Escola_POO_BASE.Properties.Resources.senacLogoLogin;
            this.ClientSize = new System.Drawing.Size(349, 341);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.GbxSelecao);
            this.Controls.Add(this.GbxLogin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(141)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "TelaLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaLogin";
            this.GbxLogin.ResumeLayout(false);
            this.GbxLogin.PerformLayout();
            this.GbxSelecao.ResumeLayout(false);
            this.GbxSelecao.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Label LblSenha;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtSenha;
        private System.Windows.Forms.GroupBox GbxLogin;
        private System.Windows.Forms.GroupBox GbxSelecao;
        private System.Windows.Forms.RadioButton RdbProfessor;
        private System.Windows.Forms.RadioButton RdbAluno;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.CheckBox ChkVisualizarSenha;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

