namespace LampadasWFA
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
            this.LblEnunciado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.TxtPotencia = new System.Windows.Forms.TextBox();
            this.TxtLargura = new System.Windows.Forms.TextBox();
            this.TxtComprimento = new System.Windows.Forms.TextBox();
            this.LblResultado = new System.Windows.Forms.Label();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblEnunciado
            // 
            this.LblEnunciado.AutoSize = true;
            this.LblEnunciado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEnunciado.Location = new System.Drawing.Point(30, 9);
            this.LblEnunciado.Name = "LblEnunciado";
            this.LblEnunciado.Size = new System.Drawing.Size(744, 30);
            this.LblEnunciado.TabIndex = 0;
            this.LblEnunciado.Text = "Calcular e imprimir o número de lâmpadas necessárias para iluminar um determinado" +
    " cômodo de uma residência.\r\nDados de entrada:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(365, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "- A potência da lâmpada utilizada (em watts)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "- Largura do cômodo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "- Comprimento do cômodo";
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalcular.Location = new System.Drawing.Point(302, 286);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(83, 23);
            this.BtnCalcular.TabIndex = 4;
            this.BtnCalcular.Text = "CALCULAR";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // TxtPotencia
            // 
            this.TxtPotencia.Location = new System.Drawing.Point(434, 81);
            this.TxtPotencia.Name = "TxtPotencia";
            this.TxtPotencia.Size = new System.Drawing.Size(33, 20);
            this.TxtPotencia.TabIndex = 5;
            // 
            // TxtLargura
            // 
            this.TxtLargura.Location = new System.Drawing.Point(434, 153);
            this.TxtLargura.Name = "TxtLargura";
            this.TxtLargura.Size = new System.Drawing.Size(33, 20);
            this.TxtLargura.TabIndex = 6;
            // 
            // TxtComprimento
            // 
            this.TxtComprimento.Location = new System.Drawing.Point(434, 222);
            this.TxtComprimento.Name = "TxtComprimento";
            this.TxtComprimento.Size = new System.Drawing.Size(33, 20);
            this.TxtComprimento.TabIndex = 7;
            // 
            // LblResultado
            // 
            this.LblResultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblResultado.Location = new System.Drawing.Point(434, 286);
            this.LblResultado.Name = "LblResultado";
            this.LblResultado.Size = new System.Drawing.Size(354, 113);
            this.LblResultado.TabIndex = 8;
            this.LblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpar.Location = new System.Drawing.Point(302, 362);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(83, 23);
            this.BtnLimpar.TabIndex = 9;
            this.BtnLimpar.Text = "LIMPAR";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.LblResultado);
            this.Controls.Add(this.TxtComprimento);
            this.Controls.Add(this.TxtLargura);
            this.Controls.Add(this.TxtPotencia);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblEnunciado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblEnunciado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.TextBox TxtPotencia;
        private System.Windows.Forms.TextBox TxtLargura;
        private System.Windows.Forms.TextBox TxtComprimento;
        private System.Windows.Forms.Label LblResultado;
        private System.Windows.Forms.Button BtnLimpar;
    }
}

