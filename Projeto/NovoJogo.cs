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

            comboBoxBaralho1.Items.Clear();
            comboBoxBaralho1.Items.AddRange(container.Deck.ToArray<Deck>());
            comboBoxBaralho2.Items.Clear();
            comboBoxBaralho2.Items.AddRange(container.Deck.ToArray<Deck>());
            comboBoxArbitro.Items.Clear();
            comboBoxArbitro.Items.AddRange(container.User.OfType<Referee>().ToArray());
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonCriar_Click(object sender, EventArgs e)
        {
            if (comboBoxEquipa1.SelectedIndex == -1 || comboBoxEquipa2.SelectedIndex == -1 || comboBoxArbitro.SelectedIndex == -1)
            {
                MessageBox.Show("Preencha as caixas de texto, Por Favor.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (comboBoxTorneios.SelectedIndex == -1)
            {
                result = MessageBox.Show("Não atribuio o jogo a um torneio, continuar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    if (radioButtonStandard.Checked == true)
                    {
                        string p1 = comboBoxEquipa1.SelectedValue.ToString();
                        string p2 = comboBoxEquipa2.SelectedItem.ToString();
                        string arb = comboBoxArbitro.SelectedItem.ToString();
                        string deck1 = comboBoxBaralho1.SelectedItem.ToString();
                        string deck2 = comboBoxBaralho2.SelectedItem.ToString();
                        string tor = comboBoxTorneios.SelectedItem.ToString();

                        DateTime date = dateTimePicker.Value;

                       /* NovoJogoStandard = new StandardGame()
                        {
                            Player1 = p1,
                            Player2 = p2,
                            Referee = arb,
                            Deck1 = deck1,
                            Deck2 = deck2,
                            Tournament = tor,
                            Date = date,

                        };
                        DialogResult = DialogResult.OK;
                        Close();*/
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
                        DialogResult = DialogResult.Yes;
                        Close();
                    }
                }
            }
        }

        private void radioButtonTeam_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxEquipa1.Items.Clear();
            comboBoxEquipa1.Items.AddRange(container.Team.ToArray<Team>());
            comboBoxEquipa2.Items.Clear();
            comboBoxEquipa2.Items.AddRange(container.Team.ToArray<Team>());
            labelEP1.Text = "Equipa 1";
            labelEP2.Text = "Equipa 2";

            comboBoxTorneios.Items.Clear();
            comboBoxTorneios.Items.AddRange(container.Tournament.OfType<TeamTournament>().ToArray());
        }

        private void radioButtonStandard_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxEquipa1.Items.Clear();
            comboBoxEquipa1.Items.AddRange(container.Player.ToArray<Player>());
            comboBoxEquipa2.Items.Clear();
            comboBoxEquipa2.Items.AddRange(container.Player.ToArray<Player>());
            labelEP1.Text = "Jogador 1";
            labelEP2.Text = "Jogador 2";

            comboBoxTorneios.Items.Clear();
            comboBoxTorneios.Items.AddRange(container.Tournament.OfType<StandardTournament>().ToArray());
        }
    }
}
