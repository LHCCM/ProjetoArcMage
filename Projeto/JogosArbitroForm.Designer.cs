namespace Projeto
{
    partial class JogosArbitroForm
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
            this.labelJogosArbitro = new System.Windows.Forms.Label();
            this.labelTorenios = new System.Windows.Forms.Label();
            this.labelJogos = new System.Windows.Forms.Label();
            this.labelInfoJogo = new System.Windows.Forms.Label();
            this.listBoxTorneios = new System.Windows.Forms.ListBox();
            this.listBoxJogos = new System.Windows.Forms.ListBox();
            this.listBoxInfoJogo = new System.Windows.Forms.ListBox();
            this.listBoxInfoEquipa = new System.Windows.Forms.ListBox();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelJogosArbitro
            // 
            this.labelJogosArbitro.AutoSize = true;
            this.labelJogosArbitro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJogosArbitro.Location = new System.Drawing.Point(188, 9);
            this.labelJogosArbitro.Name = "labelJogosArbitro";
            this.labelJogosArbitro.Size = new System.Drawing.Size(61, 24);
            this.labelJogosArbitro.TabIndex = 0;
            this.labelJogosArbitro.Text = "Jogos";
            // 
            // labelTorenios
            // 
            this.labelTorenios.AutoSize = true;
            this.labelTorenios.Location = new System.Drawing.Point(12, 51);
            this.labelTorenios.Name = "labelTorenios";
            this.labelTorenios.Size = new System.Drawing.Size(48, 13);
            this.labelTorenios.TabIndex = 1;
            this.labelTorenios.Text = "Torneios";
            // 
            // labelJogos
            // 
            this.labelJogos.AutoSize = true;
            this.labelJogos.Location = new System.Drawing.Point(168, 51);
            this.labelJogos.Name = "labelJogos";
            this.labelJogos.Size = new System.Drawing.Size(35, 13);
            this.labelJogos.TabIndex = 2;
            this.labelJogos.Text = "Jogos";
            // 
            // labelInfoJogo
            // 
            this.labelInfoJogo.AutoSize = true;
            this.labelInfoJogo.Location = new System.Drawing.Point(308, 51);
            this.labelInfoJogo.Name = "labelInfoJogo";
            this.labelInfoJogo.Size = new System.Drawing.Size(66, 13);
            this.labelInfoJogo.TabIndex = 3;
            this.labelInfoJogo.Text = "Info do Jogo";
            // 
            // listBoxTorneios
            // 
            this.listBoxTorneios.FormattingEnabled = true;
            this.listBoxTorneios.Location = new System.Drawing.Point(12, 68);
            this.listBoxTorneios.Name = "listBoxTorneios";
            this.listBoxTorneios.Size = new System.Drawing.Size(104, 251);
            this.listBoxTorneios.TabIndex = 4;
            // 
            // listBoxJogos
            // 
            this.listBoxJogos.FormattingEnabled = true;
            this.listBoxJogos.Location = new System.Drawing.Point(171, 68);
            this.listBoxJogos.Name = "listBoxJogos";
            this.listBoxJogos.Size = new System.Drawing.Size(104, 251);
            this.listBoxJogos.TabIndex = 5;
            // 
            // listBoxInfoJogo
            // 
            this.listBoxInfoJogo.FormattingEnabled = true;
            this.listBoxInfoJogo.Location = new System.Drawing.Point(311, 68);
            this.listBoxInfoJogo.Name = "listBoxInfoJogo";
            this.listBoxInfoJogo.Size = new System.Drawing.Size(135, 251);
            this.listBoxInfoJogo.TabIndex = 6;
            // 
            // listBoxInfoEquipa
            // 
            this.listBoxInfoEquipa.FormattingEnabled = true;
            this.listBoxInfoEquipa.Location = new System.Drawing.Point(12, 335);
            this.listBoxInfoEquipa.Name = "listBoxInfoEquipa";
            this.listBoxInfoEquipa.Size = new System.Drawing.Size(104, 43);
            this.listBoxInfoEquipa.TabIndex = 7;
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(171, 354);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(104, 23);
            this.buttonEditar.TabIndex = 8;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Location = new System.Drawing.Point(311, 354);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(135, 23);
            this.buttonVoltar.TabIndex = 9;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.UseVisualStyleBackColor = true;
            // 
            // JogosArbitroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 390);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.listBoxInfoEquipa);
            this.Controls.Add(this.listBoxInfoJogo);
            this.Controls.Add(this.listBoxJogos);
            this.Controls.Add(this.listBoxTorneios);
            this.Controls.Add(this.labelInfoJogo);
            this.Controls.Add(this.labelJogos);
            this.Controls.Add(this.labelTorenios);
            this.Controls.Add(this.labelJogosArbitro);
            this.Name = "JogosArbitroForm";
            this.Text = "JogosArbitroForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelJogosArbitro;
        private System.Windows.Forms.Label labelTorenios;
        private System.Windows.Forms.Label labelJogos;
        private System.Windows.Forms.Label labelInfoJogo;
        private System.Windows.Forms.ListBox listBoxTorneios;
        private System.Windows.Forms.ListBox listBoxJogos;
        private System.Windows.Forms.ListBox listBoxInfoJogo;
        private System.Windows.Forms.ListBox listBoxInfoEquipa;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonVoltar;
    }
}