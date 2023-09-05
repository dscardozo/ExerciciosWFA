namespace Escola_POO_BASE.Telas
{
    partial class TelaProfessor
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
            this.LblTexto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblTexto
            // 
            this.LblTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTexto.Location = new System.Drawing.Point(-1, -1);
            this.LblTexto.Name = "LblTexto";
            this.LblTexto.Size = new System.Drawing.Size(627, 465);
            this.LblTexto.TabIndex = 0;
            this.LblTexto.Text = "Bem Vindo a Tela Professor!!";
            this.LblTexto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TelaProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 463);
            this.Controls.Add(this.LblTexto);
            this.Name = "TelaProfessor";
            this.Text = "Professor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblTexto;
    }
}