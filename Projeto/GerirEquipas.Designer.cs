namespace Projeto
{
    partial class GerirEquipasForm
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
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.buttonApagarEquipa = new System.Windows.Forms.Button();
            this.listBoxEquipas = new System.Windows.Forms.ListBox();
            this.labelListaEquipas = new System.Windows.Forms.Label();
            this.labelInfoEquipa = new System.Windows.Forms.Label();
            this.labelGerirEquipas = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelPesquisa = new System.Windows.Forms.Label();
            this.buttonNovaEquipa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelP1 = new System.Windows.Forms.Label();
            this.labelP2 = new System.Windows.Forms.Label();
            this.buttonEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Location = new System.Drawing.Point(175, 360);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(121, 23);
            this.buttonVoltar.TabIndex = 33;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.UseVisualStyleBackColor = true;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // buttonApagarEquipa
            // 
            this.buttonApagarEquipa.Location = new System.Drawing.Point(175, 332);
            this.buttonApagarEquipa.Name = "buttonApagarEquipa";
            this.buttonApagarEquipa.Size = new System.Drawing.Size(121, 23);
            this.buttonApagarEquipa.TabIndex = 31;
            this.buttonApagarEquipa.Text = "Apagar Equipa";
            this.buttonApagarEquipa.UseVisualStyleBackColor = true;
            this.buttonApagarEquipa.Click += new System.EventHandler(this.buttonApagarEquipa_Click);
            // 
            // listBoxEquipas
            // 
            this.listBoxEquipas.FormattingEnabled = true;
            this.listBoxEquipas.Location = new System.Drawing.Point(12, 71);
            this.listBoxEquipas.Name = "listBoxEquipas";
            this.listBoxEquipas.Size = new System.Drawing.Size(126, 238);
            this.listBoxEquipas.TabIndex = 28;
            this.listBoxEquipas.SelectedIndexChanged += new System.EventHandler(this.listBoxEquipas_SelectedIndexChanged);
            // 
            // labelListaEquipas
            // 
            this.labelListaEquipas.AutoSize = true;
            this.labelListaEquipas.Location = new System.Drawing.Point(9, 54);
            this.labelListaEquipas.Name = "labelListaEquipas";
            this.labelListaEquipas.Size = new System.Drawing.Size(45, 13);
            this.labelListaEquipas.TabIndex = 27;
            this.labelListaEquipas.Text = "Equipas";
            // 
            // labelInfoEquipa
            // 
            this.labelInfoEquipa.AutoSize = true;
            this.labelInfoEquipa.Location = new System.Drawing.Point(172, 54);
            this.labelInfoEquipa.Name = "labelInfoEquipa";
            this.labelInfoEquipa.Size = new System.Drawing.Size(101, 13);
            this.labelInfoEquipa.TabIndex = 26;
            this.labelInfoEquipa.Text = "Informações Equipa";
            // 
            // labelGerirEquipas
            // 
            this.labelGerirEquipas.AutoSize = true;
            this.labelGerirEquipas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGerirEquipas.Location = new System.Drawing.Point(103, 9);
            this.labelGerirEquipas.Name = "labelGerirEquipas";
            this.labelGerirEquipas.Size = new System.Drawing.Size(125, 24);
            this.labelGerirEquipas.TabIndex = 25;
            this.labelGerirEquipas.Text = "Gerir Equipas";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(161, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 132);
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(17, 334);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 35;
            // 
            // labelPesquisa
            // 
            this.labelPesquisa.AutoSize = true;
            this.labelPesquisa.Location = new System.Drawing.Point(14, 318);
            this.labelPesquisa.Name = "labelPesquisa";
            this.labelPesquisa.Size = new System.Drawing.Size(83, 13);
            this.labelPesquisa.TabIndex = 36;
            this.labelPesquisa.Text = "Procurar Equipa";
            // 
            // buttonNovaEquipa
            // 
            this.buttonNovaEquipa.Location = new System.Drawing.Point(17, 360);
            this.buttonNovaEquipa.Name = "buttonNovaEquipa";
            this.buttonNovaEquipa.Size = new System.Drawing.Size(121, 23);
            this.buttonNovaEquipa.TabIndex = 37;
            this.buttonNovaEquipa.Text = "Nova Equipa";
            this.buttonNovaEquipa.UseVisualStyleBackColor = true;
            this.buttonNovaEquipa.Click += new System.EventHandler(this.buttonNovaEquipa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "ID:";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(185, 205);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(0, 13);
            this.labelID.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Nome:";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(202, 232);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(0, 13);
            this.labelNome.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "P1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 49;
            this.label4.Text = "P2:";
            // 
            // labelP1
            // 
            this.labelP1.AutoSize = true;
            this.labelP1.Location = new System.Drawing.Point(187, 257);
            this.labelP1.Name = "labelP1";
            this.labelP1.Size = new System.Drawing.Size(0, 13);
            this.labelP1.TabIndex = 50;
            // 
            // labelP2
            // 
            this.labelP2.AutoSize = true;
            this.labelP2.Location = new System.Drawing.Point(187, 281);
            this.labelP2.Name = "labelP2";
            this.labelP2.Size = new System.Drawing.Size(0, 13);
            this.labelP2.TabIndex = 51;
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(175, 303);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(121, 23);
            this.buttonEditar.TabIndex = 52;
            this.buttonEditar.Text = "Editar Equipa";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // GerirEquipasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 393);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.labelP2);
            this.Controls.Add(this.labelP1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonNovaEquipa);
            this.Controls.Add(this.labelPesquisa);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.buttonApagarEquipa);
            this.Controls.Add(this.listBoxEquipas);
            this.Controls.Add(this.labelListaEquipas);
            this.Controls.Add(this.labelInfoEquipa);
            this.Controls.Add(this.labelGerirEquipas);
            this.Name = "GerirEquipasForm";
            this.Text = "GerirEquipas";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.Button buttonApagarEquipa;
        private System.Windows.Forms.ListBox listBoxEquipas;
        private System.Windows.Forms.Label labelListaEquipas;
        private System.Windows.Forms.Label labelInfoEquipa;
        private System.Windows.Forms.Label labelGerirEquipas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelPesquisa;
        private System.Windows.Forms.Button buttonNovaEquipa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelP1;
        private System.Windows.Forms.Label labelP2;
        private System.Windows.Forms.Button buttonEditar;
    }
}