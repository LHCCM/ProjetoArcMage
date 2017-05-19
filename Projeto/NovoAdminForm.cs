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
    public partial class NovoAdminForm : Form
    {
        public Administrator NovoAdmin { get; private set; }

        public NovoAdminForm()
        {
            InitializeComponent();
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            if (textBoxNome.Text.Length == 0 || textBoxEmail.Text.Length == 0 || textBoxPassword.Text.Length == 0)
            {
                MessageBox.Show("Preencha as caixas de texto, Por Favor.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string nome = textBoxNome.Text.Trim();
                string email = textBoxEmail.Text.Trim();
                string password = textBoxPassword.Text.Trim();

                NovoAdmin = new Administrator()
                {
                    Username = nome,
                    Email = email,
                    Password = password,
                };

                DialogResult = DialogResult.OK;
                Close();
            }

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
