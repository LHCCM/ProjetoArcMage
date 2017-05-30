namespace Projeto
{
    partial class TorneioForm
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
            this.listBoxTorneio = new System.Windows.Forms.ListBox();
            this.listBoxJogo = new System.Windows.Forms.ListBox();
            this.buttonNovoTorneio = new System.Windows.Forms.Button();
            this.buttonEditarTorneio = new System.Windows.Forms.Button();
            this.buttonCancelarTorneio = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonCancelarJogo = new System.Windows.Forms.Button();
            this.buttonEditarJogo = new System.Windows.Forms.Button();
            this.buttonCriarJogo = new System.Windows.Forms.Button();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.labelDesc = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxTorneio
            // 
            this.listBoxTorneio.FormattingEnabled = true;
            this.listBoxTorneio.Location = new System.Drawing.Point(13, 53);
            this.listBoxTorneio.Name = "listBoxTorneio";
            this.listBoxTorneio.Size = new System.Drawing.Size(199, 290);
            this.listBoxTorneio.TabIndex = 0;
            this.listBoxTorneio.SelectedIndexChanged += new System.EventHandler(this.listBoxTorneio_SelectedIndexChanged);
            // 
            // listBoxJogo
            // 
            this.listBoxJogo.FormattingEnabled = true;
            this.listBoxJogo.Location = new System.Drawing.Point(218, 53);
            this.listBoxJogo.Name = "listBoxJogo";
            this.listBoxJogo.Size = new System.Drawing.Size(199, 290);
            this.listBoxJogo.TabIndex = 1;
            // 
            // buttonNovoTorneio
            // 
            this.buttonNovoTorneio.Location = new System.Drawing.Point(13, 399);
            this.buttonNovoTorneio.Name = "buttonNovoTorneio";
            this.buttonNovoTorneio.Size = new System.Drawing.Size(120, 23);
            this.buttonNovoTorneio.TabIndex = 3;
            this.buttonNovoTorneio.Text = "Novo Torneio";
            this.buttonNovoTorneio.UseVisualStyleBackColor = true;
            this.buttonNovoTorneio.Click += new System.EventHandler(this.buttonNovoTorneio_Click);
            // 
            // buttonEditarTorneio
            // 
            this.buttonEditarTorneio.Location = new System.Drawing.Point(13, 428);
            this.buttonEditarTorneio.Name = "buttonEditarTorneio";
            this.buttonEditarTorneio.Size = new System.Drawing.Size(120, 23);
            this.buttonEditarTorneio.TabIndex = 4;
            this.buttonEditarTorneio.Text = "Editar Torneio";
            this.buttonEditarTorneio.UseVisualStyleBackColor = true;
            this.buttonEditarTorneio.Click += new System.EventHandler(this.buttonEditarTorneio_Click);
            // 
            // buttonCancelarTorneio
            // 
            this.buttonCancelarTorneio.Location = new System.Drawing.Point(13, 457);
            this.buttonCancelarTorneio.Name = "buttonCancelarTorneio";
            this.buttonCancelarTorneio.Size = new System.Drawing.Size(120, 23);
            this.buttonCancelarTorneio.TabIndex = 5;
            this.buttonCancelarTorneio.Text = "Cancelar Torneio";
            this.buttonCancelarTorneio.UseVisualStyleBackColor = true;
            this.buttonCancelarTorneio.Click += new System.EventHandler(this.buttonCancelarTorneio_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 373);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(199, 20);
            this.textBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 357);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Pesquisar Torneios";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(218, 373);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(199, 20);
            this.textBox2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Pesquisar Jogos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Torneios";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(283, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Jogos";
            // 
            // buttonCancelarJogo
            // 
            this.buttonCancelarJogo.Location = new System.Drawing.Point(218, 457);
            this.buttonCancelarJogo.Name = "buttonCancelarJogo";
            this.buttonCancelarJogo.Size = new System.Drawing.Size(120, 23);
            this.buttonCancelarJogo.TabIndex = 16;
            this.buttonCancelarJogo.Text = "Cancelar Jogo";
            this.buttonCancelarJogo.UseMnemonic = false;
            this.buttonCancelarJogo.UseVisualStyleBackColor = true;
            // 
            // buttonEditarJogo
            // 
            this.buttonEditarJogo.Location = new System.Drawing.Point(218, 428);
            this.buttonEditarJogo.Name = "buttonEditarJogo";
            this.buttonEditarJogo.Size = new System.Drawing.Size(120, 23);
            this.buttonEditarJogo.TabIndex = 15;
            this.buttonEditarJogo.Text = "Editar Jogo";
            this.buttonEditarJogo.UseVisualStyleBackColor = true;
            this.buttonEditarJogo.Click += new System.EventHandler(this.buttonEditarJogo_Click);
            // 
            // buttonCriarJogo
            // 
            this.buttonCriarJogo.Location = new System.Drawing.Point(218, 399);
            this.buttonCriarJogo.Name = "buttonCriarJogo";
            this.buttonCriarJogo.Size = new System.Drawing.Size(120, 23);
            this.buttonCriarJogo.TabIndex = 14;
            this.buttonCriarJogo.Text = "Criar Jogo";
            this.buttonCriarJogo.UseVisualStyleBackColor = true;
            this.buttonCriarJogo.Click += new System.EventHandler(this.buttonCriarJogo_Click);
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Location = new System.Drawing.Point(495, 457);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(120, 23);
            this.buttonVoltar.TabIndex = 17;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.UseMnemonic = false;
            this.buttonVoltar.UseVisualStyleBackColor = true;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(246, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 24);
            this.label7.TabIndex = 18;
            this.label7.Text = "TORNEIOS";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelDesc);
            this.groupBox1.Controls.Add(this.labelData);
            this.groupBox1.Controls.Add(this.labelNome);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(423, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 290);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações do Torneio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nome";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Data";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Descrição";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(61, 20);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(0, 13);
            this.labelNome.TabIndex = 3;
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(61, 79);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(0, 13);
            this.labelData.TabIndex = 4;
            // 
            // labelDesc
            // 
            this.labelDesc.AutoSize = true;
            this.labelDesc.Location = new System.Drawing.Point(69, 140);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(0, 13);
            this.labelDesc.TabIndex = 5;
            // 
            // TorneioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 495);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.buttonCancelarJogo);
            this.Controls.Add(this.buttonEditarJogo);
            this.Controls.Add(this.buttonCriarJogo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonCancelarTorneio);
            this.Controls.Add(this.buttonEditarTorneio);
            this.Controls.Add(this.buttonNovoTorneio);
            this.Controls.Add(this.listBoxJogo);
            this.Controls.Add(this.listBoxTorneio);
            this.Name = "TorneioForm";
            this.Text = "Torneios";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxTorneio;
        private System.Windows.Forms.ListBox listBoxJogo;
        private System.Windows.Forms.Button buttonNovoTorneio;
        private System.Windows.Forms.Button buttonEditarTorneio;
        private System.Windows.Forms.Button buttonCancelarTorneio;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonCancelarJogo;
        private System.Windows.Forms.Button buttonEditarJogo;
        private System.Windows.Forms.Button buttonCriarJogo;
        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelDesc;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
    }
}