namespace Idade_POO_WFA
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
            this.LblNome = new System.Windows.Forms.Label();
            this.LblIdade = new System.Windows.Forms.Label();
            this.LblMeses = new System.Windows.Forms.Label();
            this.LblDias = new System.Windows.Forms.Label();
            this.LblResultado = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.TxtIdade = new System.Windows.Forms.TextBox();
            this.TxtMeses = new System.Windows.Forms.TextBox();
            this.TxtDias = new System.Windows.Forms.TextBox();
            this.LblResultadoInverso = new System.Windows.Forms.Label();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.BtnCalculoInverso = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNome.Location = new System.Drawing.Point(5, 15);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(140, 16);
            this.LblNome.TabIndex = 0;
            this.LblNome.Text = "Informe seu Nome :";
            // 
            // LblIdade
            // 
            this.LblIdade.AutoSize = true;
            this.LblIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIdade.Location = new System.Drawing.Point(5, 54);
            this.LblIdade.Name = "LblIdade";
            this.LblIdade.Size = new System.Drawing.Size(152, 16);
            this.LblIdade.TabIndex = 1;
            this.LblIdade.Text = "Informe a sua idade :";
            // 
            // LblMeses
            // 
            this.LblMeses.AutoSize = true;
            this.LblMeses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMeses.Location = new System.Drawing.Point(5, 95);
            this.LblMeses.Name = "LblMeses";
            this.LblMeses.Size = new System.Drawing.Size(137, 16);
            this.LblMeses.TabIndex = 2;
            this.LblMeses.Text = "Informe os meses :";
            // 
            // LblDias
            // 
            this.LblDias.AutoSize = true;
            this.LblDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDias.Location = new System.Drawing.Point(5, 135);
            this.LblDias.Name = "LblDias";
            this.LblDias.Size = new System.Drawing.Size(121, 16);
            this.LblDias.TabIndex = 3;
            this.LblDias.Text = "Informe os dias :";
            // 
            // LblResultado
            // 
            this.LblResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblResultado.Location = new System.Drawing.Point(5, 226);
            this.LblResultado.Name = "LblResultado";
            this.LblResultado.Size = new System.Drawing.Size(199, 75);
            this.LblResultado.TabIndex = 4;
            this.LblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(157, 12);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(195, 20);
            this.TxtNome.TabIndex = 5;
            // 
            // TxtIdade
            // 
            this.TxtIdade.Location = new System.Drawing.Point(157, 51);
            this.TxtIdade.Name = "TxtIdade";
            this.TxtIdade.Size = new System.Drawing.Size(35, 20);
            this.TxtIdade.TabIndex = 6;
            // 
            // TxtMeses
            // 
            this.TxtMeses.Location = new System.Drawing.Point(157, 92);
            this.TxtMeses.Name = "TxtMeses";
            this.TxtMeses.Size = new System.Drawing.Size(35, 20);
            this.TxtMeses.TabIndex = 7;
            // 
            // TxtDias
            // 
            this.TxtDias.Location = new System.Drawing.Point(157, 132);
            this.TxtDias.Name = "TxtDias";
            this.TxtDias.Size = new System.Drawing.Size(35, 20);
            this.TxtDias.TabIndex = 8;
            // 
            // LblResultadoInverso
            // 
            this.LblResultadoInverso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblResultadoInverso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblResultadoInverso.Location = new System.Drawing.Point(220, 226);
            this.LblResultadoInverso.Name = "LblResultadoInverso";
            this.LblResultadoInverso.Size = new System.Drawing.Size(196, 75);
            this.LblResultadoInverso.TabIndex = 9;
            this.LblResultadoInverso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalcular.ForeColor = System.Drawing.Color.Red;
            this.BtnCalcular.Location = new System.Drawing.Point(49, 175);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(93, 23);
            this.BtnCalcular.TabIndex = 10;
            this.BtnCalcular.Text = "CALCULAR";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // BtnCalculoInverso
            // 
            this.BtnCalculoInverso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalculoInverso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnCalculoInverso.Location = new System.Drawing.Point(277, 175);
            this.BtnCalculoInverso.Name = "BtnCalculoInverso";
            this.BtnCalculoInverso.Size = new System.Drawing.Size(75, 23);
            this.BtnCalculoInverso.TabIndex = 11;
            this.BtnCalculoInverso.Text = "INVERSO";
            this.BtnCalculoInverso.UseVisualStyleBackColor = true;
            this.BtnCalculoInverso.Click += new System.EventHandler(this.BtnCalculoInverso_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnLimpar.Location = new System.Drawing.Point(170, 175);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(75, 23);
            this.BtnLimpar.TabIndex = 12;
            this.BtnLimpar.Text = "LIMPAR";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 304);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnCalculoInverso);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.LblResultadoInverso);
            this.Controls.Add(this.TxtDias);
            this.Controls.Add(this.TxtMeses);
            this.Controls.Add(this.TxtIdade);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.LblResultado);
            this.Controls.Add(this.LblDias);
            this.Controls.Add(this.LblMeses);
            this.Controls.Add(this.LblIdade);
            this.Controls.Add(this.LblNome);
            this.Name = "Form1";
            this.Text = "IDADE EM DIAS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.Label LblIdade;
        private System.Windows.Forms.Label LblMeses;
        private System.Windows.Forms.Label LblDias;
        private System.Windows.Forms.Label LblResultado;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.TextBox TxtIdade;
        private System.Windows.Forms.TextBox TxtMeses;
        private System.Windows.Forms.TextBox TxtDias;
        private System.Windows.Forms.Label LblResultadoInverso;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.Button BtnCalculoInverso;
        private System.Windows.Forms.Button BtnLimpar;
    }
}

