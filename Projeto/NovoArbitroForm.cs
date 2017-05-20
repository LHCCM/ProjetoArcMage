using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto
{
    public partial class NovoArbitroForm : Form
    {
        public Referee NovoArbitro { get; private set; }

        public NovoArbitroForm()
        {
            InitializeComponent();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            if (textBoxNome.Text.Length == 0 || textBoxNickname.Text.Length == 0 || textBoxPassword.Text.Length == 0)
            {
                MessageBox.Show("Preencha as caixas de texto, Por Favor.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string nome = textBoxNome.Text.Trim();
                string nickname = textBoxNickname.Text.Trim();
                string password = textBoxPassword.Text.Trim();
                string avatar = textBoxAvatar.Text.Trim();

                NovoArbitro = new Referee()
                {
                    Name = nome,
                    Username = nickname,
                    Password = password,
                    Avatar = avatar,
                };

                DialogResult = DialogResult.OK;
                Close();
            }

        }

        private void buttonEscolherAvatar_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.textBoxAvatar.Text = openFileDialog1.FileName;
            }
        }
    }
}
