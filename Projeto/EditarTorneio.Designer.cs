namespace Projeto
{
    partial class EditarTorneioForm
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
            this.LabelID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxTorneio = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelID
            // 
            this.LabelID.AutoSize = true;
            this.LabelID.Location = new System.Drawing.Point(210, 36);
            this.LabelID.Name = "LabelID";
            this.LabelID.Size = new System.Drawing.Size(0, 13);
            this.LabelID.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(309, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 24);
            this.label4.TabIndex = 21;
            this.label4.Text = "Editar Torneio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "ID:";
            // 
            // listBoxTorneio
            // 
            this.listBoxTorneio.FormattingEnabled = true;
            this.listBoxTorneio.Location = new System.Drawing.Point(12, 51);
            this.listBoxTorneio.Name = "listBoxTorneio";
            this.listBoxTorneio.Size = new System.Drawing.Size(156, 251);
            this.listBoxTorneio.TabIndex = 23;
            this.listBoxTorneio.SelectedIndexChanged += new System.EventHandler(this.listBoxTorneio_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Descrição";
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Location = new System.Drawing.Point(450, 278);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(129, 23);
            this.buttonVoltar.TabIndex = 29;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.UseVisualStyleBackColor = true;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(192, 278);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(129, 23);
            this.buttonGuardar.TabIndex = 28;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.Location = new System.Drawing.Point(192, 161);
            this.textBoxDesc.Multiline = true;
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(387, 110);
            this.textBoxDesc.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Nome";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(192, 117);
            this.dateTimePicker.MinDate = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(99, 20);
            this.dateTimePicker.TabIndex = 25;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(192, 85);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(387, 20);
            this.textBoxNome.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Torneios disponiveis";
            // 
            // EditarTorneioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 315);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.textBoxDesc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.listBoxTorneio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LabelID);
            this.Name = "EditarTorneioForm";
            this.Text = "EditarTorneio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LabelID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxTorneio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.TextBox textBoxDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label label5;
    }
}