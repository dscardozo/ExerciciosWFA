namespace MacasPOO_IF_WFA
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
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.TxtNumMacas = new System.Windows.Forms.TextBox();
            this.LblResultado = new System.Windows.Forms.Label();
            this.LblNumMacas = new System.Windows.Forms.Label();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalcular.ForeColor = System.Drawing.Color.Crimson;
            this.BtnCalcular.Location = new System.Drawing.Point(181, 217);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(93, 35);
            this.BtnCalcular.TabIndex = 0;
            this.BtnCalcular.Text = "CALCULAR\r\n";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // TxtNumMacas
            // 
            this.TxtNumMacas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumMacas.Location = new System.Drawing.Point(207, 178);
            this.TxtNumMacas.Name = "TxtNumMacas";
            this.TxtNumMacas.Size = new System.Drawing.Size(41, 22);
            this.TxtNumMacas.TabIndex = 2;
            this.TxtNumMacas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblResultado
            // 
            this.LblResultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblResultado.Location = new System.Drawing.Point(96, 290);
            this.LblResultado.Name = "LblResultado";
            this.LblResultado.Size = new System.Drawing.Size(296, 158);
            this.LblResultado.TabIndex = 3;
            this.LblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblNumMacas
            // 
            this.LblNumMacas.AutoSize = true;
            this.LblNumMacas.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LblNumMacas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumMacas.Location = new System.Drawing.Point(29, 77);
            this.LblNumMacas.Name = "LblNumMacas";
            this.LblNumMacas.Size = new System.Drawing.Size(397, 87);
            this.LblNumMacas.TabIndex = 1;
            this.LblNumMacas.Text = "            MAÇÃS       R$ 0,30 Cada.\r\nÀ partir de 1 Dúzia R$ 0,25 Cada.\r\n     In" +
    "forme o Nº de Maçãs :";
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnLimpar.Location = new System.Drawing.Point(190, 258);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(75, 23);
            this.BtnLimpar.TabIndex = 4;
            this.BtnLimpar.Text = "LIMPAR";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 457);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.LblResultado);
            this.Controls.Add(this.TxtNumMacas);
            this.Controls.Add(this.LblNumMacas);
            this.Controls.Add(this.BtnCalcular);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Maçãs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.Label LblNumMacas;
        private System.Windows.Forms.TextBox TxtNumMacas;
        private System.Windows.Forms.Label LblResultado;
        private System.Windows.Forms.Button BtnLimpar;
    }
}

