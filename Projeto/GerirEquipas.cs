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
    public partial class GerirEquipasForm : Form
    {

        DBDiagramaContainer container = new DBDiagramaContainer();

        public GerirEquipasForm()
        {
            InitializeComponent();

            refreshEquipas();
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            GerirEquipasJogadoresForm gerirEJ = new GerirEquipasJogadoresForm();
            gerirEJ.Show();
            this.Close(); ;
        }

        private void buttonNovaEquipa_Click(object sender, EventArgs e)
        {
            NovaEquipaForm form = new NovaEquipaForm();
            DialogResult result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                AdicionarEquipa(form.NovaEquipa);
            }
            refreshEquipas();
        }

        private void buttonApagarEquipa_Click(object sender, EventArgs e)
        {
            if (listBoxEquipas.SelectedIndex >= 0)
            {
                container.Team.Remove((Team)listBoxEquipas.SelectedItem);
                container.SaveChanges();
            }

            refreshEquipas();
        }

        private void AdicionarEquipa(Team equipa)
        {
            container.Team.Add(equipa);
            container.SaveChanges();
        }

        private void refreshEquipas()
        {
            listBoxEquipas.Items.Clear();
            listBoxEquipas.Items.AddRange(container.Team.ToArray());
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
                labelNome.Text = equipaSelecionada.Name;
                labelP1.Text = equipaSelecionada.Player1;
                labelP2.Text = equipaSelecionada.Player2;
                
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            EditarEquipaForm form = new EditarEquipaForm();
            DialogResult result = form.ShowDialog();

            Close();
        }

        private void buttonProcurar_Click(object sender, EventArgs e)
        {
            string myString = textBoxProcura.Text;
            int index = listBoxEquipas.FindString(myString, -1);
            if (index != -1)
            {
                listBoxEquipas.SetSelected(index, true);
            }
            else
                MessageBox.Show("Não encontrado");
        }
    }
}
