namespace Projeto
{
    partial class GerirEquipasJogadores
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonGerirEquipa = new System.Windows.Forms.Button();
            this.buttonGerirJogadores = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gerir Equipas ou Jogadores";
            // 
            // buttonGerirEquipa
            // 
            this.buttonGerirEquipa.Location = new System.Drawing.Point(17, 155);
            this.buttonGerirEquipa.Name = "buttonGerirEquipa";
            this.buttonGerirEquipa.Size = new System.Drawing.Size(75, 23);
            this.buttonGerirEquipa.TabIndex = 1;
            this.buttonGerirEquipa.Text = "Equipas";
            this.buttonGerirEquipa.UseVisualStyleBackColor = true;
            // 
            // buttonGerirJogadores
            // 
            this.buttonGerirJogadores.Location = new System.Drawing.Point(173, 155);
            this.buttonGerirJogadores.Name = "buttonGerirJogadores";
            this.buttonGerirJogadores.Size = new System.Drawing.Size(75, 23);
            this.buttonGerirJogadores.TabIndex = 2;
            this.buttonGerirJogadores.Text = "Jogadores";
            this.buttonGerirJogadores.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(160, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 86);
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(12, 63);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(102, 86);
            this.pictureBox2.TabIndex = 36;
            this.pictureBox2.TabStop = false;
            // 
            // GerirEquipasJogadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 261);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonGerirJogadores);
            this.Controls.Add(this.buttonGerirEquipa);
            this.Controls.Add(this.label1);
            this.Name = "GerirEquipasJogadores";
            this.Text = "Gerir Equipas ou Jogadores";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonGerirEquipa;
        private System.Windows.Forms.Button buttonGerirJogadores;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}