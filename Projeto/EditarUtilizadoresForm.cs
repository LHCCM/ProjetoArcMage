using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Projeto
{
    public partial class EditarUtilizadoresForm : Form
    {
        DBDiagramaContainer container = new DBDiagramaContainer();

        string destinationpath = @"C:\\Users\\User\\Source\\Repos\\ProjetoArcMage\\Avatares";

        DialogResult result;

        OpenFileDialog openFileDialog1 = new OpenFileDialog();

        public EditarUtilizadoresForm()
        {
            InitializeComponent();

            refreshUtilizadores();
        }

        private void buttonCancelar_Click_1(object sender, EventArgs e)
        {
            UtilizadoresForm form = new UtilizadoresForm();
            form.Show();
            Close();
        }

        private void listBoxAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxUsers.SelectedItem.GetType() == typeof(Administrator))
            {
                Administrator adminSelecionado = (Administrator)listBoxUsers.SelectedItem;
                if (adminSelecionado != null)
                {
                    labelEditarUtilizador.Text = "Editar Administrador";
                    textBoxNome.Text = adminSelecionado.Username;
                    textBoxEmail.Text = adminSelecionado.Email;
                    textBoxPassword.Text = adminSelecionado.Password;
                    labelEmail.Show();
                    textBoxEmail.Show();
                    textBoxNickname.Hide();
                    labelNickname.Hide();
                    pictureBox1.Hide();
                    label1.Hide();
                    buttonEscolherAvatar.Hide();
                    textBoxAvatar.Hide();

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
                    labelEditarUtilizador.Text = "Editar Árbitro";
                    pictureBox1.Show();
                    labelNickname.Show();
                    textBoxPassword.Text = utilizadorSelecionado.Password;
                    textBoxNickname.Text = utilizadorSelecionado.Name;
                    textBoxNome.Text = utilizadorSelecionado.Username;
                    buttonEscolherAvatar.Show();
                    textBoxNickname.Show();
                    labelEmail.Hide();
                    textBoxEmail.Hide();
                    textBoxAvatar.Show();
                    textBoxAvatar.Text = utilizadorSelecionado.Avatar;
                }
            }
        }

        private void refreshUtilizadores()
        {
            listBoxUsers.Items.Clear();
            listBoxUsers.Items.AddRange(container.User.OfType<Referee>().ToArray());
            listBoxUsers.Items.AddRange(container.User.OfType<Administrator>().ToArray());
        }

        private void buttonConfirmar_Click_1(object sender, EventArgs e)
        {
            if (listBoxUsers.SelectedIndex == null)
            {
                if (listBoxUsers.SelectedItem.GetType() == typeof(Administrator))
                {
                    Administrator adminSelecionado = (Administrator)listBoxUsers.SelectedItem;

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
                }
                else
                {
                    Referee arbitroselecionado = (Referee)listBoxUsers.SelectedItem;

                    if (arbitroselecionado != null)
                    {

                        result = MessageBox.Show("Tem a certeza que deseja guardar as alterações ? ", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (result == DialogResult.Yes)
                        {
                            string filename = Path.GetFileName(openFileDialog1.FileName);

                            arbitroselecionado.Avatar = Path.Combine(destinationpath, filename);
                            arbitroselecionado.Name = textBoxNickname.Text.Trim();

                            container.SaveChanges();
                        }

                    }
                }
            }
            else
            {
                MessageBox.Show("Nenhum Utilizador selecionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void buttonEscolherAvatar_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files(*.png, *.jpg) | *.png; *.jpg";
            openFileDialog1.FilterIndex = 1;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                this.textBoxAvatar.Text = openFileDialog1.FileName;
                Image imagem = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = new Bitmap(imagem, new Size(153, 132));
            }

            if (openFileDialog1.FileName != null)
            {
                //acessede apenas ao nome do ficheiro
                string filename = Path.GetFileName(openFileDialog1.FileName);

                //copia o ficheiro para uma pasta e faz overwrite se o ficheiro já exitir
                File.Copy(openFileDialog1.FileName, Path.Combine(destinationpath, filename), true);
            }
        }
    }
}
