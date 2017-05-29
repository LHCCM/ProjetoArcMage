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
    public partial class NovoJogoForm : Form
    {
        public StandardGame NovoJogoStandard { get; private set; }
        public TeamGame NovoJogoTeam { get; private set; }

        DBDiagramaContainer container = new DBDiagramaContainer();

        DialogResult result;

        public NovoJogoForm()
        {
            InitializeComponent();
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonCriar_Click(object sender, EventArgs e)
        {
            if (comboBoxEquipa1.SelectedIndex == -1 || comboBoxEquipa2.SelectedIndex == -1 || comboBoxArbitro.SelectedIndex == -1)
            {
                MessageBox.Show("Preencha as caixas de texto, Por Favor.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (comboBoxTorneios.SelectedIndex == -1)
            {
                MessageBox.Show("Não atribuio o jogo a um torneio, continuar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    if (radioButtonStandard.Checked == true)
                    {
                        string p1 = comboBoxEquipa1.SelectedItem.ToString();
                        string p2 = comboBoxEquipa2.SelectedItem.ToString();
                        string arb = comboBoxArbitro.SelectedItem.ToString();
                        string tor = comboBoxTorneios.SelectedItem.ToString();

                        DateTime date = dateTimePicker.Value;

                        NovoJogoStandard = new StandardGame()
                        {

                        };
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                    else if (radioButtonTeam.Checked == true)
                    {
                        string t1 = comboBoxEquipa1.SelectedItem.ToString();
                        string t2 = comboBoxEquipa2.SelectedItem.ToString();
                        string arb = comboBoxArbitro.SelectedItem.ToString();
                        string tor = comboBoxTorneios.SelectedItem.ToString();

                        DateTime date = dateTimePicker.Value;

                        NovoJogoTeam = new TeamGame()
                        {

                        };
                        DialogResult = DialogResult.Abort;
                        Close();
                    }
                }
            }
        }
    }
}
