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
    public partial class UtilizadoresForm : Form
    {
        DBDiagramaContainer container = new DBDiagramaContainer();

        public UtilizadoresForm()
        {
            InitializeComponent();

            refreshUtilizadores();
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            MenuAdminForm menuadmin = new MenuAdminForm();
            menuadmin.Show();
            this.Close();
        }

        private void buttonNovoUser_Click(object sender, EventArgs e)
        {
            NovoArbitroForm userArbitro = new NovoArbitroForm();
            DialogResult result = userArbitro.ShowDialog();
            if (result == DialogResult.OK)
            {
                AdicionarArbitro(userArbitro.NovoArbitro);
            }

            refreshUtilizadores();
        }

        private void buttonEditUser_Click(object sender, EventArgs e)
        {
            EditarUtilizadorForm editF = new EditarUtilizadorForm();
            editF.Show();
        }

        private void buttonEliminarUser_Click(object sender, EventArgs e)
        {
            //função eliminar dados selecionados na listboxUsers
            if (listBoxUsers.SelectedIndex >= 0)
            {
                container.User.Remove((User)listBoxUsers.SelectedItem);
                container.SaveChanges();
            }

            refreshUtilizadores();
        }

        private void AdicionarArbitro(Referee arbitro)
        {
            container.User.Add(arbitro);
            container.SaveChanges();
        }

        private void refreshUtilizadores()
        {
            listBoxUsers.Items.Clear();
            listBoxUsers.Items.AddRange(container.User.OfType<Referee>().ToArray());
            listBoxUsers.Items.AddRange(container.User.OfType<Administrator>().ToArray());
        }

        private void refreshAdmin()
        {
            listBoxUsers.Items.Clear();
            listBoxUsers.Items.AddRange(container.User.OfType<Administrator>().ToArray());
        }

        private void refreshArbitro()
        {
            listBoxUsers.Items.Clear();
            listBoxUsers.Items.AddRange(container.User.OfType<Referee>().ToArray());
        }

        private void listBoxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (listBoxUsers.SelectedItem.GetType() == typeof(Administrator))
            {
                Administrator adminSelecionado = (Administrator)listBoxUsers.SelectedItem;
                if (adminSelecionado != null)
                {
                    pictureBox1.Hide();
                    labelID.Text = Convert.ToString(adminSelecionado.Id);
                    labelNick.Text = adminSelecionado.Username;
                    label555.Show();
                    labelEmail.Show();
                    labelEmail.Text = adminSelecionado.Email;

                }
            }
            else
            {
                Referee utilizadorSelecionado = (Referee)listBoxUsers.SelectedItem;

                if (utilizadorSelecionado != null)
                {
                    if (utilizadorSelecionado.Avatar != "")
                    {

                        Image imagem = new Bitmap(utilizadorSelecionado.Avatar);

                        pictureBox1.Image = new Bitmap(imagem, new Size(153, 132));
                    }
                    else
                    {
                        pictureBox1.Image = Properties.Resources.noavatar;
                    }
                    pictureBox1.Show();
                    labelID.Text = Convert.ToString(utilizadorSelecionado.Id);
                    label6.Show();
                    labelNome.Show();
                    labelNome.Text = utilizadorSelecionado.Name;
                    labelNick.Text = utilizadorSelecionado.Username;
                    labelEmail.Hide();
                    label555.Hide();
                }
            }    
        }

        private void buttonNovoAdmin_Click(object sender, EventArgs e)
        {
            NovoAdminForm novoadmin = new NovoAdminForm();
            DialogResult result = novoadmin.ShowDialog();

            if (result == DialogResult.OK)
            {
                AdicionarAdmin(novoadmin.NovoAdmin);
            }

            refreshUtilizadores();
        }

        private void AdicionarAdmin(Administrator admin)
        {
            container.User.Add(admin);
            container.SaveChanges();
        }

        private void radioButtonAdmin_CheckedChanged(object sender, EventArgs e)
        {
            refreshAdmin();
        }

        private void radioButtonArbitro_CheckedChanged(object sender, EventArgs e)
        {
            refreshArbitro();
        }

        private void radioButtonTodos_CheckedChanged(object sender, EventArgs e)
        {
            refreshUtilizadores();
        }
    }
}
