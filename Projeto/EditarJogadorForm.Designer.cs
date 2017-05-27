namespace Projeto
{
    partial class EditarJogadorForm
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
            this.labelEditarJogador = new System.Windows.Forms.Label();
            this.textBoxAvatar = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonCancelarNovoJogador = new System.Windows.Forms.Button();
            this.buttonConfirmNovoJogador = new System.Windows.Forms.Button();
            this.numericUpDownIdade = new System.Windows.Forms.NumericUpDown();
            this.labelIdade = new System.Windows.Forms.Label();
            this.buttonEscolherAvatar = new System.Windows.Forms.Button();
            this.textBoxNick = new System.Windows.Forms.TextBox();
            this.labelNickname = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelNomeJogador = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIdade)).BeginInit();
            this.SuspendLayout();
            // 
            // labelEditarJogador
            // 
            this.labelEditarJogador.AutoSize = true;
            this.labelEditarJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditarJogador.Location = new System.Drawing.Point(176, 9);
            this.labelEditarJogador.Name = "labelEditarJogador";
            this.labelEditarJogador.Size = new System.Drawing.Size(132, 24);
            this.labelEditarJogador.TabIndex = 22;
            this.labelEditarJogador.Text = "Editar Jogador";
            // 
            // textBoxAvatar
            // 
            this.textBoxAvatar.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxAvatar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAvatar.Location = new System.Drawing.Point(359, 171);
            this.textBoxAvatar.Name = "textBoxAvatar";
            this.textBoxAvatar.Size = new System.Drawing.Size(140, 13);
            this.textBoxAvatar.TabIndex = 35;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(348, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 132);
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // buttonCancelarNovoJogador
            // 
            this.buttonCancelarNovoJogador.Location = new System.Drawing.Point(202, 190);
            this.buttonCancelarNovoJogador.Name = "buttonCancelarNovoJogador";
            this.buttonCancelarNovoJogador.Size = new System.Drawing.Size(106, 23);
            this.buttonCancelarNovoJogador.TabIndex = 33;
            this.buttonCancelarNovoJogador.Text = "Cancelar";
            this.buttonCancelarNovoJogador.UseVisualStyleBackColor = true;
            // 
            // buttonConfirmNovoJogador
            // 
            this.buttonConfirmNovoJogador.Location = new System.Drawing.Point(12, 190);
            this.buttonConfirmNovoJogador.Name = "buttonConfirmNovoJogador";
            this.buttonConfirmNovoJogador.Size = new System.Drawing.Size(106, 23);
            this.buttonConfirmNovoJogador.TabIndex = 32;
            this.buttonConfirmNovoJogador.Text = "Confirmar";
            this.buttonConfirmNovoJogador.UseVisualStyleBackColor = true;
            // 
            // numericUpDownIdade
            // 
            this.numericUpDownIdade.Location = new System.Drawing.Point(301, 146);
            this.numericUpDownIdade.Maximum = new decimal(new int[] {
            99,
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
            this.numericUpDownIdade.TabIndex = 31;
            this.numericUpDownIdade.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // labelIdade
            // 
            this.labelIdade.AutoSize = true;
            this.labelIdade.Location = new System.Drawing.Point(199, 148);
            this.labelIdade.Name = "labelIdade";
            this.labelIdade.Size = new System.Drawing.Size(96, 13);
            this.labelIdade.TabIndex = 30;
            this.labelIdade.Text = "Idade do Jogador :";
            // 
            // buttonEscolherAvatar
            // 
            this.buttonEscolherAvatar.Location = new System.Drawing.Point(369, 190);
            this.buttonEscolherAvatar.Name = "buttonEscolherAvatar";
            this.buttonEscolherAvatar.Size = new System.Drawing.Size(106, 23);
            this.buttonEscolherAvatar.TabIndex = 29;
            this.buttonEscolherAvatar.Text = "Escolher Avatar";
            this.buttonEscolherAvatar.UseVisualStyleBackColor = true;
            // 
            // textBoxNick
            // 
            this.textBoxNick.Location = new System.Drawing.Point(108, 117);
            this.textBoxNick.Name = "textBoxNick";
            this.textBoxNick.Size = new System.Drawing.Size(232, 20);
            this.textBoxNick.TabIndex = 28;
            // 
            // labelNickname
            // 
            this.labelNickname.AutoSize = true;
            this.labelNickname.Location = new System.Drawing.Point(12, 120);
            this.labelNickname.Name = "labelNickname";
            this.labelNickname.Size = new System.Drawing.Size(61, 13);
            this.labelNickname.TabIndex = 27;
            this.labelNickname.Text = "Nickname :";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(108, 91);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(230, 20);
            this.textBoxEmail.TabIndex = 26;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(12, 94);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(91, 13);
            this.labelEmail.TabIndex = 25;
            this.labelEmail.Text = "Email do Jogador:";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(108, 65);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(230, 20);
            this.textBoxNome.TabIndex = 24;
            // 
            // labelNomeJogador
            // 
            this.labelNomeJogador.AutoSize = true;
            this.labelNomeJogador.Location = new System.Drawing.Point(12, 68);
            this.labelNomeJogador.Name = "labelNomeJogador";
            this.labelNomeJogador.Size = new System.Drawing.Size(94, 13);
            this.labelNomeJogador.TabIndex = 23;
            this.labelNomeJogador.Text = "Nome do Jogador:";
            // 
            // EditarJogadorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 225);
            this.Controls.Add(this.textBoxAvatar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonCancelarNovoJogador);
            this.Controls.Add(this.buttonConfirmNovoJogador);
            this.Controls.Add(this.numericUpDownIdade);
            this.Controls.Add(this.labelIdade);
            this.Controls.Add(this.buttonEscolherAvatar);
            this.Controls.Add(this.textBoxNick);
            this.Controls.Add(this.labelNickname);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelNomeJogador);
            this.Controls.Add(this.labelEditarJogador);
            this.Name = "EditarJogadorForm";
            this.Text = "Editar Jogador";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIdade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelEditarJogador;
        private System.Windows.Forms.TextBox textBoxAvatar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonCancelarNovoJogador;
        private System.Windows.Forms.Button buttonConfirmNovoJogador;
        private System.Windows.Forms.NumericUpDown numericUpDownIdade;
        private System.Windows.Forms.Label labelIdade;
        private System.Windows.Forms.Button buttonEscolherAvatar;
        private System.Windows.Forms.TextBox textBoxNick;
        private System.Windows.Forms.Label labelNickname;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label labelNomeJogador;
    }
}