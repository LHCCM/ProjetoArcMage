namespace Projeto
{
    partial class FormCartas
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
            this.listBoxCartas = new System.Windows.Forms.ListBox();
            this.labelCartas = new System.Windows.Forms.Label();
            this.labelListaCartas = new System.Windows.Forms.Label();
            this.labelInfoCarta = new System.Windows.Forms.Label();
            this.listBoxInfoCarta = new System.Windows.Forms.ListBox();
            this.buttonAdicionarCarta = new System.Windows.Forms.Button();
            this.buttonEditarCarta = new System.Windows.Forms.Button();
            this.buttonApagarCarta = new System.Windows.Forms.Button();
            this.buttonVoltarCartas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxCartas
            // 
            this.listBoxCartas.FormattingEnabled = true;
            this.listBoxCartas.Location = new System.Drawing.Point(16, 64);
            this.listBoxCartas.Name = "listBoxCartas";
            this.listBoxCartas.Size = new System.Drawing.Size(122, 225);
            this.listBoxCartas.TabIndex = 0;
            // 
            // labelCartas
            // 
            this.labelCartas.AutoSize = true;
            this.labelCartas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCartas.Location = new System.Drawing.Point(138, 9);
            this.labelCartas.Name = "labelCartas";
            this.labelCartas.Size = new System.Drawing.Size(70, 25);
            this.labelCartas.TabIndex = 1;
            this.labelCartas.Text = "Cartas";
            // 
            // labelListaCartas
            // 
            this.labelListaCartas.AutoSize = true;
            this.labelListaCartas.Location = new System.Drawing.Point(13, 48);
            this.labelListaCartas.Name = "labelListaCartas";
            this.labelListaCartas.Size = new System.Drawing.Size(77, 13);
            this.labelListaCartas.TabIndex = 2;
            this.labelListaCartas.Text = "Lista de Cartas";
            // 
            // labelInfoCarta
            // 
            this.labelInfoCarta.AutoSize = true;
            this.labelInfoCarta.Location = new System.Drawing.Point(195, 48);
            this.labelInfoCarta.Name = "labelInfoCarta";
            this.labelInfoCarta.Size = new System.Drawing.Size(68, 13);
            this.labelInfoCarta.TabIndex = 3;
            this.labelInfoCarta.Text = "Info da Carta";
            // 
            // listBoxInfoCarta
            // 
            this.listBoxInfoCarta.FormattingEnabled = true;
            this.listBoxInfoCarta.Location = new System.Drawing.Point(198, 64);
            this.listBoxInfoCarta.Name = "listBoxInfoCarta";
            this.listBoxInfoCarta.Size = new System.Drawing.Size(172, 225);
            this.listBoxInfoCarta.TabIndex = 4;
            // 
            // buttonAdicionarCarta
            // 
            this.buttonAdicionarCarta.Location = new System.Drawing.Point(16, 295);
            this.buttonAdicionarCarta.Name = "buttonAdicionarCarta";
            this.buttonAdicionarCarta.Size = new System.Drawing.Size(122, 23);
            this.buttonAdicionarCarta.TabIndex = 5;
            this.buttonAdicionarCarta.Text = "Adicionar Carta";
            this.buttonAdicionarCarta.UseVisualStyleBackColor = true;
            // 
            // buttonEditarCarta
            // 
            this.buttonEditarCarta.Location = new System.Drawing.Point(16, 324);
            this.buttonEditarCarta.Name = "buttonEditarCarta";
            this.buttonEditarCarta.Size = new System.Drawing.Size(122, 23);
            this.buttonEditarCarta.TabIndex = 6;
            this.buttonEditarCarta.Text = "Editar Carta";
            this.buttonEditarCarta.UseVisualStyleBackColor = true;
            // 
            // buttonApagarCarta
            // 
            this.buttonApagarCarta.Location = new System.Drawing.Point(16, 353);
            this.buttonApagarCarta.Name = "buttonApagarCarta";
            this.buttonApagarCarta.Size = new System.Drawing.Size(122, 23);
            this.buttonApagarCarta.TabIndex = 7;
            this.buttonApagarCarta.Text = "Apagar Carta";
            this.buttonApagarCarta.UseVisualStyleBackColor = true;
            // 
            // buttonVoltarCartas
            // 
            this.buttonVoltarCartas.Location = new System.Drawing.Point(295, 353);
            this.buttonVoltarCartas.Name = "buttonVoltarCartas";
            this.buttonVoltarCartas.Size = new System.Drawing.Size(75, 23);
            this.buttonVoltarCartas.TabIndex = 8;
            this.buttonVoltarCartas.Text = "Voltar";
            this.buttonVoltarCartas.UseVisualStyleBackColor = true;
            // 
            // FormCartas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 404);
            this.Controls.Add(this.buttonVoltarCartas);
            this.Controls.Add(this.buttonApagarCarta);
            this.Controls.Add(this.buttonEditarCarta);
            this.Controls.Add(this.buttonAdicionarCarta);
            this.Controls.Add(this.listBoxInfoCarta);
            this.Controls.Add(this.labelInfoCarta);
            this.Controls.Add(this.labelListaCartas);
            this.Controls.Add(this.labelCartas);
            this.Controls.Add(this.listBoxCartas);
            this.Name = "FormCartas";
            this.Text = "FormCartas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCartas;
        private System.Windows.Forms.Label labelCartas;
        private System.Windows.Forms.Label labelListaCartas;
        private System.Windows.Forms.Label labelInfoCarta;
        private System.Windows.Forms.ListBox listBoxInfoCarta;
        private System.Windows.Forms.Button buttonAdicionarCarta;
        private System.Windows.Forms.Button buttonEditarCarta;
        private System.Windows.Forms.Button buttonApagarCarta;
        private System.Windows.Forms.Button buttonVoltarCartas;
    }
}

