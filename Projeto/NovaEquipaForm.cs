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
    public partial class NovaEquipaForm : Form
    {

        DBDiagramaContainer container = new DBDiagramaContainer();

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
                    NovaEquipaFunc();
                }
            }
            else
            {
                NovaEquipaFunc();
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

            if (listBoxEquipa.Items.Count <2)
            {
                listBoxEquipa.Items.Add(jogadorSelecionado.Nickname);
            }
            else
            {
                MessageBox.Show("Apenas 2 jogadores por equipa", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            int index = listBoxEquipa.SelectedIndex;
            if (index >= 0)
            {
                listBoxEquipa.Items.RemoveAt(index);
                return;
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
        }

        private void NovaEquipaFunc()
        {
            string nome = textBoxNome.Text.Trim();
            string p1 = listBoxEquipa.Items[0].ToString();
            string p2 = listBoxEquipa.Items[1].ToString();
            string avatar = textBoxAvatar.Text.Trim();

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
    }
}
