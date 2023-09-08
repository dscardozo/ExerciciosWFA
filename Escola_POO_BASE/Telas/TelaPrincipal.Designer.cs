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
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblRemovidos = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LblAtivos = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblQtdAlunos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblTotalProf = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LblProfAtivos = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LblProfInativo = new System.Windows.Forms.Label();
            this.StsBarraStatus.SuspendLayout();
            this.MnsMenu.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.StsBarraStatus.Location = new System.Drawing.Point(0, 598);
            this.StsBarraStatus.Name = "StsBarraStatus";
            this.StsBarraStatus.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.StsBarraStatus.Size = new System.Drawing.Size(988, 24);
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
            this.TssDataHora.Size = new System.Drawing.Size(529, 19);
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
            this.MnsMenu.Size = new System.Drawing.Size(988, 24);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.LblTotalProf);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.LblProfAtivos);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.LblProfInativo);
            this.panel1.Controls.Add(this.LblRemovidos);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.LblAtivos);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.LblQtdAlunos);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 570);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(988, 28);
            this.panel1.TabIndex = 5;
            
            // 
            // LblRemovidos
            // 
            this.LblRemovidos.AutoSize = true;
            this.LblRemovidos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblRemovidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRemovidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblRemovidos.Location = new System.Drawing.Point(429, 9);
            this.LblRemovidos.Name = "LblRemovidos";
            this.LblRemovidos.Size = new System.Drawing.Size(16, 15);
            this.LblRemovidos.TabIndex = 11;
            this.LblRemovidos.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(141)))));
            this.label5.Location = new System.Drawing.Point(304, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Alunos Removidos :";
            // 
            // LblAtivos
            // 
            this.LblAtivos.AutoSize = true;
            this.LblAtivos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblAtivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAtivos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblAtivos.Location = new System.Drawing.Point(273, 9);
            this.LblAtivos.Name = "LblAtivos";
            this.LblAtivos.Size = new System.Drawing.Size(16, 15);
            this.LblAtivos.TabIndex = 9;
            this.LblAtivos.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(141)))));
            this.label3.Location = new System.Drawing.Point(175, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Alunos Ativos :";
            // 
            // LblQtdAlunos
            // 
            this.LblQtdAlunos.AutoSize = true;
            this.LblQtdAlunos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblQtdAlunos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblQtdAlunos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblQtdAlunos.Location = new System.Drawing.Point(142, 9);
            this.LblQtdAlunos.Name = "LblQtdAlunos";
            this.LblQtdAlunos.Size = new System.Drawing.Size(16, 15);
            this.LblQtdAlunos.TabIndex = 7;
            this.LblQtdAlunos.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(141)))));
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Quantidade de Aluno :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(141)))));
            this.label2.Location = new System.Drawing.Point(478, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Quantidade de Professores :";
            // 
            // LblTotalProf
            // 
            this.LblTotalProf.AutoSize = true;
            this.LblTotalProf.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblTotalProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalProf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblTotalProf.Location = new System.Drawing.Point(652, 7);
            this.LblTotalProf.Name = "LblTotalProf";
            this.LblTotalProf.Size = new System.Drawing.Size(16, 15);
            this.LblTotalProf.TabIndex = 8;
            this.LblTotalProf.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(141)))));
            this.label6.Location = new System.Drawing.Point(674, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Professores Ativos :";
            // 
            // LblProfAtivos
            // 
            this.LblProfAtivos.AutoSize = true;
            this.LblProfAtivos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblProfAtivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProfAtivos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblProfAtivos.Location = new System.Drawing.Point(800, 7);
            this.LblProfAtivos.Name = "LblProfAtivos";
            this.LblProfAtivos.Size = new System.Drawing.Size(16, 15);
            this.LblProfAtivos.TabIndex = 10;
            this.LblProfAtivos.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(141)))));
            this.label8.Location = new System.Drawing.Point(822, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Professores Inativos :";
            // 
            // LblProfInativo
            // 
            this.LblProfInativo.AutoSize = true;
            this.LblProfInativo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblProfInativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProfInativo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblProfInativo.Location = new System.Drawing.Point(958, 7);
            this.LblProfInativo.Name = "LblProfInativo";
            this.LblProfInativo.Size = new System.Drawing.Size(16, 15);
            this.LblProfInativo.TabIndex = 12;
            this.LblProfInativo.Text = "0";
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(988, 622);
            this.Controls.Add(this.panel1);
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
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TelaPrincipal_Load);
            this.StsBarraStatus.ResumeLayout(false);
            this.StsBarraStatus.PerformLayout();
            this.MnsMenu.ResumeLayout(false);
            this.MnsMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblRemovidos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblAtivos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblQtdAlunos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblTotalProf;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LblProfAtivos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LblProfInativo;
    }
}