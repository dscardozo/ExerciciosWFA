namespace Escola_POO_BASE.Telas
{
    partial class TelaAltSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaAltSenha));
            this.GpbAltSenha = new System.Windows.Forms.GroupBox();
            this.CkbVisualizar = new System.Windows.Forms.CheckBox();
            this.BtnAltSenhaLimpar = new System.Windows.Forms.Button();
            this.BtnConfirmar = new System.Windows.Forms.Button();
            this.TxtRepeteSenha = new System.Windows.Forms.TextBox();
            this.LblConfirmaSenha = new System.Windows.Forms.Label();
            this.TxtNovaSenha = new System.Windows.Forms.TextBox();
            this.LblNovaSenha = new System.Windows.Forms.Label();
            this.TxtSenhaAtual = new System.Windows.Forms.TextBox();
            this.Lbl = new System.Windows.Forms.Label();
            this.GpbAltSenha.SuspendLayout();
            this.SuspendLayout();
            // 
            // GpbAltSenha
            // 
            this.GpbAltSenha.Controls.Add(this.CkbVisualizar);
            this.GpbAltSenha.Controls.Add(this.BtnAltSenhaLimpar);
            this.GpbAltSenha.Controls.Add(this.BtnConfirmar);
            this.GpbAltSenha.Controls.Add(this.TxtRepeteSenha);
            this.GpbAltSenha.Controls.Add(this.LblConfirmaSenha);
            this.GpbAltSenha.Controls.Add(this.TxtNovaSenha);
            this.GpbAltSenha.Controls.Add(this.LblNovaSenha);
            this.GpbAltSenha.Controls.Add(this.TxtSenhaAtual);
            this.GpbAltSenha.Controls.Add(this.Lbl);
            this.GpbAltSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GpbAltSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(141)))));
            this.GpbAltSenha.Location = new System.Drawing.Point(12, 12);
            this.GpbAltSenha.Name = "GpbAltSenha";
            this.GpbAltSenha.Size = new System.Drawing.Size(288, 204);
            this.GpbAltSenha.TabIndex = 0;
            this.GpbAltSenha.TabStop = false;
            this.GpbAltSenha.Text = "Altera Senha ";
            // 
            // CkbVisualizar
            // 
            this.CkbVisualizar.AutoSize = true;
            this.CkbVisualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CkbVisualizar.Location = new System.Drawing.Point(176, 121);
            this.CkbVisualizar.Name = "CkbVisualizar";
            this.CkbVisualizar.Size = new System.Drawing.Size(80, 17);
            this.CkbVisualizar.TabIndex = 8;
            this.CkbVisualizar.Text = "Vizualizar";
            this.CkbVisualizar.UseVisualStyleBackColor = true;
            this.CkbVisualizar.CheckedChanged += new System.EventHandler(this.CkbVisualizar_CheckedChanged);
            // 
            // BtnAltSenhaLimpar
            // 
            this.BtnAltSenhaLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(141)))));
            this.BtnAltSenhaLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAltSenhaLimpar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(139)))), ((int)(((byte)(31)))));
            this.BtnAltSenhaLimpar.Location = new System.Drawing.Point(158, 143);
            this.BtnAltSenhaLimpar.Name = "BtnAltSenhaLimpar";
            this.BtnAltSenhaLimpar.Size = new System.Drawing.Size(119, 30);
            this.BtnAltSenhaLimpar.TabIndex = 5;
            this.BtnAltSenhaLimpar.Text = "LIMPAR";
            this.BtnAltSenhaLimpar.UseVisualStyleBackColor = false;
            this.BtnAltSenhaLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // BtnConfirmar
            // 
            this.BtnConfirmar.AutoSize = true;
            this.BtnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(141)))));
            this.BtnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfirmar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(139)))), ((int)(((byte)(31)))));
            this.BtnConfirmar.Location = new System.Drawing.Point(9, 143);
            this.BtnConfirmar.Name = "BtnConfirmar";
            this.BtnConfirmar.Size = new System.Drawing.Size(119, 30);
            this.BtnConfirmar.TabIndex = 4;
            this.BtnConfirmar.Text = "CONFIRMAR";
            this.BtnConfirmar.UseVisualStyleBackColor = false;
            this.BtnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click);
            // 
            // TxtRepeteSenha
            // 
            this.TxtRepeteSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(141)))));
            this.TxtRepeteSenha.Location = new System.Drawing.Point(177, 90);
            this.TxtRepeteSenha.Name = "TxtRepeteSenha";
            this.TxtRepeteSenha.Size = new System.Drawing.Size(100, 22);
            this.TxtRepeteSenha.TabIndex = 3;
            this.TxtRepeteSenha.UseSystemPasswordChar = true;
            this.TxtRepeteSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtRepeteSenha_KeyPress);
            // 
            // LblConfirmaSenha
            // 
            this.LblConfirmaSenha.AutoSize = true;
            this.LblConfirmaSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(139)))), ((int)(((byte)(31)))));
            this.LblConfirmaSenha.Location = new System.Drawing.Point(6, 96);
            this.LblConfirmaSenha.Name = "LblConfirmaSenha";
            this.LblConfirmaSenha.Size = new System.Drawing.Size(170, 16);
            this.LblConfirmaSenha.TabIndex = 4;
            this.LblConfirmaSenha.Text = "Repita a mesma senha:";
            // 
            // TxtNovaSenha
            // 
            this.TxtNovaSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(141)))));
            this.TxtNovaSenha.Location = new System.Drawing.Point(177, 57);
            this.TxtNovaSenha.Name = "TxtNovaSenha";
            this.TxtNovaSenha.Size = new System.Drawing.Size(100, 22);
            this.TxtNovaSenha.TabIndex = 2;
            this.TxtNovaSenha.UseSystemPasswordChar = true;
            this.TxtNovaSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNovaSenha_KeyPress);
            // 
            // LblNovaSenha
            // 
            this.LblNovaSenha.AutoSize = true;
            this.LblNovaSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(139)))), ((int)(((byte)(31)))));
            this.LblNovaSenha.Location = new System.Drawing.Point(6, 63);
            this.LblNovaSenha.Name = "LblNovaSenha";
            this.LblNovaSenha.Size = new System.Drawing.Size(159, 16);
            this.LblNovaSenha.TabIndex = 2;
            this.LblNovaSenha.Text = "Digite a nova Senha : ";
            // 
            // TxtSenhaAtual
            // 
            this.TxtSenhaAtual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(141)))));
            this.TxtSenhaAtual.Location = new System.Drawing.Point(177, 26);
            this.TxtSenhaAtual.Name = "TxtSenhaAtual";
            this.TxtSenhaAtual.Size = new System.Drawing.Size(100, 22);
            this.TxtSenhaAtual.TabIndex = 1;
            this.TxtSenhaAtual.UseSystemPasswordChar = true;
            this.TxtSenhaAtual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSenhaAtual_KeyPress);
            // 
            // Lbl
            // 
            this.Lbl.AutoSize = true;
            this.Lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(139)))), ((int)(((byte)(31)))));
            this.Lbl.Location = new System.Drawing.Point(6, 32);
            this.Lbl.Name = "Lbl";
            this.Lbl.Size = new System.Drawing.Size(165, 16);
            this.Lbl.TabIndex = 0;
            this.Lbl.Text = "Informe a Senha atual :";
            // 
            // TelaAltSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 228);
            this.Controls.Add(this.GpbAltSenha);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaAltSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Alterar Senha";
            this.GpbAltSenha.ResumeLayout(false);
            this.GpbAltSenha.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GpbAltSenha;
        private System.Windows.Forms.Label Lbl;
        private System.Windows.Forms.TextBox TxtSenhaAtual;
        private System.Windows.Forms.TextBox TxtRepeteSenha;
        private System.Windows.Forms.Label LblConfirmaSenha;
        private System.Windows.Forms.TextBox TxtNovaSenha;
        private System.Windows.Forms.Label LblNovaSenha;
        private System.Windows.Forms.Button BtnAltSenhaLimpar;
        private System.Windows.Forms.Button BtnConfirmar;
        private System.Windows.Forms.CheckBox CkbVisualizar;
    }
}