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
    public partial class FormEditarCartas : Form
    {
        DBDiagramaContainer container = new DBDiagramaContainer();

        DialogResult result;

        //private Card cartalSelecionada;

        public FormEditarCartas()
        {
            InitializeComponent();

            refreshCards();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            Card cartaSelecionada = (Card)listBoxCartas.SelectedItem;

            if (cartaSelecionada != null)
            {
                result = MessageBox.Show("Tem a certeza que deseja guardar as alterações?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    string regra = textBoxRegraCarta.Text.Trim();

                    cartaSelecionada.Rules = regra;
                    cartaSelecionada.Atack = (int)numericUpDownAtaque.Value;
                    cartaSelecionada.Defense = (int)numericUpDownDefesa.Value;
                    cartaSelecionada.Cost = (int)numericUpDownCusto.Value;
                    cartaSelecionada.Loyal = (int)numericUpDownLealdade.Value;
                    cartaSelecionada.Faction = comboBoxFacao.SelectedItem.ToString();
                    cartaSelecionada.Type = comboBoxTipoCarta.SelectedItem.ToString();

                    container.SaveChanges();
                }
                
            }

            else
            {
                MessageBox.Show("Nenhuma carta selecionada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void buttonVoltarCarta_Click(object sender, EventArgs e)
        {
            CartasForm form = new CartasForm();
            form.Show();

            Close();
        }

        private void refreshCards()
        {
            listBoxCartas.Items.Clear();
            listBoxCartas.Items.AddRange(container.Card.ToArray<Card>());
        }

        private void listBoxCartas_SelectedIndexChanged(object sender, EventArgs e)
        {
            Card cartaSelecionada = (Card)listBoxCartas.SelectedItem;

            if (cartaSelecionada != null)
            {
                textBoxNomeCarta.Text = cartaSelecionada.Name;
                numericUpDownAtaque.Text = Convert.ToString(cartaSelecionada.Atack);
                numericUpDownDefesa.Text = Convert.ToString(cartaSelecionada.Defense);
                numericUpDownCusto.Text = Convert.ToString(cartaSelecionada.Cost);
                numericUpDownLealdade.Text = Convert.ToString(cartaSelecionada.Loyal);
                textBoxRegraCarta.Text = cartaSelecionada.Rules;
                comboBoxFacao.Text = cartaSelecionada.Faction;
                comboBoxTipoCarta.Text = cartaSelecionada.Type;

            }

        }
    }
}
