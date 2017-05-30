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
    public partial class NovaEquipaForm : Form
    {

        DBDiagramaContainer container = new DBDiagramaContainer();

        string destinationpath = Path.GetDirectoryName(Application.ExecutablePath);

        public Player Jogador { get; private set; }
        public Team NovaEquipa { get; private set; }

        DialogResult result;

        public NovaEquipaForm()
        {
            InitializeComponent();

            refreshJogadores();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (textBoxNome.Text.Length == 0)
            {
                MessageBox.Show("Preencha o nome da equipa, por Favor.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (listBoxEquipa.Items.Count < 2)
            {
                MessageBox.Show("Uma equipa tem de ter 2 elementos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (listBoxEquipa.Items[0].ToString() == listBoxEquipa.Items[1].ToString())
            {
                MessageBox.Show("Jogador repetido, selecione um diferente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textBoxAvatar.Text.Length == 0)
            {
                result = MessageBox.Show("Não escolheu um avatar, continuar mesmo assim?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    string avatar = "";

                    NovaEquipaFunc(avatar);
                }
            }
            else
            {
                string filename = Path.GetFileName(openFileDialog1.FileName);
                string avatar = Path.Combine(destinationpath, filename);

                NovaEquipaFunc(avatar);
            }
        }

        private void refreshJogadores()
        {
            listBoxJogadores.Items.Clear();
            listBoxJogadores.Items.AddRange(container.Player.ToArray<Player>());
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            Player jogadorSelecionado = (Player)listBoxJogadores.SelectedItem;

            if (listBoxEquipa.Items.Count <2 && listBoxJogadores.SelectedItem != null)
            {
                listBoxEquipa.Items.Add(jogadorSelecionado.Nickname);
            }
            else if (listBoxEquipa.Items.Count == 2)
            {
                MessageBox.Show("Apenas 2 jogadores por equipa", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (listBoxJogadores.SelectedItem == null)
            {
                MessageBox.Show("Nenhum jogador selecionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (listBoxEquipa.SelectedItem != null)
            {
                listBoxEquipa.Items.RemoveAt(listBoxEquipa.SelectedIndex);
                return;
            }

            else
            {
                MessageBox.Show("Nenhum elemento selecionado para remover", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void NovaEquipaFunc(string avatar)
        {
            string nome = textBoxNome.Text.Trim();
            string p1 = listBoxEquipa.Items[0].ToString();
            string p2 = listBoxEquipa.Items[1].ToString();
            

            NovaEquipa = new Team()
            {
                Name = nome,
                Player1 = p1,
                Player2 = p2,
                Avatar = avatar,
            };
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonProcurar_Click(object sender, EventArgs e)
        {
            string myString = textBoxProcura.Text;
            int index = listBoxJogadores.FindString(myString, -1);
            if (index != -1)
            {
                listBoxJogadores.SetSelected(index, true);
            }
            else
                MessageBox.Show("Não encontrado");
        }
    }
}
