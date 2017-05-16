namespace Projeto
{
    partial class CartasForm
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
            this.buttonEditarCarta = new System.Windows.Forms.Button();
            this.buttonApagarCarta = new System.Windows.Forms.Button();
            this.buttonAdicionarCarta = new System.Windows.Forms.Button();
            this.listBoxCartas = new System.Windows.Forms.ListBox();
            this.labelCarta = new System.Windows.Forms.Label();
            this.labelCartas = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelLeal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelCusto = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelDefesa = new System.Windows.Forms.Label();
            this.labelAtaque = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelTipo = new System.Windows.Forms.Label();
            this.labelFacao = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxRegraCarta = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Location = new System.Drawing.Point(218, 354);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(121, 23);
            this.buttonVoltar.TabIndex = 20;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.UseVisualStyleBackColor = true;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // buttonEditarCarta
            // 
            this.buttonEditarCarta.Location = new System.Drawing.Point(11, 326);
            this.buttonEditarCarta.Name = "buttonEditarCarta";
            this.buttonEditarCarta.Size = new System.Drawing.Size(121, 23);
            this.buttonEditarCarta.TabIndex = 19;
            this.buttonEditarCarta.Text = "Editar Carta";
            this.buttonEditarCarta.UseVisualStyleBackColor = true;
            this.buttonEditarCarta.Click += new System.EventHandler(this.buttonEditarCarta_Click);
            // 
            // buttonApagarCarta
            // 
            this.buttonApagarCarta.Location = new System.Drawing.Point(11, 354);
            this.buttonApagarCarta.Name = "buttonApagarCarta";
            this.buttonApagarCarta.Size = new System.Drawing.Size(121, 23);
            this.buttonApagarCarta.TabIndex = 18;
            this.buttonApagarCarta.Text = "Apagar Carta";
            this.buttonApagarCarta.UseVisualStyleBackColor = true;
            this.buttonApagarCarta.Click += new System.EventHandler(this.buttonApagarCarta_Click);
            // 
            // buttonAdicionarCarta
            // 
            this.buttonAdicionarCarta.Location = new System.Drawing.Point(12, 297);
            this.buttonAdicionarCarta.Name = "buttonAdicionarCarta";
            this.buttonAdicionarCarta.Size = new System.Drawing.Size(121, 23);
            this.buttonAdicionarCarta.TabIndex = 17;
            this.buttonAdicionarCarta.Text = "Adicionar Carta";
            this.buttonAdicionarCarta.UseVisualStyleBackColor = true;
            this.buttonAdicionarCarta.Click += new System.EventHandler(this.buttonAdicionarCarta_Click);
            // 
            // listBoxCartas
            // 
            this.listBoxCartas.FormattingEnabled = true;
            this.listBoxCartas.Location = new System.Drawing.Point(12, 66);
            this.listBoxCartas.Name = "listBoxCartas";
            this.listBoxCartas.Size = new System.Drawing.Size(120, 225);
            this.listBoxCartas.TabIndex = 15;
            this.listBoxCartas.SelectedIndexChanged += new System.EventHandler(this.listBoxCartas_SelectedIndexChanged);
            // 
            // labelCarta
            // 
            this.labelCarta.AutoSize = true;
            this.labelCarta.Location = new System.Drawing.Point(12, 50);
            this.labelCarta.Name = "labelCarta";
            this.labelCarta.Size = new System.Drawing.Size(37, 13);
            this.labelCarta.TabIndex = 13;
            this.labelCarta.Text = "Cartas";
            // 
            // labelCartas
            // 
            this.labelCartas.AutoSize = true;
            this.labelCartas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCartas.Location = new System.Drawing.Point(140, 9);
            this.labelCartas.Name = "labelCartas";
            this.labelCartas.Size = new System.Drawing.Size(70, 25);
            this.labelCartas.TabIndex = 12;
            this.labelCartas.Text = "Cartas";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxRegraCarta);
            this.groupBox1.Controls.Add(this.labelLeal);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.labelCusto);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.labelDefesa);
            this.groupBox1.Controls.Add(this.labelAtaque);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.labelTipo);
            this.groupBox1.Controls.Add(this.labelFacao);
            this.groupBox1.Controls.Add(this.labelNome);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(145, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 298);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informação";
            // 
            // labelLeal
            // 
            this.labelLeal.AutoSize = true;
            this.labelLeal.Location = new System.Drawing.Point(70, 116);
            this.labelLeal.Name = "labelLeal";
            this.labelLeal.Size = new System.Drawing.Size(0, 13);
            this.labelLeal.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Lealdade:";
            // 
            // labelCusto
            // 
            this.labelCusto.AutoSize = true;
            this.labelCusto.Location = new System.Drawing.Point(70, 96);
            this.labelCusto.Name = "labelCusto";
            this.labelCusto.Size = new System.Drawing.Size(0, 13);
            this.labelCusto.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Custo:";
            // 
            // labelDefesa
            // 
            this.labelDefesa.AutoSize = true;
            this.labelDefesa.Location = new System.Drawing.Point(70, 74);
            this.labelDefesa.Name = "labelDefesa";
            this.labelDefesa.Size = new System.Drawing.Size(0, 13);
            this.labelDefesa.TabIndex = 11;
            // 
            // labelAtaque
            // 
            this.labelAtaque.AutoSize = true;
            this.labelAtaque.Location = new System.Drawing.Point(70, 50);
            this.labelAtaque.Name = "labelAtaque";
            this.labelAtaque.Size = new System.Drawing.Size(0, 13);
            this.labelAtaque.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Defesa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ataque:";
            // 
            // labelTipo
            // 
            this.labelTipo.AutoSize = true;
            this.labelTipo.Location = new System.Drawing.Point(70, 270);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(0, 13);
            this.labelTipo.TabIndex = 7;
            // 
            // labelFacao
            // 
            this.labelFacao.AutoSize = true;
            this.labelFacao.Location = new System.Drawing.Point(70, 248);
            this.labelFacao.Name = "labelFacao";
            this.labelFacao.Size = new System.Drawing.Size(0, 13);
            this.labelFacao.TabIndex = 6;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(70, 28);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(0, 13);
            this.labelNome.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tipo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fação:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Regras:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // textBoxRegraCarta
            // 
            this.textBoxRegraCarta.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxRegraCarta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRegraCarta.Location = new System.Drawing.Point(60, 136);
            this.textBoxRegraCarta.Multiline = true;
            this.textBoxRegraCarta.Name = "textBoxRegraCarta";
            this.textBoxRegraCarta.Size = new System.Drawing.Size(128, 75);
            this.textBoxRegraCarta.TabIndex = 16;
            // 
            // CartasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 389);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.buttonEditarCarta);
            this.Controls.Add(this.buttonApagarCarta);
            this.Controls.Add(this.buttonAdicionarCarta);
            this.Controls.Add(this.listBoxCartas);
            this.Controls.Add(this.labelCarta);
            this.Controls.Add(this.labelCartas);
            this.Name = "CartasForm";
            this.Text = "Cartas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.Button buttonEditarCarta;
        private System.Windows.Forms.Button buttonApagarCarta;
        private System.Windows.Forms.Button buttonAdicionarCarta;
        private System.Windows.Forms.ListBox listBoxCartas;
        private System.Windows.Forms.Label labelCarta;
        private System.Windows.Forms.Label labelCartas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTipo;
        private System.Windows.Forms.Label labelFacao;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelLeal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelCusto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelDefesa;
        private System.Windows.Forms.Label labelAtaque;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxRegraCarta;
    }
}