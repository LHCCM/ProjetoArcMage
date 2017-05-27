namespace Projeto
{
    partial class EditarEquipaForm
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
            this.textBoxAvatar = new System.Windows.Forms.TextBox();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonEscolherAvatar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonProcurar = new System.Windows.Forms.Button();
            this.listBoxEquipa = new System.Windows.Forms.ListBox();
            this.listBoxJogadores = new System.Windows.Forms.ListBox();
            this.labelListaJogadores = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxAvatar
            // 
            this.textBoxAvatar.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxAvatar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAvatar.Location = new System.Drawing.Point(142, 201);
            this.textBoxAvatar.Name = "textBoxAvatar";
            this.textBoxAvatar.Size = new System.Drawing.Size(142, 13);
            this.textBoxAvatar.TabIndex = 29;
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.Location = new System.Drawing.Point(17, 229);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(115, 23);
            this.buttonAdicionar.TabIndex = 28;
            this.buttonAdicionar.Text = "Adicionar Jogador";
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Nome da Equipa";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(144, 146);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(142, 20);
            this.textBoxNome.TabIndex = 20;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(144, 99);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(142, 23);
            this.buttonRemove.TabIndex = 26;
            this.buttonRemove.Text = "Remover Jogador";
            this.buttonRemove.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Jogadores da Equipa";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(144, 220);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 132);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(176, 365);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 21;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            // 
            // buttonEscolherAvatar
            // 
            this.buttonEscolherAvatar.Location = new System.Drawing.Point(151, 172);
            this.buttonEscolherAvatar.Name = "buttonEscolherAvatar";
            this.buttonEscolherAvatar.Size = new System.Drawing.Size(123, 23);
            this.buttonEscolherAvatar.TabIndex = 23;
            this.buttonEscolherAvatar.Text = "Escolher Avatar";
            this.buttonEscolherAvatar.UseVisualStyleBackColor = true;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(37, 365);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 22;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.buttonProcurar);
            this.groupBox1.Location = new System.Drawing.Point(11, 258);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(127, 75);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar Jogador";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(115, 20);
            this.textBox1.TabIndex = 5;
            // 
            // buttonProcurar
            // 
            this.buttonProcurar.Location = new System.Drawing.Point(26, 45);
            this.buttonProcurar.Name = "buttonProcurar";
            this.buttonProcurar.Size = new System.Drawing.Size(75, 23);
            this.buttonProcurar.TabIndex = 4;
            this.buttonProcurar.Text = "Procurar";
            this.buttonProcurar.UseVisualStyleBackColor = true;
            // 
            // listBoxEquipa
            // 
            this.listBoxEquipa.FormattingEnabled = true;
            this.listBoxEquipa.Location = new System.Drawing.Point(144, 63);
            this.listBoxEquipa.Name = "listBoxEquipa";
            this.listBoxEquipa.Size = new System.Drawing.Size(142, 30);
            this.listBoxEquipa.TabIndex = 18;
            // 
            // listBoxJogadores
            // 
            this.listBoxJogadores.FormattingEnabled = true;
            this.listBoxJogadores.Location = new System.Drawing.Point(11, 63);
            this.listBoxJogadores.Name = "listBoxJogadores";
            this.listBoxJogadores.Size = new System.Drawing.Size(127, 160);
            this.listBoxJogadores.TabIndex = 17;
            // 
            // labelListaJogadores
            // 
            this.labelListaJogadores.AutoSize = true;
            this.labelListaJogadores.Location = new System.Drawing.Point(11, 47);
            this.labelListaJogadores.Name = "labelListaJogadores";
            this.labelListaJogadores.Size = new System.Drawing.Size(81, 13);
            this.labelListaJogadores.TabIndex = 16;
            this.labelListaJogadores.Text = "Lista Jogadores";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Editar Equipa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "ID:";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(34, 9);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(0, 13);
            this.labelID.TabIndex = 31;
            // 
            // EditarEquipaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 400);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxAvatar);
            this.Controls.Add(this.buttonAdicionar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.buttonEscolherAvatar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBoxEquipa);
            this.Controls.Add(this.listBoxJogadores);
            this.Controls.Add(this.labelListaJogadores);
            this.Controls.Add(this.label1);
            this.Name = "EditarEquipaForm";
            this.Text = "Editar Equipa";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAvatar;
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonEscolherAvatar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonProcurar;
        private System.Windows.Forms.ListBox listBoxEquipa;
        private System.Windows.Forms.ListBox listBoxJogadores;
        private System.Windows.Forms.Label labelListaJogadores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelID;
    }
}