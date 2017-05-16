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
    public partial class CriarCartaForm : Form
    {
        public Card NovaCarta { get; private set; }

        public CriarCartaForm()
        {
            InitializeComponent();
        }

        private void buttonVoltarCarta_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonConfirmarCarta_Click(object sender, EventArgs e)
        {
            if (textBoxNomeCarta.Text.Length == 0 || textBoxRegraCarta.Text.Length == 0)
            {
                MessageBox.Show("Preencha as caixas de texto, Por Favor.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (comboBoxTipoCarta.SelectedIndex == -1 || comboBoxFacao.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um Tipo/Fação para a carta, Por Favor.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                string nome = textBoxNomeCarta.Text.Trim();
                string regra = textBoxRegraCarta.Text.Trim();

                NovaCarta = new Card()
                {
                    Name = nome,
                    Rules = regra,

                    Atack = (int)numericUpDownAtaque.Value,
                    Defense = (int)numericUpDownDefesa.Value,
                    Cost = (int)numericUpDownCusto.Value,
                    Loyal = (int)numericUpDownLealdade.Value,
                    Faction = comboBoxFacao.SelectedItem.ToString(),
                    Type = comboBoxTipoCarta.SelectedItem.ToString()

                };
                DialogResult = DialogResult.OK;
                Close();
            }

        }
    }
}
