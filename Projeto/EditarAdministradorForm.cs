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
    public partial class EditarAdministradorForm : Form
    {
        DBDiagramaContainer container = new DBDiagramaContainer();

        DialogResult result;

        public EditarAdministradorForm()
        {
            InitializeComponent();

            refreshAdmin();
        }

        private void listBoxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Administrator adminSelecionado = (Administrator)listBoxAdmin.SelectedItem;
            if (adminSelecionado != null)
            {
                textBoxNome.Text = adminSelecionado.Username;
                textBoxEmail.Text = adminSelecionado.Email;
                textBoxPassword.Text = adminSelecionado.Password;
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void refreshAdmin()
        {
            listBoxAdmin.Items.Clear();
            listBoxAdmin.Items.AddRange(container.User.OfType<Administrator>().ToArray());
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            Administrator adminSelecionado = (Administrator)listBoxAdmin.SelectedItem;

            if (adminSelecionado != null)
            {
                result = MessageBox.Show("Tem a certeza que deseja guardar as alterações ? ", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    string email = textBoxEmail.Text.Trim();

                    adminSelecionado.Email = email;

                    container.SaveChanges();
                }
            }
            else
            {
                MessageBox.Show("Nenhum Administrador selecionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
