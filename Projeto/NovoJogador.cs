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
    public partial class NovoJogadorForm : Form
    {
        public Player NovoJogador { get; private set; }

        public NovoJogadorForm()
        {
            InitializeComponent();
        }

        private void buttonCancelarNovoJogador_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonConfirmNovoJogador_Click(object sender, EventArgs e)
        {
            if (textBoxNome.Text.Length == 0 || textBoxNick.Text.Length == 0 || textBoxEmail.Text.Length == 0)
            {
                MessageBox.Show("Preencha as caixas de texto, Por Favor.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                string nome = textBoxNome.Text.Trim();
                string nick = textBoxNick.Text.Trim();
                string email = textBoxEmail.Text.Trim();

                NovoJogador = new Player()
                {
                    Name = nome,
                    Nickname = nick,
                    Email = email,

                    Age = (int)numericUpDownIdade.Value,
                    Avatar = "nenhum"

                };
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
