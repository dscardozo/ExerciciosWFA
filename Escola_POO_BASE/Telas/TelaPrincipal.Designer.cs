namespace Escola_POO_BASE.Telas
{
    partial class TelaPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            this.StsBarraStatus = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.TspNomeLogado = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.TssEmailLogado = new System.Windows.Forms.ToolStripStatusLabel();
            this.TslPerfil = new System.Windows.Forms.ToolStripStatusLabel();
            this.TslPerfilLogado = new System.Windows.Forms.ToolStripStatusLabel();
            this.TssDataHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.MnsMenu = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.TspAlterarSenha = new System.Windows.Forms.ToolStripMenuItem();
            this.TsiCadastros = new System.Windows.Forms.ToolStripMenuItem();
            this.alunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.professorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TmrRelogio = new System.Windows.Forms.Timer(this.components);
            this.StsBarraStatus.SuspendLayout();
            this.MnsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // StsBarraStatus
            // 
            this.StsBarraStatus.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.StsBarraStatus.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.StsBarraStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.TspNomeLogado,
            this.toolStripStatusLabel2,
            this.TssEmailLogado,
            this.TslPerfil,
            this.TslPerfilLogado,
            this.TssDataHora});
            this.StsBarraStatus.Location = new System.Drawing.Point(0, 503);
            this.StsBarraStatus.Name = "StsBarraStatus";
            this.StsBarraStatus.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.StsBarraStatus.Size = new System.Drawing.Size(780, 24);
            this.StsBarraStatus.TabIndex = 2;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter;
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(141)))));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(109, 19);
            this.toolStripStatusLabel1.Text = "Usuário Logado: ";
            // 
            // TspNomeLogado
            // 
            this.TspNomeLogado.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.TspNomeLogado.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.TspNomeLogado.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TspNomeLogado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TspNomeLogado.Name = "TspNomeLogado";
            this.TspNomeLogado.Size = new System.Drawing.Size(46, 19);
            this.TspNomeLogado.Text = "Danilo";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter;
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(141)))));
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(52, 19);
            this.toolStripStatusLabel2.Text = "E-mail: ";
            // 
            // TssEmailLogado
            // 
            this.TssEmailLogado.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.TssEmailLogado.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.TssEmailLogado.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TssEmailLogado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TssEmailLogado.Name = "TssEmailLogado";
            this.TssEmailLogado.Size = new System.Drawing.Size(145, 19);
            this.TssEmailLogado.Text = "dscardozo@hotmail.com";
            // 
            // TslPerfil
            // 
            this.TslPerfil.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter;
            this.TslPerfil.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TslPerfil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(141)))));
            this.TslPerfil.Name = "TslPerfil";
            this.TslPerfil.Size = new System.Drawing.Size(47, 19);
            this.TslPerfil.Text = "Perfil :";
            // 
            // TslPerfilLogado
            // 
            this.TslPerfilLogado.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.TslPerfilLogado.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.TslPerfilLogado.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TslPerfilLogado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TslPerfilLogado.Name = "TslPerfilLogado";
            this.TslPerfilLogado.Size = new System.Drawing.Size(43, 19);
            this.TslPerfilLogado.Text = "Aluno";
            // 
            // TssDataHora
            // 
            this.TssDataHora.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter;
            this.TssDataHora.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TssDataHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(141)))));
            this.TssDataHora.Name = "TssDataHora";
            this.TssDataHora.RightToLeftAutoMirrorImage = true;
            this.TssDataHora.Size = new System.Drawing.Size(321, 19);
            this.TssDataHora.Spring = true;
            this.TssDataHora.Text = "quinta-feira,17 de agosto 2023 | 09:38:25";
            this.TssDataHora.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TssDataHora.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // MnsMenu
            // 
            this.MnsMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MnsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.TsiCadastros,
            this.sairToolStripMenuItem});
            this.MnsMenu.Location = new System.Drawing.Point(0, 0);
            this.MnsMenu.Name = "MnsMenu";
            this.MnsMenu.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.MnsMenu.Size = new System.Drawing.Size(780, 24);
            this.MnsMenu.TabIndex = 3;
            this.MnsMenu.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TspAlterarSenha});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(141)))));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(68, 20);
            this.toolStripMenuItem1.Text = "Arquivo";
            // 
            // TspAlterarSenha
            // 
            this.TspAlterarSenha.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TspAlterarSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(141)))));
            this.TspAlterarSenha.Name = "TspAlterarSenha";
            this.TspAlterarSenha.Size = new System.Drawing.Size(150, 22);
            this.TspAlterarSenha.Text = "Alterar Senha";
            this.TspAlterarSenha.Click += new System.EventHandler(this.TspAlterarSenha_Click);
            // 
            // TsiCadastros
            // 
            this.TsiCadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alunoToolStripMenuItem,
            this.professorToolStripMenuItem});
            this.TsiCadastros.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TsiCadastros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(141)))));
            this.TsiCadastros.Name = "TsiCadastros";
            this.TsiCadastros.Size = new System.Drawing.Size(77, 20);
            this.TsiCadastros.Text = "Cadastrar";
            // 
            // alunoToolStripMenuItem
            // 
            this.alunoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alunoToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(141)))));
            this.alunoToolStripMenuItem.Name = "alunoToolStripMenuItem";
            this.alunoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.alunoToolStripMenuItem.Text = "Aluno";
            this.alunoToolStripMenuItem.Click += new System.EventHandler(this.alunoToolStripMenuItem_Click);
            // 
            // professorToolStripMenuItem
            // 
            this.professorToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.professorToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(141)))));
            this.professorToolStripMenuItem.Name = "professorToolStripMenuItem";
            this.professorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.professorToolStripMenuItem.Text = "Professor";
            this.professorToolStripMenuItem.Click += new System.EventHandler(this.professorToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sairToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(141)))));
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sairToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // TmrRelogio
            // 
            this.TmrRelogio.Tick += new System.EventHandler(this.TmrRelogio_Tick);
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(780, 527);
            this.Controls.Add(this.StsBarraStatus);
            this.Controls.Add(this.MnsMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MnsMenu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaPrincipal";
            this.Load += new System.EventHandler(this.TelaPrincipal_Load);
            this.StsBarraStatus.ResumeLayout(false);
            this.StsBarraStatus.PerformLayout();
            this.MnsMenu.ResumeLayout(false);
            this.MnsMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip StsBarraStatus;
        private System.Windows.Forms.MenuStrip MnsMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem TspAlterarSenha;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel TspNomeLogado;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel TssEmailLogado;
        private System.Windows.Forms.ToolStripStatusLabel TssDataHora;
        private System.Windows.Forms.ToolStripStatusLabel TslPerfil;
        private System.Windows.Forms.ToolStripStatusLabel TslPerfilLogado;
        private System.Windows.Forms.ToolStripMenuItem TsiCadastros;
        private System.Windows.Forms.ToolStripMenuItem alunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem professorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Timer TmrRelogio;
    }
}