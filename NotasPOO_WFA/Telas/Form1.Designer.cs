namespace NotasPOO_WFA
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
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.TxtNota1 = new System.Windows.Forms.TextBox();
            this.TxtNota2 = new System.Windows.Forms.TextBox();
            this.TxtNota3 = new System.Windows.Forms.TextBox();
            this.LblNomeAluno = new System.Windows.Forms.Label();
            this.TxtNomeAluno = new System.Windows.Forms.TextBox();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblNota1
            // 
            this.LblNota1.AutoSize = true;
            this.LblNota1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNota1.Location = new System.Drawing.Point(51, 69);
            this.LblNota1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNota1.Name = "LblNota1";
            this.LblNota1.Size = new System.Drawing.Size(134, 16);
            this.LblNota1.TabIndex = 0;
            this.LblNota1.Text = "Informe a 1ª Nota :";
            // 
            // LblNota2
            // 
            this.LblNota2.AutoSize = true;
            this.LblNota2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNota2.Location = new System.Drawing.Point(51, 118);
            this.LblNota2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNota2.Name = "LblNota2";
            this.LblNota2.Size = new System.Drawing.Size(134, 16);
            this.LblNota2.TabIndex = 1;
            this.LblNota2.Text = "Informe a 2ª Nota :";
            // 
            // LblNota3
            // 
            this.LblNota3.AutoSize = true;
            this.LblNota3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNota3.Location = new System.Drawing.Point(51, 165);
            this.LblNota3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNota3.Name = "LblNota3";
            this.LblNota3.Size = new System.Drawing.Size(134, 32);
            this.LblNota3.TabIndex = 2;
            this.LblNota3.Text = "Informe a 3ª Nota :\r\n      (Optativa)";
            // 
            // LblResultado
            // 
            this.LblResultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblResultado.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.LblResultado.Location = new System.Drawing.Point(55, 301);
            this.LblResultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblResultado.Name = "LblResultado";
            this.LblResultado.Size = new System.Drawing.Size(336, 124);
            this.LblResultado.TabIndex = 3;
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalcular.ForeColor = System.Drawing.Color.Red;
            this.BtnCalcular.Location = new System.Drawing.Point(278, 256);
            this.BtnCalcular.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(113, 23);
            this.BtnCalcular.TabIndex = 4;
            this.BtnCalcular.Text = "CALCULAR";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // TxtNota1
            // 
            this.TxtNota1.Location = new System.Drawing.Point(274, 68);
            this.TxtNota1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtNota1.Name = "TxtNota1";
            this.TxtNota1.Size = new System.Drawing.Size(116, 20);
            this.TxtNota1.TabIndex = 5;
            this.TxtNota1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtNota2
            // 
            this.TxtNota2.Location = new System.Drawing.Point(274, 115);
            this.TxtNota2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtNota2.Name = "TxtNota2";
            this.TxtNota2.Size = new System.Drawing.Size(116, 20);
            this.TxtNota2.TabIndex = 6;
            this.TxtNota2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtNota3
            // 
            this.TxtNota3.AutoCompleteCustomSource.AddRange(new string[] {
            "0"});
            this.TxtNota3.CausesValidation = false;
            this.TxtNota3.Location = new System.Drawing.Point(274, 161);
            this.TxtNota3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtNota3.Name = "TxtNota3";
            this.TxtNota3.Size = new System.Drawing.Size(116, 20);
            this.TxtNota3.TabIndex = 7;
            this.TxtNota3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblNomeAluno
            // 
            this.LblNomeAluno.AutoSize = true;
            this.LblNomeAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNomeAluno.Location = new System.Drawing.Point(55, 209);
            this.LblNomeAluno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNomeAluno.Name = "LblNomeAluno";
            this.LblNomeAluno.Size = new System.Drawing.Size(178, 15);
            this.LblNomeAluno.TabIndex = 8;
            this.LblNomeAluno.Text = "Informe o Nome do Aluno :";
            // 
            // TxtNomeAluno
            // 
            this.TxtNomeAluno.Location = new System.Drawing.Point(274, 204);
            this.TxtNomeAluno.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtNomeAluno.Name = "TxtNomeAluno";
            this.TxtNomeAluno.Size = new System.Drawing.Size(116, 20);
            this.TxtNomeAluno.TabIndex = 9;
            this.TxtNomeAluno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpar.ForeColor = System.Drawing.Color.Blue;
            this.BtnLimpar.Location = new System.Drawing.Point(124, 256);
            this.BtnLimpar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(88, 23);
            this.BtnLimpar.TabIndex = 10;
            this.BtnLimpar.Text = "LIMPAR";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 464);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.TxtNomeAluno);
            this.Controls.Add(this.LblNomeAluno);
            this.Controls.Add(this.TxtNota3);
            this.Controls.Add(this.TxtNota2);
            this.Controls.Add(this.TxtNota1);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.LblResultado);
            this.Controls.Add(this.LblNota3);
            this.Controls.Add(this.LblNota2);
            this.Controls.Add(this.LblNota1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Notas Média";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNota1;
        private System.Windows.Forms.Label LblNota2;
        private System.Windows.Forms.Label LblNota3;
        private System.Windows.Forms.Label LblResultado;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.TextBox TxtNota1;
        private System.Windows.Forms.TextBox TxtNota2;
        private System.Windows.Forms.TextBox TxtNota3;
        private System.Windows.Forms.Label LblNomeAluno;
        private System.Windows.Forms.TextBox TxtNomeAluno;
        private System.Windows.Forms.Button BtnLimpar;
    }
}

