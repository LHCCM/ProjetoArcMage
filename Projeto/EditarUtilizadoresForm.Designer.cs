namespace Projeto
{
    partial class EditarUtilizadoresForm
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
            this.listBoxUsers = new System.Windows.Forms.ListBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonConfirmar = new System.Windows.Forms.Button();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelEditarUtilizador = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.textBoxAvatar = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonEscolherAvatar = new System.Windows.Forms.Button();
            this.textBoxNickname = new System.Windows.Forms.TextBox();
            this.labelNickname = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 66;
            this.label1.Text = "Utilizadores Disponíveis";
            // 
            // listBoxUsers
            // 
            this.listBoxUsers.BackColor = System.Drawing.Color.White;
            this.listBoxUsers.FormattingEnabled = true;
            this.listBoxUsers.Location = new System.Drawing.Point(12, 61);
            this.listBoxUsers.Name = "listBoxUsers";
            this.listBoxUsers.Size = new System.Drawing.Size(140, 277);
            this.listBoxUsers.TabIndex = 65;
            this.listBoxUsers.SelectedIndexChanged += new System.EventHandler(this.listBoxAdmin_SelectedIndexChanged);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(294, 87);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.ReadOnly = true;
            this.textBoxPassword.Size = new System.Drawing.Size(232, 20);
            this.textBoxPassword.TabIndex = 64;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(225, 90);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(59, 13);
            this.labelPassword.TabIndex = 63;
            this.labelPassword.Text = "Password :";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(420, 321);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(106, 24);
            this.buttonCancelar.TabIndex = 62;
            this.buttonCancelar.Text = "Voltar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click_1);
            // 
            // buttonConfirmar
            // 
            this.buttonConfirmar.Location = new System.Drawing.Point(230, 320);
            this.buttonConfirmar.Name = "buttonConfirmar";
            this.buttonConfirmar.Size = new System.Drawing.Size(106, 24);
            this.buttonConfirmar.TabIndex = 61;
            this.buttonConfirmar.Text = "Confirmar";
            this.buttonConfirmar.UseVisualStyleBackColor = true;
            this.buttonConfirmar.Click += new System.EventHandler(this.buttonConfirmar_Click_1);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(294, 113);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(232, 20);
            this.textBoxEmail.TabIndex = 60;
            this.textBoxEmail.Visible = false;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(227, 116);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(38, 13);
            this.labelEmail.TabIndex = 59;
            this.labelEmail.Text = "Email :";
            this.labelEmail.Visible = false;
            // 
            // labelEditarUtilizador
            // 
            this.labelEditarUtilizador.AutoSize = true;
            this.labelEditarUtilizador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditarUtilizador.Location = new System.Drawing.Point(172, 15);
            this.labelEditarUtilizador.Name = "labelEditarUtilizador";
            this.labelEditarUtilizador.Size = new System.Drawing.Size(159, 24);
            this.labelEditarUtilizador.TabIndex = 58;
            this.labelEditarUtilizador.Text = "Editar Utilizadores";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(294, 61);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.ReadOnly = true;
            this.textBoxNome.Size = new System.Drawing.Size(232, 20);
            this.textBoxNome.TabIndex = 57;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(224, 64);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(41, 13);
            this.labelNome.TabIndex = 56;
            this.labelNome.Text = "Nome :";
            // 
            // textBoxAvatar
            // 
            this.textBoxAvatar.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxAvatar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAvatar.Location = new System.Drawing.Point(262, 272);
            this.textBoxAvatar.Name = "textBoxAvatar";
            this.textBoxAvatar.Size = new System.Drawing.Size(232, 13);
            this.textBoxAvatar.TabIndex = 73;
            this.textBoxAvatar.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(305, 139);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 132);
            this.pictureBox1.TabIndex = 70;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // buttonEscolherAvatar
            // 
            this.buttonEscolherAvatar.Location = new System.Drawing.Point(325, 291);
            this.buttonEscolherAvatar.Name = "buttonEscolherAvatar";
            this.buttonEscolherAvatar.Size = new System.Drawing.Size(106, 23);
            this.buttonEscolherAvatar.TabIndex = 69;
            this.buttonEscolherAvatar.Text = "Escolher Avatar";
            this.buttonEscolherAvatar.UseVisualStyleBackColor = true;
            this.buttonEscolherAvatar.Visible = false;
            this.buttonEscolherAvatar.Click += new System.EventHandler(this.buttonEscolherAvatar_Click);
            // 
            // textBoxNickname
            // 
            this.textBoxNickname.Location = new System.Drawing.Point(293, 113);
            this.textBoxNickname.Name = "textBoxNickname";
            this.textBoxNickname.Size = new System.Drawing.Size(232, 20);
            this.textBoxNickname.TabIndex = 68;
            this.textBoxNickname.Visible = false;
            // 
            // labelNickname
            // 
            this.labelNickname.AutoSize = true;
            this.labelNickname.Location = new System.Drawing.Point(224, 116);
            this.labelNickname.Name = "labelNickname";
            this.labelNickname.Size = new System.Drawing.Size(61, 13);
            this.labelNickname.TabIndex = 67;
            this.labelNickname.Text = "Nickname :";
            this.labelNickname.Visible = false;
            // 
            // EditarUtilizadoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 354);
            this.Controls.Add(this.textBoxAvatar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonEscolherAvatar);
            this.Controls.Add(this.textBoxNickname);
            this.Controls.Add(this.labelNickname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxUsers);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonConfirmar);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelEditarUtilizador);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelNome);
            this.Name = "EditarUtilizadoresForm";
            this.Text = "Editar Utilizadores";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxUsers;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonConfirmar;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelEditarUtilizador;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox textBoxAvatar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonEscolherAvatar;
        private System.Windows.Forms.TextBox textBoxNickname;
        private System.Windows.Forms.Label labelNickname;
    }
}