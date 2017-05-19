namespace Projeto
{
    partial class UtilizadoresForm
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
            this.buttonEliminarUser = new System.Windows.Forms.Button();
            this.listBoxUsers = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelNick = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.buttonNovoUser = new System.Windows.Forms.Button();
            this.buttonEditUser = new System.Windows.Forms.Button();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.buttonNovoAdmin = new System.Windows.Forms.Button();
            this.labelEmail = new System.Windows.Forms.Label();
            this.label555 = new System.Windows.Forms.Label();
            this.radioButtonArbitro = new System.Windows.Forms.RadioButton();
            this.radioButtonAdmin = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonTodos = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonEliminarUser
            // 
            this.buttonEliminarUser.Location = new System.Drawing.Point(24, 486);
            this.buttonEliminarUser.Name = "buttonEliminarUser";
            this.buttonEliminarUser.Size = new System.Drawing.Size(155, 23);
            this.buttonEliminarUser.TabIndex = 0;
            this.buttonEliminarUser.Text = "Eliminar Utilizador";
            this.buttonEliminarUser.UseVisualStyleBackColor = true;
            this.buttonEliminarUser.Click += new System.EventHandler(this.buttonEliminarUser_Click);
            // 
            // listBoxUsers
            // 
            this.listBoxUsers.FormattingEnabled = true;
            this.listBoxUsers.Location = new System.Drawing.Point(24, 62);
            this.listBoxUsers.Name = "listBoxUsers";
            this.listBoxUsers.Size = new System.Drawing.Size(155, 290);
            this.listBoxUsers.TabIndex = 1;
            this.listBoxUsers.SelectedIndexChanged += new System.EventHandler(this.listBoxUsers_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 355);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pesquisa de Utilizador";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(24, 371);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Utilizadores";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(131, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Utilizadores";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(209, 165);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 132);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nome:";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Nickname:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(17, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 16);
            this.label10.TabIndex = 15;
            this.label10.Text = "ID:";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(98, 76);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(75, 16);
            this.labelNome.TabIndex = 16;
            this.labelNome.Text = "Sampletext";
            this.labelNome.Visible = false;
            // 
            // labelNick
            // 
            this.labelNick.AutoSize = true;
            this.labelNick.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNick.Location = new System.Drawing.Point(98, 46);
            this.labelNick.Name = "labelNick";
            this.labelNick.Size = new System.Drawing.Size(0, 16);
            this.labelNick.TabIndex = 17;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(98, 16);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(0, 16);
            this.labelID.TabIndex = 18;
            // 
            // buttonNovoUser
            // 
            this.buttonNovoUser.Location = new System.Drawing.Point(231, 426);
            this.buttonNovoUser.Name = "buttonNovoUser";
            this.buttonNovoUser.Size = new System.Drawing.Size(155, 23);
            this.buttonNovoUser.TabIndex = 20;
            this.buttonNovoUser.Text = "Novo Árbitro";
            this.buttonNovoUser.UseVisualStyleBackColor = true;
            this.buttonNovoUser.Click += new System.EventHandler(this.buttonNovoUser_Click);
            // 
            // buttonEditUser
            // 
            this.buttonEditUser.Location = new System.Drawing.Point(231, 455);
            this.buttonEditUser.Name = "buttonEditUser";
            this.buttonEditUser.Size = new System.Drawing.Size(155, 23);
            this.buttonEditUser.TabIndex = 21;
            this.buttonEditUser.Text = "Editar Utilizador";
            this.buttonEditUser.UseVisualStyleBackColor = true;
            this.buttonEditUser.Click += new System.EventHandler(this.buttonEditUser_Click);
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Location = new System.Drawing.Point(231, 484);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(155, 23);
            this.buttonVoltar.TabIndex = 22;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.UseVisualStyleBackColor = true;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // buttonNovoAdmin
            // 
            this.buttonNovoAdmin.Location = new System.Drawing.Point(231, 397);
            this.buttonNovoAdmin.Name = "buttonNovoAdmin";
            this.buttonNovoAdmin.Size = new System.Drawing.Size(155, 23);
            this.buttonNovoAdmin.TabIndex = 24;
            this.buttonNovoAdmin.Text = "Novo Administrador";
            this.buttonNovoAdmin.UseVisualStyleBackColor = true;
            this.buttonNovoAdmin.Click += new System.EventHandler(this.buttonNovoAdmin_Click);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(98, 76);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(75, 16);
            this.labelEmail.TabIndex = 26;
            this.labelEmail.Text = "Sampletext";
            this.labelEmail.Visible = false;
            // 
            // label555
            // 
            this.label555.AutoSize = true;
            this.label555.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label555.Location = new System.Drawing.Point(17, 76);
            this.label555.Name = "label555";
            this.label555.Size = new System.Drawing.Size(49, 16);
            this.label555.TabIndex = 25;
            this.label555.Text = "E-mail:";
            this.label555.Visible = false;
            // 
            // radioButtonArbitro
            // 
            this.radioButtonArbitro.AutoSize = true;
            this.radioButtonArbitro.Location = new System.Drawing.Point(29, 38);
            this.radioButtonArbitro.Name = "radioButtonArbitro";
            this.radioButtonArbitro.Size = new System.Drawing.Size(60, 17);
            this.radioButtonArbitro.TabIndex = 6;
            this.radioButtonArbitro.TabStop = true;
            this.radioButtonArbitro.Text = "Árbitros";
            this.radioButtonArbitro.UseVisualStyleBackColor = true;
            this.radioButtonArbitro.CheckedChanged += new System.EventHandler(this.radioButtonArbitro_CheckedChanged);
            // 
            // radioButtonAdmin
            // 
            this.radioButtonAdmin.AutoSize = true;
            this.radioButtonAdmin.Location = new System.Drawing.Point(29, 15);
            this.radioButtonAdmin.Name = "radioButtonAdmin";
            this.radioButtonAdmin.Size = new System.Drawing.Size(99, 17);
            this.radioButtonAdmin.TabIndex = 5;
            this.radioButtonAdmin.TabStop = true;
            this.radioButtonAdmin.Text = "Administradores";
            this.radioButtonAdmin.UseVisualStyleBackColor = true;
            this.radioButtonAdmin.CheckedChanged += new System.EventHandler(this.radioButtonAdmin_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonTodos);
            this.groupBox1.Controls.Add(this.radioButtonAdmin);
            this.groupBox1.Controls.Add(this.radioButtonArbitro);
            this.groupBox1.Location = new System.Drawing.Point(26, 397);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 81);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.labelEmail);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label555);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.labelNome);
            this.groupBox2.Controls.Add(this.labelNick);
            this.groupBox2.Controls.Add(this.labelID);
            this.groupBox2.Location = new System.Drawing.Point(198, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(236, 100);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informação";
            // 
            // radioButtonTodos
            // 
            this.radioButtonTodos.AutoSize = true;
            this.radioButtonTodos.Location = new System.Drawing.Point(29, 58);
            this.radioButtonTodos.Name = "radioButtonTodos";
            this.radioButtonTodos.Size = new System.Drawing.Size(55, 17);
            this.radioButtonTodos.TabIndex = 7;
            this.radioButtonTodos.TabStop = true;
            this.radioButtonTodos.Text = "Todos";
            this.radioButtonTodos.UseVisualStyleBackColor = true;
            this.radioButtonTodos.CheckedChanged += new System.EventHandler(this.radioButtonTodos_CheckedChanged);
            // 
            // UtilizadoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 521);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonNovoAdmin);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.buttonEditUser);
            this.Controls.Add(this.buttonNovoUser);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxUsers);
            this.Controls.Add(this.buttonEliminarUser);
            this.Name = "UtilizadoresForm";
            this.Text = "Utilizadores";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEliminarUser;
        private System.Windows.Forms.ListBox listBoxUsers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelNick;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Button buttonNovoUser;
        private System.Windows.Forms.Button buttonEditUser;
        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.Button buttonNovoAdmin;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label label555;
        private System.Windows.Forms.RadioButton radioButtonArbitro;
        private System.Windows.Forms.RadioButton radioButtonAdmin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonTodos;
    }
}