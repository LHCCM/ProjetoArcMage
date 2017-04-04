namespace Projeto
{
    partial class Cartas
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
            this.listBoxListaCartas = new System.Windows.Forms.ListBox();
            this.listBoxBaralhos = new System.Windows.Forms.ListBox();
            this.labelListaCartas = new System.Windows.Forms.Label();
            this.labelCarta = new System.Windows.Forms.Label();
            this.labelCartas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Location = new System.Drawing.Point(241, 354);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(121, 23);
            this.buttonVoltar.TabIndex = 20;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.UseVisualStyleBackColor = true;
            // 
            // buttonEditarCarta
            // 
            this.buttonEditarCarta.Location = new System.Drawing.Point(21, 326);
            this.buttonEditarCarta.Name = "buttonEditarCarta";
            this.buttonEditarCarta.Size = new System.Drawing.Size(121, 23);
            this.buttonEditarCarta.TabIndex = 19;
            this.buttonEditarCarta.Text = "Editar Carta";
            this.buttonEditarCarta.UseVisualStyleBackColor = true;
            // 
            // buttonApagarCarta
            // 
            this.buttonApagarCarta.Location = new System.Drawing.Point(22, 355);
            this.buttonApagarCarta.Name = "buttonApagarCarta";
            this.buttonApagarCarta.Size = new System.Drawing.Size(121, 23);
            this.buttonApagarCarta.TabIndex = 18;
            this.buttonApagarCarta.Text = "Apagar Carta";
            this.buttonApagarCarta.UseVisualStyleBackColor = true;
            // 
            // buttonAdicionarCarta
            // 
            this.buttonAdicionarCarta.Location = new System.Drawing.Point(22, 297);
            this.buttonAdicionarCarta.Name = "buttonAdicionarCarta";
            this.buttonAdicionarCarta.Size = new System.Drawing.Size(121, 23);
            this.buttonAdicionarCarta.TabIndex = 17;
            this.buttonAdicionarCarta.Text = "Adicionar Carta";
            this.buttonAdicionarCarta.UseVisualStyleBackColor = true;
            // 
            // listBoxListaCartas
            // 
            this.listBoxListaCartas.FormattingEnabled = true;
            this.listBoxListaCartas.Location = new System.Drawing.Point(193, 66);
            this.listBoxListaCartas.Name = "listBoxListaCartas";
            this.listBoxListaCartas.Size = new System.Drawing.Size(169, 147);
            this.listBoxListaCartas.TabIndex = 16;
            // 
            // listBoxBaralhos
            // 
            this.listBoxBaralhos.FormattingEnabled = true;
            this.listBoxBaralhos.Location = new System.Drawing.Point(22, 66);
            this.listBoxBaralhos.Name = "listBoxBaralhos";
            this.listBoxBaralhos.Size = new System.Drawing.Size(120, 225);
            this.listBoxBaralhos.TabIndex = 15;
            // 
            // labelListaCartas
            // 
            this.labelListaCartas.AutoSize = true;
            this.labelListaCartas.Location = new System.Drawing.Point(190, 50);
            this.labelListaCartas.Name = "labelListaCartas";
            this.labelListaCartas.Size = new System.Drawing.Size(58, 13);
            this.labelListaCartas.TabIndex = 14;
            this.labelListaCartas.Text = "Info Cartas";
            // 
            // labelCarta
            // 
            this.labelCarta.AutoSize = true;
            this.labelCarta.Location = new System.Drawing.Point(19, 50);
            this.labelCarta.Name = "labelCarta";
            this.labelCarta.Size = new System.Drawing.Size(37, 13);
            this.labelCarta.TabIndex = 13;
            this.labelCarta.Text = "Cartas";
            // 
            // labelCartas
            // 
            this.labelCartas.AutoSize = true;
            this.labelCartas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCartas.Location = new System.Drawing.Point(142, 9);
            this.labelCartas.Name = "labelCartas";
            this.labelCartas.Size = new System.Drawing.Size(70, 25);
            this.labelCartas.TabIndex = 12;
            this.labelCartas.Text = "Cartas";
            // 
            // Cartas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 389);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.buttonEditarCarta);
            this.Controls.Add(this.buttonApagarCarta);
            this.Controls.Add(this.buttonAdicionarCarta);
            this.Controls.Add(this.listBoxListaCartas);
            this.Controls.Add(this.listBoxBaralhos);
            this.Controls.Add(this.labelListaCartas);
            this.Controls.Add(this.labelCarta);
            this.Controls.Add(this.labelCartas);
            this.Name = "Cartas";
            this.Text = "Cartas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.Button buttonEditarCarta;
        private System.Windows.Forms.Button buttonApagarCarta;
        private System.Windows.Forms.Button buttonAdicionarCarta;
        private System.Windows.Forms.ListBox listBoxListaCartas;
        private System.Windows.Forms.ListBox listBoxBaralhos;
        private System.Windows.Forms.Label labelListaCartas;
        private System.Windows.Forms.Label labelCarta;
        private System.Windows.Forms.Label labelCartas;
    }
}