namespace Aula4_Encapsulamento
{
    partial class TelaFiolme
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
            this.TxtTitulo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TxtSinopse = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.TxtGenero = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.TxtClassificacao = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.BtnGravar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtTitulo
            // 
            this.TxtTitulo.AutoSize = true;
            this.TxtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTitulo.Location = new System.Drawing.Point(51, 41);
            this.TxtTitulo.Name = "TxtTitulo";
            this.TxtTitulo.Size = new System.Drawing.Size(47, 20);
            this.TxtTitulo.TabIndex = 0;
            this.TxtTitulo.Text = "Titulo";

            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(154, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(526, 26);
            this.textBox1.TabIndex = 1;
            // 
            // TxtSinopse
            // 
            this.TxtSinopse.AutoSize = true;
            this.TxtSinopse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSinopse.Location = new System.Drawing.Point(51, 96);
            this.TxtSinopse.Name = "TxtSinopse";
            this.TxtSinopse.Size = new System.Drawing.Size(67, 20);
            this.TxtSinopse.TabIndex = 2;
            this.TxtSinopse.Text = "Sinopse";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(154, 93);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(526, 26);
            this.textBox2.TabIndex = 3;
            // 
            // TxtGenero
            // 
            this.TxtGenero.AutoSize = true;
            this.TxtGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtGenero.Location = new System.Drawing.Point(51, 155);
            this.TxtGenero.Name = "TxtGenero";
            this.TxtGenero.Size = new System.Drawing.Size(63, 20);
            this.TxtGenero.TabIndex = 4;
            this.TxtGenero.Text = "Gênero";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(154, 152);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(526, 26);
            this.textBox3.TabIndex = 5;
            // 
            // TxtClassificacao
            // 
            this.TxtClassificacao.AutoSize = true;
            this.TxtClassificacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtClassificacao.Location = new System.Drawing.Point(51, 215);
            this.TxtClassificacao.Name = "TxtClassificacao";
            this.TxtClassificacao.Size = new System.Drawing.Size(102, 20);
            this.TxtClassificacao.TabIndex = 6;
            this.TxtClassificacao.Text = "Classificação";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(154, 212);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(526, 26);
            this.textBox4.TabIndex = 7;
            // 
            // BtnGravar
            // 
            this.BtnGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGravar.Location = new System.Drawing.Point(331, 298);
            this.BtnGravar.Name = "BtnGravar";
            this.BtnGravar.Size = new System.Drawing.Size(127, 30);
            this.BtnGravar.TabIndex = 8;
            this.BtnGravar.Text = "Gravar";
            this.BtnGravar.UseVisualStyleBackColor = true;
            this.BtnGravar.Click += new System.EventHandler(this.BtnGravar_Click);
            // 
            // TelaFiolme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 365);
            this.Controls.Add(this.BtnGravar);
            this.Controls.Add(this.TxtClassificacao);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.TxtGenero);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.TxtSinopse);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.TxtTitulo);
            this.Controls.Add(this.textBox1);
            this.Name = "TelaFiolme";
            this.Text = "TelaFiolme";

            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TxtTitulo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label TxtSinopse;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label TxtGenero;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label TxtClassificacao;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button BtnGravar;
    }
}