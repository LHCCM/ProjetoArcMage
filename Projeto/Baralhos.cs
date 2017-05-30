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
    public partial class BaralhosForm : Form
    {
        DBDiagramaContainer container = new DBDiagramaContainer();

        public BaralhosForm()
        {
            InitializeComponent();
            refreshBaralhos();
        }
        private void refreshBaralhos()
        {
            listBoxBaralhos.Items.Clear();
            listBoxBaralhos.Items.AddRange(container.Deck.ToArray<Deck>());
        }
        private void refreshCartas()
        {
            listBoxListaCartas.Items.Clear();
            listBoxListaCartas.Items.AddRange(container.Card.ToArray<Card>());
        }
        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            MenuAdminForm menuadmin = new MenuAdminForm();
            menuadmin.Show();
            this.Close();
        }

        private void buttonAdicionarBaralho_Click(object sender, EventArgs e)
        {
            NovoBaralho NBaralho = new NovoBaralho();
            NBaralho.ShowDialog();
            refreshBaralhos();
        }

        private void listBoxBaralhos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBoxBaralhos.Items.Count > 0)
            {
                Deck deck = (Deck)listBoxBaralhos.SelectedItem;
                listBoxListaCartas.Items.Clear();
                listBoxListaCartas.Items.AddRange(deck.Card.ToArray<Card>());
                buttonApagarBaralho.Enabled = true;
                buttonEditarBaralho.Enabled = true;
            }
        }

        private void buttonApagarBaralho_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Tem acerteza que deseja apagar o baralho selecionado?", "Apagar baralho", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                container.Deck.Remove((Deck)listBoxBaralhos.SelectedItem);
                container.SaveChanges();
                refreshBaralhos();
            }
            
        }

        private void buttonEditarBaralho_Click(object sender, EventArgs e)
        {
            AussiliaryVars Aussi = new AussiliaryVars();
            Deck deck = (Deck)listBoxBaralhos.SelectedItem;
            Aussi.deck = deck;
            EditarBaralhoForm Open = new EditarBaralhoForm();
            Open.ShowDialog();
        }

        private void BaralhosForm_Load(object sender, EventArgs e)
        {
            refreshBaralhos();
        }
    }
}
