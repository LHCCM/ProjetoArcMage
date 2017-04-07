namespace Projeto
{
    partial class EditarBaralhoForm
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
            this.labelEditarBaralho = new System.Windows.Forms.Label();
            this.labelNomeBaralho = new System.Windows.Forms.Label();
            this.listBoxTotalCartas = new System.Windows.Forms.ListBox();
            this.listBoxCartasBaralho = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelProcurarCartas = new System.Windows.Forms.Label();
            this.textBoxProcura = new System.Windows.Forms.TextBox();
            this.buttonAdicionarCartaBaralho = new System.Windows.Forms.Button();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.buttonRemoverCartaBaralho = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelEditarBaralho
            // 
            this.labelEditarBaralho.AutoSize = true;
            this.labelEditarBaralho.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditarBaralho.Location = new System.Drawing.Point(102, 9);
            this.labelEditarBaralho.Name = "labelEditarBaralho";
            this.labelEditarBaralho.Size = new System.Drawing.Size(127, 24);
            this.labelEditarBaralho.TabIndex = 0;
            this.labelEditarBaralho.Text = "Editar Baralho";
            // 
            // labelNomeBaralho
            // 
            this.labelNomeBaralho.AutoSize = true;
            this.labelNomeBaralho.Location = new System.Drawing.Point(128, 33);
            this.labelNomeBaralho.Name = "labelNomeBaralho";
            this.labelNomeBaralho.Size = new System.Drawing.Size(89, 13);
            this.labelNomeBaralho.TabIndex = 1;
            this.labelNomeBaralho.Text = "Nome do Baralho";
            // 
            // listBoxTotalCartas
            // 
            this.listBoxTotalCartas.FormattingEnabled = true;
            this.listBoxTotalCartas.Location = new System.Drawing.Point(12, 85);
            this.listBoxTotalCartas.Name = "listBoxTotalCartas";
            this.listBoxTotalCartas.Size = new System.Drawing.Size(107, 251);
            this.listBoxTotalCartas.TabIndex = 2;
            // 
            // listBoxCartasBaralho
            // 
            this.listBoxCartasBaralho.FormattingEnabled = true;
            this.listBoxCartasBaralho.Location = new System.Drawing.Point(226, 85);
            this.listBoxCartasBaralho.Name = "listBoxCartasBaralho";
            this.listBoxCartasBaralho.Size = new System.Drawing.Size(107, 251);
            this.listBoxCartasBaralho.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome do Baralho";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cartas Disponíveis";
            // 
            // labelProcurarCartas
            // 
            this.labelProcurarCartas.AutoSize = true;
            this.labelProcurarCartas.Location = new System.Drawing.Point(12, 350);
            this.labelProcurarCartas.Name = "labelProcurarCartas";
            this.labelProcurarCartas.Size = new System.Drawing.Size(80, 13);
            this.labelProcurarCartas.TabIndex = 6;
            this.labelProcurarCartas.Text = "Procurar Cartas";
            // 
            // textBoxProcura
            // 
            this.textBoxProcura.Location = new System.Drawing.Point(15, 372);
            this.textBoxProcura.Name = "textBoxProcura";
            this.textBoxProcura.Size = new System.Drawing.Size(104, 20);
            this.textBoxProcura.TabIndex = 7;
            // 
            // buttonAdicionarCartaBaralho
            // 
            this.buttonAdicionarCartaBaralho.Location = new System.Drawing.Point(15, 398);
            this.buttonAdicionarCartaBaralho.Name = "buttonAdicionarCartaBaralho";
            this.buttonAdicionarCartaBaralho.Size = new System.Drawing.Size(100, 23);
            this.buttonAdicionarCartaBaralho.TabIndex = 8;
            this.buttonAdicionarCartaBaralho.Text = "Adicionar Carta";
            this.buttonAdicionarCartaBaralho.UseVisualStyleBackColor = true;
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Location = new System.Drawing.Point(226, 398);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(99, 23);
            this.buttonVoltar.TabIndex = 9;
            this.buttonVoltar.Text = "Guardar e Voltar";
            this.buttonVoltar.UseVisualStyleBackColor = true;
            // 
            // buttonRemoverCartaBaralho
            // 
            this.buttonRemoverCartaBaralho.Location = new System.Drawing.Point(226, 369);
            this.buttonRemoverCartaBaralho.Name = "buttonRemoverCartaBaralho";
            this.buttonRemoverCartaBaralho.Size = new System.Drawing.Size(100, 23);
            this.buttonRemoverCartaBaralho.TabIndex = 10;
            this.buttonRemoverCartaBaralho.Text = "Remover Carta";
            this.buttonRemoverCartaBaralho.UseVisualStyleBackColor = true;
            // 
            // EditarBaralho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 433);
            this.Controls.Add(this.buttonRemoverCartaBaralho);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.buttonAdicionarCartaBaralho);
            this.Controls.Add(this.textBoxProcura);
            this.Controls.Add(this.labelProcurarCartas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxCartasBaralho);
            this.Controls.Add(this.listBoxTotalCartas);
            this.Controls.Add(this.labelNomeBaralho);
            this.Controls.Add(this.labelEditarBaralho);
            this.Name = "EditarBaralho";
            this.Text = "Editar Baralho";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEditarBaralho;
        private System.Windows.Forms.Label labelNomeBaralho;
        private System.Windows.Forms.ListBox listBoxTotalCartas;
        private System.Windows.Forms.ListBox listBoxCartasBaralho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelProcurarCartas;
        private System.Windows.Forms.TextBox textBoxProcura;
        private System.Windows.Forms.Button buttonAdicionarCartaBaralho;
        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.Button buttonRemoverCartaBaralho;
    }
}