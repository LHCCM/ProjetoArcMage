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
            this.labelListaJogadores = new System.Windows.Forms.Label();
            this.listBoxJogadores = new System.Windows.Forms.ListBox();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.buttonEditarJogador = new System.Windows.Forms.Button();
            this.buttonApagarJogador = new System.Windows.Forms.Button();
            this.buttonNovoJogador = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelNick = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelIdade = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            // labelListaJogadores
            // 
            this.labelListaJogadores.AutoSize = true;
            this.labelListaJogadores.Location = new System.Drawing.Point(12, 52);
            this.labelListaJogadores.Name = "labelListaJogadores";
            this.labelListaJogadores.Size = new System.Drawing.Size(56, 13);
            this.labelListaJogadores.TabIndex = 5;
            this.labelListaJogadores.Text = "Jogadores";
            // 
            // listBoxJogadores
            // 
            this.listBoxJogadores.FormattingEnabled = true;
            this.listBoxJogadores.Location = new System.Drawing.Point(15, 69);
            this.listBoxJogadores.Name = "listBoxJogadores";
            this.listBoxJogadores.Size = new System.Drawing.Size(126, 238);
            this.listBoxJogadores.TabIndex = 6;
            this.listBoxJogadores.SelectedIndexChanged += new System.EventHandler(this.listBoxJogadores_SelectedIndexChanged);
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Location = new System.Drawing.Point(251, 351);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(121, 23);
            this.buttonVoltar.TabIndex = 24;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.UseVisualStyleBackColor = true;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // buttonEditarJogador
            // 
            this.buttonEditarJogador.Location = new System.Drawing.Point(251, 322);
            this.buttonEditarJogador.Name = "buttonEditarJogador";
            this.buttonEditarJogador.Size = new System.Drawing.Size(121, 23);
            this.buttonEditarJogador.TabIndex = 23;
            this.buttonEditarJogador.Text = "Editar Jogador";
            this.buttonEditarJogador.UseVisualStyleBackColor = true;
            this.buttonEditarJogador.Click += new System.EventHandler(this.buttonEditarJogador_Click);
            // 
            // buttonApagarJogador
            // 
            this.buttonApagarJogador.Location = new System.Drawing.Point(20, 352);
            this.buttonApagarJogador.Name = "buttonApagarJogador";
            this.buttonApagarJogador.Size = new System.Drawing.Size(121, 23);
            this.buttonApagarJogador.TabIndex = 22;
            this.buttonApagarJogador.Text = "Apagar Jogador";
            this.buttonApagarJogador.UseVisualStyleBackColor = true;
            this.buttonApagarJogador.Click += new System.EventHandler(this.buttonApagarJogador_Click);
            // 
            // buttonNovoJogador
            // 
            this.buttonNovoJogador.Location = new System.Drawing.Point(20, 323);
            this.buttonNovoJogador.Name = "buttonNovoJogador";
            this.buttonNovoJogador.Size = new System.Drawing.Size(121, 23);
            this.buttonNovoJogador.TabIndex = 21;
            this.buttonNovoJogador.Text = "Novo Jogador";
            this.buttonNovoJogador.UseVisualStyleBackColor = true;
            this.buttonNovoJogador.Click += new System.EventHandler(this.buttonNovoJogador_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 109);
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelIdade);
            this.groupBox1.Controls.Add(this.labelEmail);
            this.groupBox1.Controls.Add(this.labelNick);
            this.groupBox1.Controls.Add(this.labelNome);
            this.groupBox1.Controls.Add(this.labelID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(147, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 255);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações Jogador";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Nickname:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "E-mail:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Idade:";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(163, 19);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(0, 13);
            this.labelID.TabIndex = 41;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(72, 141);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(0, 13);
            this.labelNome.TabIndex = 42;
            // 
            // labelNick
            // 
            this.labelNick.AutoSize = true;
            this.labelNick.Location = new System.Drawing.Point(72, 168);
            this.labelNick.Name = "labelNick";
            this.labelNick.Size = new System.Drawing.Size(0, 13);
            this.labelNick.TabIndex = 43;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(72, 196);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(0, 13);
            this.labelEmail.TabIndex = 44;
            // 
            // labelIdade
            // 
            this.labelIdade.AutoSize = true;
            this.labelIdade.Location = new System.Drawing.Point(72, 224);
            this.labelIdade.Name = "labelIdade";
            this.labelIdade.Size = new System.Drawing.Size(0, 13);
            this.labelIdade.TabIndex = 45;
            // 
            // GerirJogadoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 383);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.buttonEditarJogador);
            this.Controls.Add(this.buttonApagarJogador);
            this.Controls.Add(this.buttonNovoJogador);
            this.Controls.Add(this.listBoxJogadores);
            this.Controls.Add(this.labelListaJogadores);
            this.Controls.Add(this.labelGerirJogadores);
            this.Name = "GerirJogadoresForm";
            this.Text = "Gerir Jogadores";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGerirJogadores;
        private System.Windows.Forms.Label labelListaJogadores;
        private System.Windows.Forms.ListBox listBoxJogadores;
        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.Button buttonEditarJogador;
        private System.Windows.Forms.Button buttonApagarJogador;
        private System.Windows.Forms.Button buttonNovoJogador;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelIdade;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelNick;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label label5;
    }
}