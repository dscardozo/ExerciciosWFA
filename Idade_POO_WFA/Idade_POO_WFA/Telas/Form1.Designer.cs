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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblRespDias = new System.Windows.Forms.Label();
            this.LblRespMeses = new System.Windows.Forms.Label();
            this.LblRespAnos = new System.Windows.Forms.Label();
            this.TxtDias = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtMeses = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtAnos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LblRespEmDias = new System.Windows.Forms.Label();
            this.TxtSomDias = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RdbSomDias = new System.Windows.Forms.RadioButton();
            this.RdbAnosMesesDias = new System.Windows.Forms.RadioButton();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblRespDias);
            this.groupBox1.Controls.Add(this.LblRespMeses);
            this.groupBox1.Controls.Add(this.LblRespAnos);
            this.groupBox1.Controls.Add(this.TxtDias);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtMeses);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtAnos);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 196);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 165);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Idade em:";
            // 
            // LblRespDias
            // 
            this.LblRespDias.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblRespDias.Location = new System.Drawing.Point(114, 116);
            this.LblRespDias.Name = "LblRespDias";
            this.LblRespDias.Size = new System.Drawing.Size(100, 31);
            this.LblRespDias.TabIndex = 10;
            this.LblRespDias.Visible = false;
            // 
            // LblRespMeses
            // 
            this.LblRespMeses.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblRespMeses.Location = new System.Drawing.Point(114, 79);
            this.LblRespMeses.Name = "LblRespMeses";
            this.LblRespMeses.Size = new System.Drawing.Size(100, 31);
            this.LblRespMeses.TabIndex = 9;
            this.LblRespMeses.Visible = false;
            // 
            // LblRespAnos
            // 
            this.LblRespAnos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblRespAnos.Location = new System.Drawing.Point(114, 42);
            this.LblRespAnos.Name = "LblRespAnos";
            this.LblRespAnos.Size = new System.Drawing.Size(100, 31);
            this.LblRespAnos.TabIndex = 8;
            this.LblRespAnos.Visible = false;
            // 
            // TxtDias
            // 
            this.TxtDias.Location = new System.Drawing.Point(114, 116);
            this.TxtDias.Name = "TxtDias";
            this.TxtDias.Size = new System.Drawing.Size(100, 31);
            this.TxtDias.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dias:";
            // 
            // TxtMeses
            // 
            this.TxtMeses.Location = new System.Drawing.Point(114, 79);
            this.TxtMeses.Name = "TxtMeses";
            this.TxtMeses.Size = new System.Drawing.Size(100, 31);
            this.TxtMeses.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Meses:";
            // 
            // TxtAnos
            // 
            this.TxtAnos.Location = new System.Drawing.Point(114, 42);
            this.TxtAnos.Name = "TxtAnos";
            this.TxtAnos.Size = new System.Drawing.Size(100, 31);
            this.TxtAnos.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Anos:";
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(12, 37);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(265, 31);
            this.TxtNome.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nome:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LblRespEmDias);
            this.groupBox2.Controls.Add(this.TxtSomDias);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(12, 367);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(265, 84);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Idade somente em:";
            // 
            // LblRespEmDias
            // 
            this.LblRespEmDias.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblRespEmDias.Location = new System.Drawing.Point(114, 34);
            this.LblRespEmDias.Name = "LblRespEmDias";
            this.LblRespEmDias.Size = new System.Drawing.Size(100, 31);
            this.LblRespEmDias.TabIndex = 11;
            // 
            // TxtSomDias
            // 
            this.TxtSomDias.Location = new System.Drawing.Point(114, 34);
            this.TxtSomDias.Name = "TxtSomDias";
            this.TxtSomDias.Size = new System.Drawing.Size(100, 31);
            this.TxtSomDias.TabIndex = 1;
            this.TxtSomDias.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Dias:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RdbSomDias);
            this.groupBox3.Controls.Add(this.RdbAnosMesesDias);
            this.groupBox3.Location = new System.Drawing.Point(12, 74);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(265, 116);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Seleção";
            // 
            // RdbSomDias
            // 
            this.RdbSomDias.AutoSize = true;
            this.RdbSomDias.Location = new System.Drawing.Point(30, 66);
            this.RdbSomDias.Name = "RdbSomDias";
            this.RdbSomDias.Size = new System.Drawing.Size(164, 29);
            this.RdbSomDias.TabIndex = 1;
            this.RdbSomDias.Text = "Somente Dias";
            this.RdbSomDias.UseVisualStyleBackColor = true;
            this.RdbSomDias.CheckedChanged += new System.EventHandler(this.RdbSomDias_CheckedChanged);
            // 
            // RdbAnosMesesDias
            // 
            this.RdbAnosMesesDias.AutoSize = true;
            this.RdbAnosMesesDias.Checked = true;
            this.RdbAnosMesesDias.Location = new System.Drawing.Point(30, 31);
            this.RdbAnosMesesDias.Name = "RdbAnosMesesDias";
            this.RdbAnosMesesDias.Size = new System.Drawing.Size(210, 29);
            this.RdbAnosMesesDias.TabIndex = 0;
            this.RdbAnosMesesDias.TabStop = true;
            this.RdbAnosMesesDias.Text = "Anos, Meses, Dias";
            this.RdbAnosMesesDias.UseVisualStyleBackColor = true;
            this.RdbAnosMesesDias.CheckedChanged += new System.EventHandler(this.RdbAnosMesesDias_CheckedChanged);
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Location = new System.Drawing.Point(12, 458);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(265, 43);
            this.BtnCalcular.TabIndex = 13;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 513);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Calculo de Idades";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtDias;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtMeses;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtAnos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxtSomDias;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LblRespDias;
        private System.Windows.Forms.Label LblRespMeses;
        private System.Windows.Forms.Label LblRespAnos;
        private System.Windows.Forms.Label LblRespEmDias;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton RdbSomDias;
        private System.Windows.Forms.RadioButton RdbAnosMesesDias;
        private System.Windows.Forms.Button BtnCalcular;
    }
}

