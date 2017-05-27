namespace Projeto
{
    partial class FormEditarCartas
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
            this.buttonVoltarCarta = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.comboBoxTipoCarta = new System.Windows.Forms.ComboBox();
            this.labelTipoCarta = new System.Windows.Forms.Label();
            this.comboBoxFacao = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxRegraCarta = new System.Windows.Forms.TextBox();
            this.labelRegraCarta = new System.Windows.Forms.Label();
            this.labelCustoCarta = new System.Windows.Forms.Label();
            this.labelLealdadeCarta = new System.Windows.Forms.Label();
            this.labelDefesaCarta = new System.Windows.Forms.Label();
            this.labelAtaqueCarta = new System.Windows.Forms.Label();
            this.numericUpDownLealdade = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCusto = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDefesa = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownAtaque = new System.Windows.Forms.NumericUpDown();
            this.textBoxNomeCarta = new System.Windows.Forms.TextBox();
            this.labelNomeCarta = new System.Windows.Forms.Label();
            this.labelCartas = new System.Windows.Forms.Label();
            this.listBoxCartas = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLealdade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCusto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDefesa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAtaque)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonVoltarCarta
            // 
            this.buttonVoltarCarta.Location = new System.Drawing.Point(450, 304);
            this.buttonVoltarCarta.Name = "buttonVoltarCarta";
            this.buttonVoltarCarta.Size = new System.Drawing.Size(75, 23);
            this.buttonVoltarCarta.TabIndex = 39;
            this.buttonVoltarCarta.Text = "Voltar";
            this.buttonVoltarCarta.UseVisualStyleBackColor = true;
            this.buttonVoltarCarta.Click += new System.EventHandler(this.buttonVoltarCarta_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(180, 304);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 38;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // comboBoxTipoCarta
            // 
            this.comboBoxTipoCarta.FormattingEnabled = true;
            this.comboBoxTipoCarta.Items.AddRange(new object[] {
            "Creature",
            "Event",
            "Equipment",
            "Magic",
            "Enchantment",
            "City"});
            this.comboBoxTipoCarta.Location = new System.Drawing.Point(315, 268);
            this.comboBoxTipoCarta.Name = "comboBoxTipoCarta";
            this.comboBoxTipoCarta.Size = new System.Drawing.Size(210, 21);
            this.comboBoxTipoCarta.TabIndex = 37;
            // 
            // labelTipoCarta
            // 
            this.labelTipoCarta.AutoSize = true;
            this.labelTipoCarta.Location = new System.Drawing.Point(312, 252);
            this.labelTipoCarta.Name = "labelTipoCarta";
            this.labelTipoCarta.Size = new System.Drawing.Size(28, 13);
            this.labelTipoCarta.TabIndex = 36;
            this.labelTipoCarta.Text = "Tipo";
            // 
            // comboBoxFacao
            // 
            this.comboBoxFacao.FormattingEnabled = true;
            this.comboBoxFacao.Items.AddRange(new object[] {
            "Gaian Love for Life",
            "Uneasy Alliance"});
            this.comboBoxFacao.Location = new System.Drawing.Point(315, 215);
            this.comboBoxFacao.Name = "comboBoxFacao";
            this.comboBoxFacao.Size = new System.Drawing.Size(210, 21);
            this.comboBoxFacao.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(312, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Fação";
            // 
            // textBoxRegraCarta
            // 
            this.textBoxRegraCarta.Location = new System.Drawing.Point(315, 108);
            this.textBoxRegraCarta.Multiline = true;
            this.textBoxRegraCarta.Name = "textBoxRegraCarta";
            this.textBoxRegraCarta.Size = new System.Drawing.Size(148, 75);
            this.textBoxRegraCarta.TabIndex = 33;
            // 
            // labelRegraCarta
            // 
            this.labelRegraCarta.AutoSize = true;
            this.labelRegraCarta.Location = new System.Drawing.Point(312, 91);
            this.labelRegraCarta.Name = "labelRegraCarta";
            this.labelRegraCarta.Size = new System.Drawing.Size(36, 13);
            this.labelRegraCarta.TabIndex = 32;
            this.labelRegraCarta.Text = "Regra";
            // 
            // labelCustoCarta
            // 
            this.labelCustoCarta.AutoSize = true;
            this.labelCustoCarta.Location = new System.Drawing.Point(177, 199);
            this.labelCustoCarta.Name = "labelCustoCarta";
            this.labelCustoCarta.Size = new System.Drawing.Size(34, 13);
            this.labelCustoCarta.TabIndex = 31;
            this.labelCustoCarta.Text = "Custo";
            // 
            // labelLealdadeCarta
            // 
            this.labelLealdadeCarta.AutoSize = true;
            this.labelLealdadeCarta.Location = new System.Drawing.Point(177, 252);
            this.labelLealdadeCarta.Name = "labelLealdadeCarta";
            this.labelLealdadeCarta.Size = new System.Drawing.Size(51, 13);
            this.labelLealdadeCarta.TabIndex = 30;
            this.labelLealdadeCarta.Text = "Lealdade";
            // 
            // labelDefesaCarta
            // 
            this.labelDefesaCarta.AutoSize = true;
            this.labelDefesaCarta.Location = new System.Drawing.Point(177, 147);
            this.labelDefesaCarta.Name = "labelDefesaCarta";
            this.labelDefesaCarta.Size = new System.Drawing.Size(41, 13);
            this.labelDefesaCarta.TabIndex = 29;
            this.labelDefesaCarta.Text = "Defesa";
            // 
            // labelAtaqueCarta
            // 
            this.labelAtaqueCarta.AutoSize = true;
            this.labelAtaqueCarta.Location = new System.Drawing.Point(177, 91);
            this.labelAtaqueCarta.Name = "labelAtaqueCarta";
            this.labelAtaqueCarta.Size = new System.Drawing.Size(41, 13);
            this.labelAtaqueCarta.TabIndex = 28;
            this.labelAtaqueCarta.Text = "Ataque";
            // 
            // numericUpDownLealdade
            // 
            this.numericUpDownLealdade.Location = new System.Drawing.Point(180, 268);
            this.numericUpDownLealdade.Name = "numericUpDownLealdade";
            this.numericUpDownLealdade.Size = new System.Drawing.Size(75, 20);
            this.numericUpDownLealdade.TabIndex = 27;
            // 
            // numericUpDownCusto
            // 
            this.numericUpDownCusto.Location = new System.Drawing.Point(180, 215);
            this.numericUpDownCusto.Name = "numericUpDownCusto";
            this.numericUpDownCusto.Size = new System.Drawing.Size(75, 20);
            this.numericUpDownCusto.TabIndex = 26;
            // 
            // numericUpDownDefesa
            // 
            this.numericUpDownDefesa.Location = new System.Drawing.Point(180, 163);
            this.numericUpDownDefesa.Name = "numericUpDownDefesa";
            this.numericUpDownDefesa.Size = new System.Drawing.Size(75, 20);
            this.numericUpDownDefesa.TabIndex = 25;
            // 
            // numericUpDownAtaque
            // 
            this.numericUpDownAtaque.Location = new System.Drawing.Point(180, 107);
            this.numericUpDownAtaque.Name = "numericUpDownAtaque";
            this.numericUpDownAtaque.Size = new System.Drawing.Size(75, 20);
            this.numericUpDownAtaque.TabIndex = 24;
            // 
            // textBoxNomeCarta
            // 
            this.textBoxNomeCarta.Location = new System.Drawing.Point(178, 54);
            this.textBoxNomeCarta.Name = "textBoxNomeCarta";
            this.textBoxNomeCarta.ReadOnly = true;
            this.textBoxNomeCarta.Size = new System.Drawing.Size(347, 20);
            this.textBoxNomeCarta.TabIndex = 23;
            // 
            // labelNomeCarta
            // 
            this.labelNomeCarta.AutoSize = true;
            this.labelNomeCarta.Location = new System.Drawing.Point(177, 38);
            this.labelNomeCarta.Name = "labelNomeCarta";
            this.labelNomeCarta.Size = new System.Drawing.Size(78, 13);
            this.labelNomeCarta.TabIndex = 22;
            this.labelNomeCarta.Text = "Nome da Carta";
            // 
            // labelCartas
            // 
            this.labelCartas.AutoSize = true;
            this.labelCartas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCartas.Location = new System.Drawing.Point(287, 10);
            this.labelCartas.Name = "labelCartas";
            this.labelCartas.Size = new System.Drawing.Size(115, 25);
            this.labelCartas.TabIndex = 21;
            this.labelCartas.Text = "Editar Carta";
            // 
            // listBoxCartas
            // 
            this.listBoxCartas.FormattingEnabled = true;
            this.listBoxCartas.Location = new System.Drawing.Point(12, 54);
            this.listBoxCartas.Name = "listBoxCartas";
            this.listBoxCartas.Size = new System.Drawing.Size(147, 277);
            this.listBoxCartas.TabIndex = 40;
            this.listBoxCartas.SelectedIndexChanged += new System.EventHandler(this.listBoxCartas_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Cartas Disponiveis";
            // 
            // FormEditarCartas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 337);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxCartas);
            this.Controls.Add(this.buttonVoltarCarta);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.comboBoxTipoCarta);
            this.Controls.Add(this.labelTipoCarta);
            this.Controls.Add(this.comboBoxFacao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxRegraCarta);
            this.Controls.Add(this.labelRegraCarta);
            this.Controls.Add(this.labelCustoCarta);
            this.Controls.Add(this.labelLealdadeCarta);
            this.Controls.Add(this.labelDefesaCarta);
            this.Controls.Add(this.labelAtaqueCarta);
            this.Controls.Add(this.numericUpDownLealdade);
            this.Controls.Add(this.numericUpDownCusto);
            this.Controls.Add(this.numericUpDownDefesa);
            this.Controls.Add(this.numericUpDownAtaque);
            this.Controls.Add(this.textBoxNomeCarta);
            this.Controls.Add(this.labelNomeCarta);
            this.Controls.Add(this.labelCartas);
            this.Name = "FormEditarCartas";
            this.Text = "FormEditarCartas";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLealdade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCusto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDefesa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAtaque)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonVoltarCarta;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.ComboBox comboBoxTipoCarta;
        private System.Windows.Forms.Label labelTipoCarta;
        private System.Windows.Forms.ComboBox comboBoxFacao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxRegraCarta;
        private System.Windows.Forms.Label labelRegraCarta;
        private System.Windows.Forms.Label labelCustoCarta;
        private System.Windows.Forms.Label labelLealdadeCarta;
        private System.Windows.Forms.Label labelDefesaCarta;
        private System.Windows.Forms.Label labelAtaqueCarta;
        private System.Windows.Forms.NumericUpDown numericUpDownLealdade;
        private System.Windows.Forms.NumericUpDown numericUpDownCusto;
        private System.Windows.Forms.NumericUpDown numericUpDownDefesa;
        private System.Windows.Forms.NumericUpDown numericUpDownAtaque;
        private System.Windows.Forms.TextBox textBoxNomeCarta;
        private System.Windows.Forms.Label labelNomeCarta;
        private System.Windows.Forms.Label labelCartas;
        private System.Windows.Forms.ListBox listBoxCartas;
        private System.Windows.Forms.Label label2;
    }
}