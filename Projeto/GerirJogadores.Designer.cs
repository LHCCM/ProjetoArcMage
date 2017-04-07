namespace Projeto
{
    partial class GerirJogadoresForm
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
            this.labelGerirJogadores = new System.Windows.Forms.Label();
            this.labelInfoJogador = new System.Windows.Forms.Label();
            this.labelListaJogadores = new System.Windows.Forms.Label();
            this.listBoxListaJogadores = new System.Windows.Forms.ListBox();
            this.listBoxInfoJogador = new System.Windows.Forms.ListBox();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.buttonEditarJogador = new System.Windows.Forms.Button();
            this.buttonApagarJogador = new System.Windows.Forms.Button();
            this.buttonNovoJogador = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelGerirJogadores
            // 
            this.labelGerirJogadores.AutoSize = true;
            this.labelGerirJogadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGerirJogadores.Location = new System.Drawing.Point(136, 9);
            this.labelGerirJogadores.Name = "labelGerirJogadores";
            this.labelGerirJogadores.Size = new System.Drawing.Size(145, 24);
            this.labelGerirJogadores.TabIndex = 1;
            this.labelGerirJogadores.Text = "Gerir Jogadores";
            // 
            // labelInfoJogador
            // 
            this.labelInfoJogador.AutoSize = true;
            this.labelInfoJogador.Location = new System.Drawing.Point(175, 52);
            this.labelInfoJogador.Name = "labelInfoJogador";
            this.labelInfoJogador.Size = new System.Drawing.Size(106, 13);
            this.labelInfoJogador.TabIndex = 4;
            this.labelInfoJogador.Text = "Informações Jogador";
            // 
            // labelListaJogadores
            // 
            this.labelListaJogadores.AutoSize = true;
            this.labelListaJogadores.Location = new System.Drawing.Point(12, 52);
            this.labelListaJogadores.Name = "labelListaJogadores";
            this.labelListaJogadores.Size = new System.Drawing.Size(56, 13);
            this.labelListaJogadores.TabIndex = 5;
            this.labelListaJogadores.Text = "Jogadores";
            // 
            // listBoxListaJogadores
            // 
            this.listBoxListaJogadores.FormattingEnabled = true;
            this.listBoxListaJogadores.Location = new System.Drawing.Point(15, 69);
            this.listBoxListaJogadores.Name = "listBoxListaJogadores";
            this.listBoxListaJogadores.Size = new System.Drawing.Size(126, 238);
            this.listBoxListaJogadores.TabIndex = 6;
            // 
            // listBoxInfoJogador
            // 
            this.listBoxInfoJogador.FormattingEnabled = true;
            this.listBoxInfoJogador.Location = new System.Drawing.Point(178, 184);
            this.listBoxInfoJogador.Name = "listBoxInfoJogador";
            this.listBoxInfoJogador.Size = new System.Drawing.Size(194, 121);
            this.listBoxInfoJogador.TabIndex = 7;
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Location = new System.Drawing.Point(251, 370);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(121, 23);
            this.buttonVoltar.TabIndex = 24;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.UseVisualStyleBackColor = true;
            // 
            // buttonEditarJogador
            // 
            this.buttonEditarJogador.Location = new System.Drawing.Point(251, 341);
            this.buttonEditarJogador.Name = "buttonEditarJogador";
            this.buttonEditarJogador.Size = new System.Drawing.Size(121, 23);
            this.buttonEditarJogador.TabIndex = 23;
            this.buttonEditarJogador.Text = "Editar Jogador";
            this.buttonEditarJogador.UseVisualStyleBackColor = true;
            // 
            // buttonApagarJogador
            // 
            this.buttonApagarJogador.Location = new System.Drawing.Point(20, 371);
            this.buttonApagarJogador.Name = "buttonApagarJogador";
            this.buttonApagarJogador.Size = new System.Drawing.Size(121, 23);
            this.buttonApagarJogador.TabIndex = 22;
            this.buttonApagarJogador.Text = "Apagar Jogador";
            this.buttonApagarJogador.UseVisualStyleBackColor = true;
            // 
            // buttonNovoJogador
            // 
            this.buttonNovoJogador.Location = new System.Drawing.Point(20, 342);
            this.buttonNovoJogador.Name = "buttonNovoJogador";
            this.buttonNovoJogador.Size = new System.Drawing.Size(121, 23);
            this.buttonNovoJogador.TabIndex = 21;
            this.buttonNovoJogador.Text = "Novo Jogador";
            this.buttonNovoJogador.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(178, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 96);
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // GerirJogadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 405);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.buttonEditarJogador);
            this.Controls.Add(this.buttonApagarJogador);
            this.Controls.Add(this.buttonNovoJogador);
            this.Controls.Add(this.listBoxInfoJogador);
            this.Controls.Add(this.listBoxListaJogadores);
            this.Controls.Add(this.labelListaJogadores);
            this.Controls.Add(this.labelInfoJogador);
            this.Controls.Add(this.labelGerirJogadores);
            this.Name = "GerirJogadores";
            this.Text = "Gerir Jogadores";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGerirJogadores;
        private System.Windows.Forms.Label labelInfoJogador;
        private System.Windows.Forms.Label labelListaJogadores;
        private System.Windows.Forms.ListBox listBoxListaJogadores;
        private System.Windows.Forms.ListBox listBoxInfoJogador;
        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.Button buttonEditarJogador;
        private System.Windows.Forms.Button buttonApagarJogador;
        private System.Windows.Forms.Button buttonNovoJogador;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}