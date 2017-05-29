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
    public partial class EditarBaralhoForm : Form
    {
        DBDiagramaContainer container = new DBDiagramaContainer();
        public EditarBaralhoForm()
        {
            InitializeComponent();
            refreshCartas();
            refreshBaralhos();
        }
        private void refreshBaralhos()
        {
            listBoxBaralhos.Items.Clear();
            listBoxBaralhos.Items.AddRange(container.Deck.ToArray<Deck>());
        }
        private void refreshCartas()
        {
            listBoxTotalCartas.Items.Clear();
            listBoxTotalCartas.Items.AddRange(container.Card.ToArray<Card>());
        }
        private void refreshCartasBaralho()
        {
            Deck deck = (Deck)listBoxBaralhos.SelectedItem;
            listBoxCartasBaralho.Items.Clear();
            listBoxCartasBaralho.Items.AddRange(deck.Card.ToArray<Card>());
        }
        private void textBoxProcura_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string myString = textBoxProcura.Text;
            int index = listBoxTotalCartas.FindString(myString, -1);
            if (index != -1)
            {
                listBoxTotalCartas.SetSelected(index, true);
            }
            else
                MessageBox.Show("Baralho Inexistente.");
        }

        private void buttonAdicionarCartaBaralho_Click(object sender, EventArgs e)
        {
            Card CartaSelecionada = (Card)listBoxTotalCartas.SelectedItem;
            listBoxCartasBaralho.Items.Add(CartaSelecionada.Name);
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            int i = 0;
            Deck deck = (Deck)listBoxBaralhos.SelectedItem;
            do
            {
                Card DeckCard = (Card)listBoxCartasBaralho.Items[i];
                deck.Card.Add(DeckCard);
                i++;
            } while (i < listBoxCartasBaralho.Items.Count);
        }

        private void EditarBaralhoForm_Load(object sender, EventArgs e)
        {

        }

        private void listBoxCartasBaralho_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBoxCartasBaralho.SelectedIndex != 0)
            {
                buttonRemoverCartaBaralho.Enabled = true;
            }
        }

        private void buttonRemoverCartaBaralho_Click(object sender, EventArgs e)
        {
            container.Deck.Remove((Deck)listBoxCartasBaralho.SelectedItem);
            container.SaveChanges();
            refreshCartasBaralho();
        }

        private void listBoxTotalCartas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxTotalCartas.SelectedIndex != 0)
            {
                buttonAdicionarCartaBaralho.Enabled = true;
            }
        }

        private void listBoxBaralhos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBoxBaralhos != null)
            {
                refreshBaralhos();
            }
        }
    }
}
