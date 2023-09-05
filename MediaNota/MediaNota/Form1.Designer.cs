namespace MediaNota
{
    partial class Form1
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
            this.LblNota1 = new System.Windows.Forms.Label();
            this.LblNota2 = new System.Windows.Forms.Label();
            this.LblNota3 = new System.Windows.Forms.Label();
            this.LblResultado = new System.Windows.Forms.Label();
            this.TxtNota1 = new System.Windows.Forms.TextBox();
            this.TxtNota2 = new System.Windows.Forms.TextBox();
            this.TxtNota3 = new System.Windows.Forms.TextBox();
            this.BtnCalcularMedia = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.LblNome = new System.Windows.Forms.Label();
            this.TxtNomeAluno = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblNota1
            // 
            this.LblNota1.AutoSize = true;
            this.LblNota1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNota1.Location = new System.Drawing.Point(13, 14);
            this.LblNota1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNota1.Name = "LblNota1";
            this.LblNota1.Size = new System.Drawing.Size(148, 18);
            this.LblNota1.TabIndex = 0;
            this.LblNota1.Text = "Informe a 1ª nota :";
            // 
            // LblNota2
            // 
            this.LblNota2.AutoSize = true;
            this.LblNota2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNota2.Location = new System.Drawing.Point(13, 54);
            this.LblNota2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNota2.Name = "LblNota2";
            this.LblNota2.Size = new System.Drawing.Size(148, 18);
            this.LblNota2.TabIndex = 1;
            this.LblNota2.Text = "Informe a 2ª nota :";
            // 
            // LblNota3
            // 
            this.LblNota3.AutoSize = true;
            this.LblNota3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNota3.Location = new System.Drawing.Point(13, 95);
            this.LblNota3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNota3.Name = "LblNota3";
            this.LblNota3.Size = new System.Drawing.Size(148, 18);
            this.LblNota3.TabIndex = 2;
            this.LblNota3.Text = "Informe a 3ª nota :";
            // 
            // LblResultado
            // 
            this.LblResultado.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblResultado.Location = new System.Drawing.Point(17, 208);
            this.LblResultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblResultado.Name = "LblResultado";
            this.LblResultado.Size = new System.Drawing.Size(182, 60);
            this.LblResultado.TabIndex = 3;
            // 
            // TxtNota1
            // 
            this.TxtNota1.Location = new System.Drawing.Point(162, 11);
            this.TxtNota1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtNota1.Name = "TxtNota1";
            this.TxtNota1.Size = new System.Drawing.Size(37, 20);
            this.TxtNota1.TabIndex = 4;
            // 
            // TxtNota2
            // 
            this.TxtNota2.Location = new System.Drawing.Point(162, 51);
            this.TxtNota2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtNota2.Name = "TxtNota2";
            this.TxtNota2.Size = new System.Drawing.Size(37, 20);
            this.TxtNota2.TabIndex = 5;
            // 
            // TxtNota3
            // 
            this.TxtNota3.Location = new System.Drawing.Point(162, 92);
            this.TxtNota3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtNota3.Name = "TxtNota3";
            this.TxtNota3.Size = new System.Drawing.Size(37, 20);
            this.TxtNota3.TabIndex = 6;
            // 
            // BtnCalcularMedia
            // 
            this.BtnCalcularMedia.ForeColor = System.Drawing.Color.Red;
            this.BtnCalcularMedia.Location = new System.Drawing.Point(17, 172);
            this.BtnCalcularMedia.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnCalcularMedia.Name = "BtnCalcularMedia";
            this.BtnCalcularMedia.Size = new System.Drawing.Size(88, 23);
            this.BtnCalcularMedia.TabIndex = 7;
            this.BtnCalcularMedia.Text = "CALCULAR";
            this.BtnCalcularMedia.UseVisualStyleBackColor = true;
            this.BtnCalcularMedia.Click += new System.EventHandler(this.BtnCalcularMedia_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.ForeColor = System.Drawing.Color.Blue;
            this.BtnLimpar.Location = new System.Drawing.Point(111, 172);
            this.BtnLimpar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(88, 23);
            this.BtnLimpar.TabIndex = 8;
            this.BtnLimpar.Text = "LIMPAR";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNome.Location = new System.Drawing.Point(14, 125);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(137, 18);
            this.LblNome.TabIndex = 9;
            this.LblNome.Text = "Informe o nome :";
            // 
            // TxtNomeAluno
            // 
            this.TxtNomeAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNomeAluno.Location = new System.Drawing.Point(17, 146);
            this.TxtNomeAluno.Name = "TxtNomeAluno";
            this.TxtNomeAluno.Size = new System.Drawing.Size(182, 22);
            this.TxtNomeAluno.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(213, 286);
            this.Controls.Add(this.TxtNomeAluno);
            this.Controls.Add(this.LblNome);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnCalcularMedia);
            this.Controls.Add(this.TxtNota3);
            this.Controls.Add(this.TxtNota2);
            this.Controls.Add(this.TxtNota1);
            this.Controls.Add(this.LblResultado);
            this.Controls.Add(this.LblNota3);
            this.Controls.Add(this.LblNota2);
            this.Controls.Add(this.LblNota1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "MÉDIA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNota1;
        private System.Windows.Forms.Label LblNota2;
        private System.Windows.Forms.Label LblNota3;
        private System.Windows.Forms.Label LblResultado;
        private System.Windows.Forms.TextBox TxtNota1;
        private System.Windows.Forms.TextBox TxtNota2;
        private System.Windows.Forms.TextBox TxtNota3;
        private System.Windows.Forms.Button BtnCalcularMedia;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.TextBox TxtNomeAluno;
    }
}

