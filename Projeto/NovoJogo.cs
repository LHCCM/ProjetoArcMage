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
            if (comboBoxEquipa1.SelectedIndex == -1 || comboBoxEquipa2.SelectedIndex == -1 || comboBoxArbitro.SelectedIndex == -1 || comboBoxTorneios.SelectedIndex == -1)
            {
                MessageBox.Show("Preencha as caixas de texto, Por Favor.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (radioButtonStandard.Checked)
            { 
                        string p1 = comboBoxEquipa1.SelectedItem.ToString();
                        string p2 = comboBoxEquipa2.SelectedItem.ToString();
                        string arb = comboBoxArbitro.SelectedItem.ToString();
                        string deck1 = comboBoxBaralho1.SelectedItem.ToString();
                        string deck2 = comboBoxBaralho2.SelectedItem.ToString();
                        string desc = textBoxDesc.Text.Trim();
                        string tor = comboBoxTorneios.SelectedItem.ToString();

                        DateTime date = dateTimePicker.Value;

                        NovoJogoStandard = new StandardGame()
                        {
                            P1 = p1,
                            P2 = p2,
                            Property1 = arb,
                            D1 = deck1,
                            D2 = deck2,
                            Tour = tor,
                            Date = date,
                            Description = desc,
                            Referee = null,
                            Deck1 = null,
                            Deck2 = null,
                            Tournament = null,
                            Player1 = null,
                            Player2 = null,

                        };
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                    else
                    {
                        string t1 = comboBoxEquipa1.SelectedItem.ToString();
                        string t2 = comboBoxEquipa2.SelectedItem.ToString();
                        string arb = comboBoxArbitro.SelectedItem.ToString();
                        string deck1 = comboBoxBaralho1.SelectedItem.ToString();
                        string deck2 = comboBoxBaralho2.SelectedItem.ToString();
                        string desc = textBoxDesc.Text.Trim();

                        string tor = comboBoxTorneios.SelectedItem.ToString();

                        DateTime date = dateTimePicker.Value;

                        NovoJogoTeam = new TeamGame()
                        {
                            P1 = t1,
                            P2 = t2,
                            Property1 = arb,
                            D1 = deck1,
                            D2 = deck2,
                            Tour = tor,
                            Date = date,
                            Description = desc,
                            Referee = null,
                            Deck1 = null,
                            Deck2 = null,
                            Tournament = null,
                            Team1 = null,
                            Team2 = null,
                        };
                        DialogResult = DialogResult.Yes;
                        Close();
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
