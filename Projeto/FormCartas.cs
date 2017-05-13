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
    public partial class CartasForm : Form
    {

        Model1Container container = new Model1Container();

        public CartasForm()
        {
            InitializeComponent();

            refreshCards();
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            MenuAdminForm menuadmin = new MenuAdminForm();
            menuadmin.Show();
            this.Close();
        }

        //Adicionar cartas à lista
        private void buttonAdicionarCarta_Click(object sender, EventArgs e)
        {
            CriarCartaForm form = new CriarCartaForm();
            DialogResult result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                AdicionarCarta(form.NovaCarta);
            }
            refreshCards();
        }

        private void AdicionarCarta(Card carta)
        {
            container.Card.Add(carta);
            container.SaveChanges();
        }

        private void refreshCards()
        {
            listBoxCartas.Items.Clear();
            listBoxCartas.Items.AddRange(container.Card.ToArray<Card>());
        }

        private void buttonEditarCarta_Click(object sender, EventArgs e)
        {

        }

        //dis no work 
        private void buttonApagarCarta_Click(object sender, EventArgs e)
        {
            if (listBoxCartas.SelectedIndex >= 0)
            {
                container.Card.Remove((Card)listBoxCartas.SelectedItem);
            }
            refreshCards();
        }

        //Mostrar informação do item selecionado
        private void listBoxCartas_SelectedIndexChanged(object sender, EventArgs e)
        {
            Card cartaSelecionada = (Card)listBoxCartas.SelectedItem;

            if (cartaSelecionada != null)
            {
                labelNome.Text = cartaSelecionada.Name;
                labelAtaque.Text = Convert.ToString(cartaSelecionada.Atack);
                labelDefesa.Text = Convert.ToString(cartaSelecionada.Defense);
                labelCusto.Text = Convert.ToString(cartaSelecionada.Cost);
                labelLeal.Text = Convert.ToString(cartaSelecionada.Loyal);
                labelRegras.Text = cartaSelecionada.Rules;
                labelFacao.Text = cartaSelecionada.Faction;
                labelTipo.Text = cartaSelecionada.Type;
            }
            refreshCards();
        }
    }
}
