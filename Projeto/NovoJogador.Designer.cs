namespace Projeto
{
    partial class NovoJogadorForm
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
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelNomeJogador = new System.Windows.Forms.Label();
            this.labelNovoJogador = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxNick = new System.Windows.Forms.TextBox();
            this.labelNickname = new System.Windows.Forms.Label();
            this.buttonEscolherAvatar = new System.Windows.Forms.Button();
            this.labelIdJogador = new System.Windows.Forms.Label();
            this.labelIdnome = new System.Windows.Forms.Label();
            this.labelIdade = new System.Windows.Forms.Label();
            this.numericUpDownIdade = new System.Windows.Forms.NumericUpDown();
            this.buttonConfirmNovoJogador = new System.Windows.Forms.Button();
            this.buttonCancelarNovoJogador = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIdade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(108, 65);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(230, 20);
            this.textBoxNome.TabIndex = 6;
            // 
            // labelNomeJogador
            // 
            this.labelNomeJogador.AutoSize = true;
            this.labelNomeJogador.Location = new System.Drawing.Point(12, 68);
            this.labelNomeJogador.Name = "labelNomeJogador";
            this.labelNomeJogador.Size = new System.Drawing.Size(94, 13);
            this.labelNomeJogador.TabIndex = 5;
            this.labelNomeJogador.Text = "Nome do Jogador:";
            // 
            // labelNovoJogador
            // 
            this.labelNovoJogador.AutoSize = true;
            this.labelNovoJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNovoJogador.Location = new System.Drawing.Point(193, 9);
            this.labelNovoJogador.Name = "labelNovoJogador";
            this.labelNovoJogador.Size = new System.Drawing.Size(129, 24);
            this.labelNovoJogador.TabIndex = 7;
            this.labelNovoJogador.Text = "Novo Jogador";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(108, 91);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(230, 20);
            this.textBoxEmail.TabIndex = 9;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(12, 94);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(91, 13);
            this.labelEmail.TabIndex = 8;
            this.labelEmail.Text = "Email do Jogador:";
            // 
            // textBoxNick
            // 
            this.textBoxNick.Location = new System.Drawing.Point(108, 117);
            this.textBoxNick.Name = "textBoxNick";
            this.textBoxNick.Size = new System.Drawing.Size(232, 20);
            this.textBoxNick.TabIndex = 11;
            // 
            // labelNickname
            // 
            this.labelNickname.AutoSize = true;
            this.labelNickname.Location = new System.Drawing.Point(12, 120);
            this.labelNickname.Name = "labelNickname";
            this.labelNickname.Size = new System.Drawing.Size(61, 13);
            this.labelNickname.TabIndex = 10;
            this.labelNickname.Text = "Nickname :";
            // 
            // buttonEscolherAvatar
            // 
            this.buttonEscolherAvatar.Location = new System.Drawing.Point(385, 190);
            this.buttonEscolherAvatar.Name = "buttonEscolherAvatar";
            this.buttonEscolherAvatar.Size = new System.Drawing.Size(106, 23);
            this.buttonEscolherAvatar.TabIndex = 12;
            this.buttonEscolherAvatar.Text = "Escolher Avatar";
            this.buttonEscolherAvatar.UseVisualStyleBackColor = true;
            // 
            // labelIdJogador
            // 
            this.labelIdJogador.AutoSize = true;
            this.labelIdJogador.Location = new System.Drawing.Point(105, 148);
            this.labelIdJogador.Name = "labelIdJogador";
            this.labelIdJogador.Size = new System.Drawing.Size(88, 13);
            this.labelIdJogador.TabIndex = 13;
            this.labelIdJogador.Text = "AutoIncremented";
            // 
            // labelIdnome
            // 
            this.labelIdnome.AutoSize = true;
            this.labelIdnome.Location = new System.Drawing.Point(12, 148);
            this.labelIdnome.Name = "labelIdnome";
            this.labelIdnome.Size = new System.Drawing.Size(78, 13);
            this.labelIdnome.TabIndex = 14;
            this.labelIdnome.Text = "Id do Jogador :";
            // 
            // labelIdade
            // 
            this.labelIdade.AutoSize = true;
            this.labelIdade.Location = new System.Drawing.Point(199, 148);
            this.labelIdade.Name = "labelIdade";
            this.labelIdade.Size = new System.Drawing.Size(96, 13);
            this.labelIdade.TabIndex = 15;
            this.labelIdade.Text = "Idade do Jogador :";
            // 
            // numericUpDownIdade
            // 
            this.numericUpDownIdade.Location = new System.Drawing.Point(301, 146);
            this.numericUpDownIdade.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.numericUpDownIdade.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDownIdade.Name = "numericUpDownIdade";
            this.numericUpDownIdade.Size = new System.Drawing.Size(39, 20);
            this.numericUpDownIdade.TabIndex = 16;
            this.numericUpDownIdade.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // buttonConfirmNovoJogador
            // 
            this.buttonConfirmNovoJogador.Location = new System.Drawing.Point(12, 190);
            this.buttonConfirmNovoJogador.Name = "buttonConfirmNovoJogador";
            this.buttonConfirmNovoJogador.Size = new System.Drawing.Size(106, 23);
            this.buttonConfirmNovoJogador.TabIndex = 17;
            this.buttonConfirmNovoJogador.Text = "Confirmar";
            this.buttonConfirmNovoJogador.UseVisualStyleBackColor = true;
            this.buttonConfirmNovoJogador.Click += new System.EventHandler(this.buttonConfirmNovoJogador_Click);
            // 
            // buttonCancelarNovoJogador
            // 
            this.buttonCancelarNovoJogador.Location = new System.Drawing.Point(202, 190);
            this.buttonCancelarNovoJogador.Name = "buttonCancelarNovoJogador";
            this.buttonCancelarNovoJogador.Size = new System.Drawing.Size(106, 23);
            this.buttonCancelarNovoJogador.TabIndex = 18;
            this.buttonCancelarNovoJogador.Text = "Cancelar";
            this.buttonCancelarNovoJogador.UseVisualStyleBackColor = true;
            this.buttonCancelarNovoJogador.Click += new System.EventHandler(this.buttonCancelarNovoJogador_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(362, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 132);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // NovoJogadorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 225);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonCancelarNovoJogador);
            this.Controls.Add(this.buttonConfirmNovoJogador);
            this.Controls.Add(this.numericUpDownIdade);
            this.Controls.Add(this.labelIdade);
            this.Controls.Add(this.labelIdnome);
            this.Controls.Add(this.labelIdJogador);
            this.Controls.Add(this.buttonEscolherAvatar);
            this.Controls.Add(this.textBoxNick);
            this.Controls.Add(this.labelNickname);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelNovoJogador);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelNomeJogador);
            this.Name = "NovoJogadorForm";
            this.Text = "Novo Jogador";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIdade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label labelNomeJogador;
        private System.Windows.Forms.Label labelNovoJogador;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxNick;
        private System.Windows.Forms.Label labelNickname;
        private System.Windows.Forms.Button buttonEscolherAvatar;
        private System.Windows.Forms.Label labelIdJogador;
        private System.Windows.Forms.Label labelIdnome;
        private System.Windows.Forms.Label labelIdade;
        private System.Windows.Forms.NumericUpDown numericUpDownIdade;
        private System.Windows.Forms.Button buttonConfirmNovoJogador;
        private System.Windows.Forms.Button buttonCancelarNovoJogador;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}