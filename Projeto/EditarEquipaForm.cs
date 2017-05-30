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
    public partial class EditarEquipaForm : Form
    {
        DBDiagramaContainer container = new DBDiagramaContainer();

        string destinationpath = Path.GetDirectoryName(Application.ExecutablePath);

        public EditarEquipaForm()
        {
            InitializeComponent();

            refreshEquipas();
            refreshJogadores();
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            GerirEquipasForm form = new GerirEquipasForm();
            form.Show();

            Close();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            Team equipaSelecionada = (Team)listBoxEquipas.SelectedItem;

            if (equipaSelecionada != null)
            {
                DialogResult result = MessageBox.Show("Tem a certeza que deseja guardar as alterações?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {

                    if (listBoxEquipa.Items[0].ToString() == listBoxEquipa.Items[1].ToString())
                    {
                        MessageBox.Show("Jogador repetido, selecione um diferente", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    else
                    {
                        string filename = Path.GetFileName(openFileDialog1.FileName);

                        string p1 = listBoxEquipa.Items[0].ToString();
                        string p2 = listBoxEquipa.Items[1].ToString();
                        string avatar = Path.Combine(destinationpath, filename);

                        equipaSelecionada.Player1 = p1;
                        equipaSelecionada.Player2 = p2;
                        equipaSelecionada.Avatar = avatar;

                        container.SaveChanges();
                    }
                }
            }
            else
            {
                MessageBox.Show("Nenhuma equipa selecionada", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonProcurarJogador_Click(object sender, EventArgs e)
        {
            string myString = textBoxProcurarJogador.Text;
            int index = listBoxJogadores.FindString(myString, -1);
            if (index != -1)
            {
                listBoxJogadores.SetSelected(index, true);
            }
            else
                MessageBox.Show("Não encontrado");
        }

        private void buttonProcurarEquipa_Click(object sender, EventArgs e)
        {
            string myString = textBoxProcurarEquipa.Text;
            int index = listBoxEquipas.FindString(myString, -1);
            if (index != -1)
            {
                listBoxEquipas.SetSelected(index, true);
            }
            else
                MessageBox.Show("Não encontrado");
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            Player jogadorSelecionado = (Player)listBoxJogadores.SelectedItem;

            if (listBoxEquipa.Items.Count < 2 && listBoxJogadores.SelectedItem != null)
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

        private void refreshEquipas()
        {
            listBoxEquipas.Items.Clear();
            listBoxEquipas.Items.AddRange(container.Team.ToArray());
        }

        private void refreshJogadores()
        {
            listBoxJogadores.Items.Clear();
            listBoxJogadores.Items.AddRange(container.Player.ToArray<Player>());
        }

        private void listBoxEquipas_SelectedIndexChanged(object sender, EventArgs e)
        {
            Team equipaSelecionada = (Team)listBoxEquipas.SelectedItem;
            if (equipaSelecionada != null)
            {
                if (equipaSelecionada.Avatar != "")
                {
                    Image imagem = new Bitmap(equipaSelecionada.Avatar);
                    pictureBox1.Image = new Bitmap(imagem, new Size(153, 132));
                }
                else
                {
                    pictureBox1.Image = Properties.Resources.noavatar;
                }
                labelID.Text = Convert.ToString(equipaSelecionada.Id);
                textBoxNome.Text = equipaSelecionada.Name;
                listBoxEquipa.Items.Clear();
                listBoxEquipa.Items.Add(equipaSelecionada.Player1);
                listBoxEquipa.Items.Add(equipaSelecionada.Player2);
                textBoxAvatar.Text = equipaSelecionada.Avatar;
            }
        }
    }
}
