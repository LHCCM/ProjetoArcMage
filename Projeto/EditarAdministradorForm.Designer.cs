namespace Projeto
{
    partial class EditarAdministradorForm
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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonConfirmar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelEditarUtilizador = new System.Windows.Forms.Label();
            this.textBoxNomeCarta = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(90, 115);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(232, 20);
            this.textBox3.TabIndex = 53;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(23, 118);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(59, 13);
            this.labelPassword.TabIndex = 52;
            this.labelPassword.Text = "Password :";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(216, 170);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(106, 24);
            this.buttonCancelar.TabIndex = 50;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonConfirmar
            // 
            this.buttonConfirmar.Location = new System.Drawing.Point(26, 169);
            this.buttonConfirmar.Name = "buttonConfirmar";
            this.buttonConfirmar.Size = new System.Drawing.Size(106, 24);
            this.buttonConfirmar.TabIndex = 49;
            this.buttonConfirmar.Text = "Confirmar";
            this.buttonConfirmar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(90, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(232, 20);
            this.textBox1.TabIndex = 45;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(23, 88);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(38, 13);
            this.labelEmail.TabIndex = 44;
            this.labelEmail.Text = "Email :";
            // 
            // labelEditarUtilizador
            // 
            this.labelEditarUtilizador.AutoSize = true;
            this.labelEditarUtilizador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditarUtilizador.Location = new System.Drawing.Point(100, 9);
            this.labelEditarUtilizador.Name = "labelEditarUtilizador";
            this.labelEditarUtilizador.Size = new System.Drawing.Size(164, 24);
            this.labelEditarUtilizador.TabIndex = 43;
            this.labelEditarUtilizador.Text = "Editar Admistrador";
            // 
            // textBoxNomeCarta
            // 
            this.textBoxNomeCarta.Location = new System.Drawing.Point(90, 55);
            this.textBoxNomeCarta.Name = "textBoxNomeCarta";
            this.textBoxNomeCarta.Size = new System.Drawing.Size(232, 20);
            this.textBoxNomeCarta.TabIndex = 42;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(23, 58);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(41, 13);
            this.labelNome.TabIndex = 41;
            this.labelNome.Text = "Nome :";
            // 
            // EditarAdministradorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 223);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonConfirmar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelEditarUtilizador);
            this.Controls.Add(this.textBoxNomeCarta);
            this.Controls.Add(this.labelNome);
            this.Name = "EditarAdministradorForm";
            this.Text = "Editar Administrador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonConfirmar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelEditarUtilizador;
        private System.Windows.Forms.TextBox textBoxNomeCarta;
        private System.Windows.Forms.Label labelNome;
    }
}