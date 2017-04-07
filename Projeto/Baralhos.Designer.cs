namespace Projeto
{
    partial class BaralhosForm
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
            this.labelCartas = new System.Windows.Forms.Label();
            this.labelBaralhos = new System.Windows.Forms.Label();
            this.labelListaCartas = new System.Windows.Forms.Label();
            this.listBoxBaralhos = new System.Windows.Forms.ListBox();
            this.listBoxListaCartas = new System.Windows.Forms.ListBox();
            this.buttonAdicionarBaralho = new System.Windows.Forms.Button();
            this.buttonApagarBaralho = new System.Windows.Forms.Button();
            this.buttonEditarBaralho = new System.Windows.Forms.Button();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCartas
            // 
            this.labelCartas.AutoSize = true;
            this.labelCartas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCartas.Location = new System.Drawing.Point(132, 9);
            this.labelCartas.Name = "labelCartas";
            this.labelCartas.Size = new System.Drawing.Size(89, 25);
            this.labelCartas.TabIndex = 3;
            this.labelCartas.Text = "Baralhos";
            // 
            // labelBaralhos
            // 
            this.labelBaralhos.AutoSize = true;
            this.labelBaralhos.Location = new System.Drawing.Point(13, 35);
            this.labelBaralhos.Name = "labelBaralhos";
            this.labelBaralhos.Size = new System.Drawing.Size(48, 13);
            this.labelBaralhos.TabIndex = 4;
            this.labelBaralhos.Text = "Baralhos";
            // 
            // labelListaCartas
            // 
            this.labelListaCartas.AutoSize = true;
            this.labelListaCartas.Location = new System.Drawing.Point(233, 36);
            this.labelListaCartas.Name = "labelListaCartas";
            this.labelListaCartas.Size = new System.Drawing.Size(62, 13);
            this.labelListaCartas.TabIndex = 5;
            this.labelListaCartas.Text = "Lista Cartas";
            // 
            // listBoxBaralhos
            // 
            this.listBoxBaralhos.FormattingEnabled = true;
            this.listBoxBaralhos.Location = new System.Drawing.Point(13, 52);
            this.listBoxBaralhos.Name = "listBoxBaralhos";
            this.listBoxBaralhos.Size = new System.Drawing.Size(120, 251);
            this.listBoxBaralhos.TabIndex = 6;
            // 
            // listBoxListaCartas
            // 
            this.listBoxListaCartas.FormattingEnabled = true;
            this.listBoxListaCartas.Location = new System.Drawing.Point(236, 52);
            this.listBoxListaCartas.Name = "listBoxListaCartas";
            this.listBoxListaCartas.Size = new System.Drawing.Size(117, 251);
            this.listBoxListaCartas.TabIndex = 7;
            // 
            // buttonAdicionarBaralho
            // 
            this.buttonAdicionarBaralho.Location = new System.Drawing.Point(12, 314);
            this.buttonAdicionarBaralho.Name = "buttonAdicionarBaralho";
            this.buttonAdicionarBaralho.Size = new System.Drawing.Size(121, 23);
            this.buttonAdicionarBaralho.TabIndex = 8;
            this.buttonAdicionarBaralho.Text = "Adicionar Baralho";
            this.buttonAdicionarBaralho.UseVisualStyleBackColor = true;
            // 
            // buttonApagarBaralho
            // 
            this.buttonApagarBaralho.Location = new System.Drawing.Point(12, 343);
            this.buttonApagarBaralho.Name = "buttonApagarBaralho";
            this.buttonApagarBaralho.Size = new System.Drawing.Size(121, 23);
            this.buttonApagarBaralho.TabIndex = 9;
            this.buttonApagarBaralho.Text = "Apagar Baralho";
            this.buttonApagarBaralho.UseVisualStyleBackColor = true;
            // 
            // buttonEditarBaralho
            // 
            this.buttonEditarBaralho.Location = new System.Drawing.Point(232, 309);
            this.buttonEditarBaralho.Name = "buttonEditarBaralho";
            this.buttonEditarBaralho.Size = new System.Drawing.Size(121, 23);
            this.buttonEditarBaralho.TabIndex = 10;
            this.buttonEditarBaralho.Text = "Editar Baralho";
            this.buttonEditarBaralho.UseVisualStyleBackColor = true;
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Location = new System.Drawing.Point(232, 338);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(121, 23);
            this.buttonVoltar.TabIndex = 11;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.UseVisualStyleBackColor = true;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // BaralhosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 378);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.buttonEditarBaralho);
            this.Controls.Add(this.buttonApagarBaralho);
            this.Controls.Add(this.buttonAdicionarBaralho);
            this.Controls.Add(this.listBoxListaCartas);
            this.Controls.Add(this.listBoxBaralhos);
            this.Controls.Add(this.labelListaCartas);
            this.Controls.Add(this.labelBaralhos);
            this.Controls.Add(this.labelCartas);
            this.Name = "BaralhosForm";
            this.Text = "Baralhos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCartas;
        private System.Windows.Forms.Label labelBaralhos;
        private System.Windows.Forms.Label labelListaCartas;
        private System.Windows.Forms.ListBox listBoxBaralhos;
        private System.Windows.Forms.ListBox listBoxListaCartas;
        private System.Windows.Forms.Button buttonAdicionarBaralho;
        private System.Windows.Forms.Button buttonApagarBaralho;
        private System.Windows.Forms.Button buttonEditarBaralho;
        private System.Windows.Forms.Button buttonVoltar;
    }
}