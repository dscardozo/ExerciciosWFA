namespace OlaMundoWFA
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
            this.BtnMostrar = new System.Windows.Forms.Button();
            this.TxtFrase = new System.Windows.Forms.TextBox();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnMostrar
            // 
            this.BtnMostrar.Location = new System.Drawing.Point(187, 120);
            this.BtnMostrar.Margin = new System.Windows.Forms.Padding(6);
            this.BtnMostrar.Name = "BtnMostrar";
            this.BtnMostrar.Size = new System.Drawing.Size(150, 44);
            this.BtnMostrar.TabIndex = 0;
            this.BtnMostrar.Text = "Mostrar";
            this.BtnMostrar.UseVisualStyleBackColor = true;
            this.BtnMostrar.Click += new System.EventHandler(this.BtnMostrar_Click);
            // 
            // TxtFrase
            // 
            this.TxtFrase.Location = new System.Drawing.Point(187, 62);
            this.TxtFrase.Name = "TxtFrase";
            this.TxtFrase.Size = new System.Drawing.Size(287, 31);
            this.TxtFrase.TabIndex = 1;
            this.TxtFrase.TextChanged += new System.EventHandler(this.TxtFrase_TextChanged);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Location = new System.Drawing.Point(346, 120);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(128, 44);
            this.BtnLimpar.TabIndex = 2;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 268);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.TxtFrase);
            this.Controls.Add(this.BtnMostrar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnMostrar;
        private System.Windows.Forms.TextBox TxtFrase;
        private System.Windows.Forms.Button BtnLimpar;
    }
}

