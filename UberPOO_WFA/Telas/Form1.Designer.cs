namespace UberPOO_WFA
{
    partial class UberForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UberForm));
            this.LblKmInicio = new System.Windows.Forms.Label();
            this.LblKmFimDia = new System.Windows.Forms.Label();
            this.LblCombutivel = new System.Windows.Forms.Label();
            this.LblValorRecebido = new System.Windows.Forms.Label();
            this.LblResultado = new System.Windows.Forms.Label();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.TxtKmInicio = new System.Windows.Forms.TextBox();
            this.TxtKmFimDia = new System.Windows.Forms.TextBox();
            this.TxtConsumoCombustivel = new System.Windows.Forms.TextBox();
            this.TxtValorFimDia = new System.Windows.Forms.TextBox();
            this.TxtTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblKmInicio
            // 
            this.LblKmInicio.AutoSize = true;
            this.LblKmInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblKmInicio.Location = new System.Drawing.Point(15, 91);
            this.LblKmInicio.Name = "LblKmInicio";
            this.LblKmInicio.Size = new System.Drawing.Size(169, 20);
            this.LblKmInicio.TabIndex = 0;
            this.LblKmInicio.Text = "Km do início do dia :";
            // 
            // LblKmFimDia
            // 
            this.LblKmFimDia.AutoSize = true;
            this.LblKmFimDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblKmFimDia.Location = new System.Drawing.Point(15, 135);
            this.LblKmFimDia.Name = "LblKmFimDia";
            this.LblKmFimDia.Size = new System.Drawing.Size(152, 20);
            this.LblKmFimDia.TabIndex = 1;
            this.LblKmFimDia.Text = "Km do fim do dia :";
            // 
            // LblCombutivel
            // 
            this.LblCombutivel.AutoSize = true;
            this.LblCombutivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCombutivel.Location = new System.Drawing.Point(16, 184);
            this.LblCombutivel.Name = "LblCombutivel";
            this.LblCombutivel.Size = new System.Drawing.Size(409, 18);
            this.LblCombutivel.TabIndex = 2;
            this.LblCombutivel.Text = "Consumo de combustível gasto no período em Litro :";
            // 
            // LblValorRecebido
            // 
            this.LblValorRecebido.AutoSize = true;
            this.LblValorRecebido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblValorRecebido.Location = new System.Drawing.Point(16, 231);
            this.LblValorRecebido.Name = "LblValorRecebido";
            this.LblValorRecebido.Size = new System.Drawing.Size(333, 18);
            this.LblValorRecebido.TabIndex = 3;
            this.LblValorRecebido.Text = "Valor total (R$) recebido dos passageiros :";
            // 
            // LblResultado
            // 
            this.LblResultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblResultado.Location = new System.Drawing.Point(18, 324);
            this.LblResultado.Name = "LblResultado";
            this.LblResultado.Size = new System.Drawing.Size(482, 76);
            this.LblResultado.TabIndex = 4;
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalcular.ForeColor = System.Drawing.Color.Red;
            this.BtnCalcular.Location = new System.Drawing.Point(180, 277);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(88, 31);
            this.BtnCalcular.TabIndex = 5;
            this.BtnCalcular.Text = "CALCULAR";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpar.ForeColor = System.Drawing.Color.Blue;
            this.BtnLimpar.Location = new System.Drawing.Point(274, 277);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(87, 31);
            this.BtnLimpar.TabIndex = 6;
            this.BtnLimpar.Text = "LIMPAR";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // TxtKmInicio
            // 
            this.TxtKmInicio.Location = new System.Drawing.Point(386, 91);
            this.TxtKmInicio.Name = "TxtKmInicio";
            this.TxtKmInicio.Size = new System.Drawing.Size(114, 20);
            this.TxtKmInicio.TabIndex = 7;
            // 
            // TxtKmFimDia
            // 
            this.TxtKmFimDia.Location = new System.Drawing.Point(386, 135);
            this.TxtKmFimDia.Name = "TxtKmFimDia";
            this.TxtKmFimDia.Size = new System.Drawing.Size(114, 20);
            this.TxtKmFimDia.TabIndex = 8;
            // 
            // TxtConsumoCombustivel
            // 
            this.TxtConsumoCombustivel.Location = new System.Drawing.Point(456, 182);
            this.TxtConsumoCombustivel.Name = "TxtConsumoCombustivel";
            this.TxtConsumoCombustivel.Size = new System.Drawing.Size(44, 20);
            this.TxtConsumoCombustivel.TabIndex = 9;
            // 
            // TxtValorFimDia
            // 
            this.TxtValorFimDia.Location = new System.Drawing.Point(436, 229);
            this.TxtValorFimDia.Name = "TxtValorFimDia";
            this.TxtValorFimDia.Size = new System.Drawing.Size(64, 20);
            this.TxtValorFimDia.TabIndex = 10;
            // 
            // TxtTitulo
            // 
            this.TxtTitulo.AutoSize = true;
            this.TxtTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTitulo.Location = new System.Drawing.Point(19, 28);
            this.TxtTitulo.Name = "TxtTitulo";
            this.TxtTitulo.Size = new System.Drawing.Size(481, 42);
            this.TxtTitulo.TabIndex = 11;
            this.TxtTitulo.Text = "Para calcular a Média de Km rodados por Litro consumido, \r\nInsira as informações " +
    "a seguir: ";
            // 
            // UberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(518, 415);
            this.Controls.Add(this.TxtTitulo);
            this.Controls.Add(this.TxtValorFimDia);
            this.Controls.Add(this.TxtConsumoCombustivel);
            this.Controls.Add(this.TxtKmFimDia);
            this.Controls.Add(this.TxtKmInicio);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.LblResultado);
            this.Controls.Add(this.LblValorRecebido);
            this.Controls.Add(this.LblCombutivel);
            this.Controls.Add(this.LblKmFimDia);
            this.Controls.Add(this.LblKmInicio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UberForm";
            this.Text = "Uber";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblKmInicio;
        private System.Windows.Forms.Label LblKmFimDia;
        private System.Windows.Forms.Label LblCombutivel;
        private System.Windows.Forms.Label LblValorRecebido;
        private System.Windows.Forms.Label LblResultado;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.TextBox TxtKmInicio;
        private System.Windows.Forms.TextBox TxtKmFimDia;
        private System.Windows.Forms.TextBox TxtConsumoCombustivel;
        private System.Windows.Forms.TextBox TxtValorFimDia;
        private System.Windows.Forms.Label TxtTitulo;
    }
}

