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
            this.listBoxInfo = new System.Windows.Forms.ListBox();
            this.listBoxCartas = new System.Windows.Forms.ListBox();
            this.labelListaCartas = new System.Windows.Forms.Label();
            this.labelCarta = new System.Windows.Forms.Label();
            this.labelCartas = new System.Windows.Forms.Label();
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
            // 
            // buttonApagarCarta
            // 
            this.buttonApagarCarta.Location = new System.Drawing.Point(11, 354);
            this.buttonApagarCarta.Name = "buttonApagarCarta";
            this.buttonApagarCarta.Size = new System.Drawing.Size(121, 23);
            this.buttonApagarCarta.TabIndex = 18;
            this.buttonApagarCarta.Text = "Apagar Carta";
            this.buttonApagarCarta.UseVisualStyleBackColor = true;
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
            // listBoxInfo
            // 
            this.listBoxInfo.FormattingEnabled = true;
            this.listBoxInfo.Location = new System.Drawing.Point(170, 66);
            this.listBoxInfo.Name = "listBoxInfo";
            this.listBoxInfo.Size = new System.Drawing.Size(169, 147);
            this.listBoxInfo.TabIndex = 16;
            // 
            // listBoxCartas
            // 
            this.listBoxCartas.FormattingEnabled = true;
            this.listBoxCartas.Location = new System.Drawing.Point(12, 66);
            this.listBoxCartas.Name = "listBoxCartas";
            this.listBoxCartas.Size = new System.Drawing.Size(120, 225);
            this.listBoxCartas.TabIndex = 15;
            // 
            // labelListaCartas
            // 
            this.labelListaCartas.AutoSize = true;
            this.labelListaCartas.Location = new System.Drawing.Point(167, 50);
            this.labelListaCartas.Name = "labelListaCartas";
            this.labelListaCartas.Size = new System.Drawing.Size(60, 13);
            this.labelListaCartas.TabIndex = 14;
            this.labelListaCartas.Text = "Informação";
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
            this.labelCartas.Location = new System.Drawing.Point(140, 9);
            this.labelCartas.Name = "labelCartas";
            this.labelCartas.Size = new System.Drawing.Size(70, 25);
            this.labelCartas.TabIndex = 12;
            this.labelCartas.Text = "Cartas";
            // 
            // CartasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 389);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.buttonEditarCarta);
            this.Controls.Add(this.buttonApagarCarta);
            this.Controls.Add(this.buttonAdicionarCarta);
            this.Controls.Add(this.listBoxInfo);
            this.Controls.Add(this.listBoxCartas);
            this.Controls.Add(this.labelListaCartas);
            this.Controls.Add(this.labelCarta);
            this.Controls.Add(this.labelCartas);
            this.Name = "CartasForm";
            this.Text = "Cartas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.Button buttonEditarCarta;
        private System.Windows.Forms.Button buttonApagarCarta;
        private System.Windows.Forms.Button buttonAdicionarCarta;
        private System.Windows.Forms.ListBox listBoxInfo;
        private System.Windows.Forms.ListBox listBoxCartas;
        private System.Windows.Forms.Label labelListaCartas;
        private System.Windows.Forms.Label labelCarta;
        private System.Windows.Forms.Label labelCartas;
    }
}