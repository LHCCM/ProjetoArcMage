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
    public partial class EditarJogadorForm : Form
    {
        DBDiagramaContainer container = new DBDiagramaContainer();

        string destinationpath = Path.GetDirectoryName(Application.ExecutablePath) + "\\Avatares";

        public EditarJogadorForm()
        {
            InitializeComponent();

            refreshJogadores();
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            GerirJogadoresForm form = new GerirJogadoresForm();
            form.Show();

            Close();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            Player jogadorSelecionado = (Player)listBoxJogadores.SelectedItem;

            if (jogadorSelecionado != null)
            {
                DialogResult result = MessageBox.Show("Tem a certeza que deseja guardar as alterações?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    if (textBoxEmail.Text == "" && textBoxNick.Text == "")
                    {
                        MessageBox.Show("Caixa de texto em branco. Preencha a caixa por favor. ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    else
                    {
                        string filename = Path.GetFileName(openFileDialog1.FileName);

                        string nome = textBoxNome.Text.Trim();
                        string nick = textBoxNick.Text.Trim();
                        string email = textBoxEmail.Text.Trim();
                        string avatar = Path.Combine(destinationpath, filename);

                        jogadorSelecionado.Name = nome;
                        jogadorSelecionado.Nickname = nick;
                        jogadorSelecionado.Email = email;

                        jogadorSelecionado.Age = (int)numericUpDownIdade.Value;
                        jogadorSelecionado.Avatar = avatar;

                        container.SaveChanges();
                    }
                }

            }

            else
            {
                MessageBox.Show("Nenhum jogador selecionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
    

        private void refreshJogadores()
        {
            listBoxJogadores.Items.Clear();
            listBoxJogadores.Items.AddRange(container.Player.ToArray<Player>());
        }

        private void listBoxJogadores_SelectedIndexChanged(object sender, EventArgs e)
        {
            Player jogadorSelecionado = (Player)listBoxJogadores.SelectedItem;

            if (jogadorSelecionado != null)
            {
                if (jogadorSelecionado.Avatar != "")
                {
                    Image imagem = new Bitmap(jogadorSelecionado.Avatar);

                    pictureBox1.Image = new Bitmap(imagem, new Size(153, 132));
                }
                else
                {
                    pictureBox1.Image = Properties.Resources.noavatar;
                }

                labelID.Text = Convert.ToString(jogadorSelecionado.Id);
                textBoxNome.Text = jogadorSelecionado.Name;
                textBoxEmail.Text = jogadorSelecionado.Email;
                textBoxNick.Text = jogadorSelecionado.Nickname;
                numericUpDownIdade.Text = Convert.ToString(jogadorSelecionado.Age);
                textBoxAvatar.Text = jogadorSelecionado.Avatar;
            }
        }
    }
}
