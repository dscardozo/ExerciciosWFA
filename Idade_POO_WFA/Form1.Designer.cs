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
            this.LblAno = new System.Windows.Forms.Label();
            this.LblMeses = new System.Windows.Forms.Label();
            this.LblDia = new System.Windows.Forms.Label();
            this.LblResult = new System.Windows.Forms.Label();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.TxtAnos = new System.Windows.Forms.TextBox();
            this.TxtMes = new System.Windows.Forms.TextBox();
            this.TxtDia = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNome.Location = new System.Drawing.Point(54, 71);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(153, 16);
            this.LblNome.TabIndex = 0;
            this.LblNome.Text = "Informe o seu Nome :";
            // 
            // LblAno
            // 
            this.LblAno.AutoSize = true;
            this.LblAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAno.Location = new System.Drawing.Point(54, 126);
            this.LblAno.Name = "LblAno";
            this.LblAno.Size = new System.Drawing.Size(230, 16);
            this.LblAno.TabIndex = 1;
            this.LblAno.Text = "Informe quantos anos você tem :";
            // 
            // LblMeses
            // 
            this.LblMeses.AutoSize = true;
            this.LblMeses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMeses.Location = new System.Drawing.Point(54, 175);
            this.LblMeses.Name = "LblMeses";
            this.LblMeses.Size = new System.Drawing.Size(179, 16);
            this.LblMeses.TabIndex = 2;
            this.LblMeses.Text = "Informe quantos mêses  :";
            // 
            // LblDia
            // 
            this.LblDia.AutoSize = true;
            this.LblDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDia.Location = new System.Drawing.Point(54, 224);
            this.LblDia.Name = "LblDia";
            this.LblDia.Size = new System.Drawing.Size(159, 16);
            this.LblDia.TabIndex = 3;
            this.LblDia.Text = "Informe quantos dias :";
            // 
            // LblResult
            // 
            this.LblResult.BackColor = System.Drawing.SystemColors.HighlightText;
            this.LblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblResult.Location = new System.Drawing.Point(57, 330);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(264, 86);
            this.LblResult.TabIndex = 4;
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalcular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnCalcular.Location = new System.Drawing.Point(57, 274);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(97, 23);
            this.BtnCalcular.TabIndex = 5;
            this.BtnCalcular.Text = "CALCULAR";
            this.BtnCalcular.UseVisualStyleBackColor = false;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpar.ForeColor = System.Drawing.Color.Blue;
            this.BtnLimpar.Location = new System.Drawing.Point(237, 274);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(84, 23);
            this.BtnLimpar.TabIndex = 6;
            this.BtnLimpar.Text = "LIMPAR";
            this.BtnLimpar.UseVisualStyleBackColor = false;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // TxtNome
            // 
            this.TxtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNome.Location = new System.Drawing.Point(57, 90);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(264, 22);
            this.TxtNome.TabIndex = 7;
            // 
            // TxtAnos
            // 
            this.TxtAnos.Location = new System.Drawing.Point(284, 122);
            this.TxtAnos.Name = "TxtAnos";
            this.TxtAnos.Size = new System.Drawing.Size(37, 20);
            this.TxtAnos.TabIndex = 8;
            // 
            // TxtMes
            // 
            this.TxtMes.Location = new System.Drawing.Point(284, 171);
            this.TxtMes.Name = "TxtMes";
            this.TxtMes.Size = new System.Drawing.Size(37, 20);
            this.TxtMes.TabIndex = 9;
            // 
            // TxtDia
            // 
            this.TxtDia.Location = new System.Drawing.Point(284, 220);
            this.TxtDia.Name = "TxtDia";
            this.TxtDia.Size = new System.Drawing.Size(37, 20);
            this.TxtDia.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 453);
            this.Controls.Add(this.TxtDia);
            this.Controls.Add(this.TxtMes);
            this.Controls.Add(this.TxtAnos);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.LblResult);
            this.Controls.Add(this.LblDia);
            this.Controls.Add(this.LblMeses);
            this.Controls.Add(this.LblAno);
            this.Controls.Add(this.LblNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.Label LblAno;
        private System.Windows.Forms.Label LblMeses;
        private System.Windows.Forms.Label LblDia;
        private System.Windows.Forms.Label LblResult;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.TextBox TxtAnos;
        private System.Windows.Forms.TextBox TxtMes;
        private System.Windows.Forms.TextBox TxtDia;
    }
}

