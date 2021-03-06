﻿namespace Projeto
{
    partial class NovaEquipaForm
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
            this.labelListaJogadores = new System.Windows.Forms.Label();
            this.listBoxJogadores = new System.Windows.Forms.ListBox();
            this.listBoxEquipa = new System.Windows.Forms.ListBox();
            this.buttonProcurar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxProcura = new System.Windows.Forms.TextBox();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonEscolherAvatar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.textBoxAvatar = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nova Equipa";
            // 
            // labelListaJogadores
            // 
            this.labelListaJogadores.AutoSize = true;
            this.labelListaJogadores.Location = new System.Drawing.Point(12, 44);
            this.labelListaJogadores.Name = "labelListaJogadores";
            this.labelListaJogadores.Size = new System.Drawing.Size(81, 13);
            this.labelListaJogadores.TabIndex = 1;
            this.labelListaJogadores.Text = "Lista Jogadores";
            // 
            // listBoxJogadores
            // 
            this.listBoxJogadores.FormattingEnabled = true;
            this.listBoxJogadores.Location = new System.Drawing.Point(12, 60);
            this.listBoxJogadores.Name = "listBoxJogadores";
            this.listBoxJogadores.Size = new System.Drawing.Size(127, 160);
            this.listBoxJogadores.TabIndex = 2;
            // 
            // listBoxEquipa
            // 
            this.listBoxEquipa.FormattingEnabled = true;
            this.listBoxEquipa.Location = new System.Drawing.Point(145, 60);
            this.listBoxEquipa.Name = "listBoxEquipa";
            this.listBoxEquipa.Size = new System.Drawing.Size(142, 30);
            this.listBoxEquipa.TabIndex = 3;
            // 
            // buttonProcurar
            // 
            this.buttonProcurar.Location = new System.Drawing.Point(26, 45);
            this.buttonProcurar.Name = "buttonProcurar";
            this.buttonProcurar.Size = new System.Drawing.Size(75, 23);
            this.buttonProcurar.TabIndex = 4;
            this.buttonProcurar.Text = "Procurar";
            this.buttonProcurar.UseVisualStyleBackColor = true;
            this.buttonProcurar.Click += new System.EventHandler(this.buttonProcurar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxProcura);
            this.groupBox1.Controls.Add(this.buttonProcurar);
            this.groupBox1.Location = new System.Drawing.Point(12, 255);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(127, 75);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar Jogador";
            // 
            // textBoxProcura
            // 
            this.textBoxProcura.Location = new System.Drawing.Point(6, 19);
            this.textBoxProcura.Name = "textBoxProcura";
            this.textBoxProcura.Size = new System.Drawing.Size(115, 20);
            this.textBoxProcura.TabIndex = 5;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(177, 362);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(75, 23);
            this.buttonConfirm.TabIndex = 6;
            this.buttonConfirm.Text = "Confirmar";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(38, 362);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 7;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonEscolherAvatar
            // 
            this.buttonEscolherAvatar.Location = new System.Drawing.Point(152, 169);
            this.buttonEscolherAvatar.Name = "buttonEscolherAvatar";
            this.buttonEscolherAvatar.Size = new System.Drawing.Size(123, 23);
            this.buttonEscolherAvatar.TabIndex = 8;
            this.buttonEscolherAvatar.Text = "Escolher Avatar";
            this.buttonEscolherAvatar.UseVisualStyleBackColor = true;
            this.buttonEscolherAvatar.Click += new System.EventHandler(this.buttonEscolherAvatar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(145, 217);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 132);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Jogadores da Equipa";
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(145, 96);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(142, 23);
            this.buttonRemove.TabIndex = 11;
            this.buttonRemove.Text = "Remover Jogador";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(145, 143);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(142, 20);
            this.textBoxNome.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nome da Equipa";
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.Location = new System.Drawing.Point(18, 226);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(115, 23);
            this.buttonAdicionar.TabIndex = 13;
            this.buttonAdicionar.Text = "Adicionar Jogador";
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            this.buttonAdicionar.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // textBoxAvatar
            // 
            this.textBoxAvatar.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxAvatar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAvatar.Location = new System.Drawing.Point(143, 198);
            this.textBoxAvatar.Name = "textBoxAvatar";
            this.textBoxAvatar.Size = new System.Drawing.Size(142, 13);
            this.textBoxAvatar.TabIndex = 14;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // NovaEquipaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 400);
            this.Controls.Add(this.textBoxAvatar);
            this.Controls.Add(this.buttonAdicionar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.buttonEscolherAvatar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBoxEquipa);
            this.Controls.Add(this.listBoxJogadores);
            this.Controls.Add(this.labelListaJogadores);
            this.Controls.Add(this.label1);
            this.Name = "NovaEquipaForm";
            this.Text = "Nova Equipa";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelListaJogadores;
        private System.Windows.Forms.ListBox listBoxJogadores;
        private System.Windows.Forms.ListBox listBoxEquipa;
        private System.Windows.Forms.Button buttonProcurar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxProcura;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonEscolherAvatar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.TextBox textBoxAvatar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}