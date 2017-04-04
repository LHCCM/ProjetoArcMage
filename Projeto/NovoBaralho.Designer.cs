namespace Projeto
{
    partial class NovoBaralho
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
            this.buttonNovoBaralhoConfimar = new System.Windows.Forms.Button();
            this.buttonNovoBaralhoCancelar = new System.Windows.Forms.Button();
            this.textBoxNomeNovoBaralho = new System.Windows.Forms.TextBox();
            this.labelNomeBaralho = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonNovoBaralhoConfimar
            // 
            this.buttonNovoBaralhoConfimar.Location = new System.Drawing.Point(112, 116);
            this.buttonNovoBaralhoConfimar.Name = "buttonNovoBaralhoConfimar";
            this.buttonNovoBaralhoConfimar.Size = new System.Drawing.Size(75, 23);
            this.buttonNovoBaralhoConfimar.TabIndex = 0;
            this.buttonNovoBaralhoConfimar.Text = "Confirmar";
            this.buttonNovoBaralhoConfimar.UseVisualStyleBackColor = true;
            // 
            // buttonNovoBaralhoCancelar
            // 
            this.buttonNovoBaralhoCancelar.Location = new System.Drawing.Point(193, 116);
            this.buttonNovoBaralhoCancelar.Name = "buttonNovoBaralhoCancelar";
            this.buttonNovoBaralhoCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonNovoBaralhoCancelar.TabIndex = 1;
            this.buttonNovoBaralhoCancelar.Text = "Cancelar";
            this.buttonNovoBaralhoCancelar.UseVisualStyleBackColor = true;
            // 
            // textBoxNomeNovoBaralho
            // 
            this.textBoxNomeNovoBaralho.Location = new System.Drawing.Point(9, 76);
            this.textBoxNomeNovoBaralho.Name = "textBoxNomeNovoBaralho";
            this.textBoxNomeNovoBaralho.Size = new System.Drawing.Size(259, 20);
            this.textBoxNomeNovoBaralho.TabIndex = 2;
            // 
            // labelNomeBaralho
            // 
            this.labelNomeBaralho.AutoSize = true;
            this.labelNomeBaralho.Location = new System.Drawing.Point(12, 60);
            this.labelNomeBaralho.Name = "labelNomeBaralho";
            this.labelNomeBaralho.Size = new System.Drawing.Size(89, 13);
            this.labelNomeBaralho.TabIndex = 3;
            this.labelNomeBaralho.Text = "Nome do Baralho";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Novo Baralho";
            // 
            // NovoBaralho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 148);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelNomeBaralho);
            this.Controls.Add(this.textBoxNomeNovoBaralho);
            this.Controls.Add(this.buttonNovoBaralhoCancelar);
            this.Controls.Add(this.buttonNovoBaralhoConfimar);
            this.Name = "NovoBaralho";
            this.Text = "Novo Baralho";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNovoBaralhoConfimar;
        private System.Windows.Forms.Button buttonNovoBaralhoCancelar;
        private System.Windows.Forms.TextBox textBoxNomeNovoBaralho;
        private System.Windows.Forms.Label labelNomeBaralho;
        private System.Windows.Forms.Label label1;
    }
}