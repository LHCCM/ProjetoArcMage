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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.numericUpDownIdade = new System.Windows.Forms.NumericUpDown();
            this.labelIdade = new System.Windows.Forms.Label();
            this.labelIdnome = new System.Windows.Forms.Label();
            this.labelIdJogador = new System.Windows.Forms.Label();
            this.buttonAlterarAvatar = new System.Windows.Forms.Button();
            this.labelNickname = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelEditarJogador = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelNomeJogador = new System.Windows.Forms.Label();
            this.textBoxNickname = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIdade)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(356, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 132);
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(196, 192);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(106, 23);
            this.buttonCancelar.TabIndex = 33;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(6, 192);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(106, 23);
            this.buttonGuardar.TabIndex = 32;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            // 
            // numericUpDownIdade
            // 
            this.numericUpDownIdade.Location = new System.Drawing.Point(295, 157);
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
            this.labelIdade.Location = new System.Drawing.Point(193, 159);
            this.labelIdade.Name = "labelIdade";
            this.labelIdade.Size = new System.Drawing.Size(96, 13);
            this.labelIdade.TabIndex = 30;
            this.labelIdade.Text = "Idade do Jogador :";
            // 
            // labelIdnome
            // 
            this.labelIdnome.AutoSize = true;
            this.labelIdnome.Location = new System.Drawing.Point(6, 159);
            this.labelIdnome.Name = "labelIdnome";
            this.labelIdnome.Size = new System.Drawing.Size(78, 13);
            this.labelIdnome.TabIndex = 29;
            this.labelIdnome.Text = "Id do Jogador :";
            // 
            // labelIdJogador
            // 
            this.labelIdJogador.AutoSize = true;
            this.labelIdJogador.Location = new System.Drawing.Point(99, 159);
            this.labelIdJogador.Name = "labelIdJogador";
            this.labelIdJogador.Size = new System.Drawing.Size(88, 13);
            this.labelIdJogador.TabIndex = 28;
            this.labelIdJogador.Text = "AutoIncremented";
            // 
            // buttonAlterarAvatar
            // 
            this.buttonAlterarAvatar.Location = new System.Drawing.Point(379, 192);
            this.buttonAlterarAvatar.Name = "buttonAlterarAvatar";
            this.buttonAlterarAvatar.Size = new System.Drawing.Size(106, 23);
            this.buttonAlterarAvatar.TabIndex = 27;
            this.buttonAlterarAvatar.Text = "Alterar Avatar";
            this.buttonAlterarAvatar.UseVisualStyleBackColor = true;
            // 
            // labelNickname
            // 
            this.labelNickname.AutoSize = true;
            this.labelNickname.Location = new System.Drawing.Point(6, 131);
            this.labelNickname.Name = "labelNickname";
            this.labelNickname.Size = new System.Drawing.Size(61, 13);
            this.labelNickname.TabIndex = 25;
            this.labelNickname.Text = "Nickname :";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(102, 102);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(230, 20);
            this.textBoxEmail.TabIndex = 24;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(6, 105);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(91, 13);
            this.labelEmail.TabIndex = 23;
            this.labelEmail.Text = "Email do Jogador:";
            // 
            // labelEditarJogador
            // 
            this.labelEditarJogador.AutoSize = true;
            this.labelEditarJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditarJogador.Location = new System.Drawing.Point(187, 11);
            this.labelEditarJogador.Name = "labelEditarJogador";
            this.labelEditarJogador.Size = new System.Drawing.Size(132, 24);
            this.labelEditarJogador.TabIndex = 22;
            this.labelEditarJogador.Text = "Editar Jogador";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(102, 76);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(230, 20);
            this.textBoxNome.TabIndex = 21;
            // 
            // labelNomeJogador
            // 
            this.labelNomeJogador.AutoSize = true;
            this.labelNomeJogador.Location = new System.Drawing.Point(6, 79);
            this.labelNomeJogador.Name = "labelNomeJogador";
            this.labelNomeJogador.Size = new System.Drawing.Size(94, 13);
            this.labelNomeJogador.TabIndex = 20;
            this.labelNomeJogador.Text = "Nome do Jogador:";
            // 
            // textBoxNickname
            // 
            this.textBoxNickname.Location = new System.Drawing.Point(102, 128);
            this.textBoxNickname.Name = "textBoxNickname";
            this.textBoxNickname.Size = new System.Drawing.Size(232, 20);
            this.textBoxNickname.TabIndex = 26;
            // 
            // EditarJogadorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 235);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.numericUpDownIdade);
            this.Controls.Add(this.labelIdade);
            this.Controls.Add(this.labelIdnome);
            this.Controls.Add(this.labelIdJogador);
            this.Controls.Add(this.buttonAlterarAvatar);
            this.Controls.Add(this.textBoxNickname);
            this.Controls.Add(this.labelNickname);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelEditarJogador);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelNomeJogador);
            this.Name = "EditarJogadorForm";
            this.Text = "Editar Jogador";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIdade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.NumericUpDown numericUpDownIdade;
        private System.Windows.Forms.Label labelIdade;
        private System.Windows.Forms.Label labelIdnome;
        private System.Windows.Forms.Label labelIdJogador;
        private System.Windows.Forms.Button buttonAlterarAvatar;
        private System.Windows.Forms.Label labelNickname;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelEditarJogador;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label labelNomeJogador;
        private System.Windows.Forms.TextBox textBoxNickname;
    }
}