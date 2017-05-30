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
    public partial class TorneioForm : Form
    {
        DBDiagramaContainer container = new DBDiagramaContainer();

        List<Tournament> torneios = new List<Tournament>();

        public TorneioForm()
        {
            InitializeComponent();

            refreshTorneios();
            //refreshJogos();
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            MenuAdminForm menuadmin = new MenuAdminForm();
            menuadmin.Show();
            this.Close();
        }

        private void buttonNovoTorneio_Click(object sender, EventArgs e)
        {
            NovoTorneioForm form = new NovoTorneioForm();
            DialogResult result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                AdicionarTorneioStandard(form.NovoTorneioStandard);
            }
            else if (result == DialogResult.Yes)
            {
                AdicionarTorneioEquipas(form.NovoTorneioTeam);
            }

            refreshTorneios();
        }

        private void AdicionarTorneioStandard(StandardTournament torneio)
        {
            container.Tournament.Add(torneio);
            container.SaveChanges();
        }

        private void AdicionarTorneioEquipas(TeamTournament torneio)
        {
            container.Tournament.Add(torneio);
            container.SaveChanges();
        }

        private void refreshTorneios()
        {
            listBoxTorneio.Items.Clear();
            listBoxTorneio.Items.AddRange(container.Tournament.OfType<StandardTournament>().ToArray());
            listBoxTorneio.Items.AddRange(container.Tournament.OfType<TeamTournament>().ToArray());
        }

        private void buttonEditarTorneio_Click(object sender, EventArgs e)
        {
            EditarTorneioForm form = new EditarTorneioForm();
            DialogResult result = form.ShowDialog();

            Close();
        }

        private void buttonCriarJogo_Click(object sender, EventArgs e)
        {
            NovoJogoForm form = new NovoJogoForm();
            DialogResult result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                AdicionarJogoStandard(form.NovoJogoStandard);
            }
            else if (result == DialogResult.Yes)
            {
                AdicionarJogoEquipas(form.NovoJogoTeam);
            }

            //refreshJogos();
        }

        private void refreshJogos()
        {
            listBoxJogo.Items.Clear();
            listBoxJogo.Items.AddRange(container.Game.OfType<StandardGame>().ToArray());
            listBoxJogo.Items.AddRange(container.Game.OfType<TeamGame>().ToArray());
        }

        private void AdicionarJogoStandard(StandardGame jogo)
        {
            container.Game.Add(jogo);
            container.SaveChanges();
        }

        private void AdicionarJogoEquipas(TeamGame jogo)
        {
            container.Game.Add(jogo);
            container.SaveChanges();
        }

        private void buttonEditarJogo_Click(object sender, EventArgs e)
        {
            EditarJogo form = new EditarJogo();
            DialogResult result = form.ShowDialog();
        }

        private void buttonCancelarTorneio_Click(object sender, EventArgs e)
        {
            if (listBoxTorneio.SelectedIndex != -1)
            {
                container.Tournament.Remove((Tournament)listBoxTorneio.SelectedItem);
                container.SaveChanges();
            }

            refreshTorneios();
        }

        private void listBoxTorneio_SelectedIndexChanged(object sender, EventArgs e)
        {

            torneios.GetType();
            if (listBoxTorneio.SelectedItem.GetType() == typeof(TeamTournament))
            {
                TeamTournament team = (TeamTournament)listBoxTorneio.SelectedItem;

                if (team != null)
                {
                    
                    labelNome.Text = team.Nome;
                    labelDesc.Text = team.Desc;
                    labelData.Text = Convert.ToString(team.Data);
                }
            }
            else
            {
                StandardTournament solo = (StandardTournament)listBoxTorneio.SelectedItem;
                if (solo != null)
                {
                    labelNome.Text = solo.Nome;
                    labelDesc.Text = solo.Desc;
                    labelData.Text = Convert.ToString(solo.Data);
                }

            }
        }
    }
}
