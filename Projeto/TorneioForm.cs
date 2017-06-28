using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

            //torneios.GetType();
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
            else if(listBoxTorneio.SelectedItem.GetType() == typeof(StandardTournament))
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

        private void exportarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string filename = "";
                SaveFileDialog SaveHTML = new SaveFileDialog();
                SaveHTML.Filter = "HTML5 files|*.html";
                SaveHTML.FileName = "HtmlData.html";
                if (SaveHTML.ShowDialog() == DialogResult.OK)
                {
                    filename = SaveHTML.FileName;
                }
                using (StreamWriter writter = new StreamWriter(filename))
                {
                    StringBuilder builder = new StringBuilder();
                    builder.AppendFormat("<!-- HTML file");
                    builder.AppendFormat("<!DOCTYPE HTML>");
                    builder.AppendFormat("<html lang='pt'");
                    builder.AppendFormat("<head>");
                    builder.AppendFormat("<title> Torneios ArcMage</title>");
                    builder.AppendFormat("</head>");
                    builder.AppendFormat("<body>");
                    foreach (Tournament torneio in container.Tournament)
                    {
                        foreach (Game jogo in container.Game)
                        {
                            builder.AppendFormat("<h1>[0]</h1>", torneio.Nome.ToUpper());
                            builder.AppendFormat("<h3>[0]</h3>", torneio.Data.ToShortDateString());
                            builder.AppendFormat("<h3>[0]</h3>", torneio.Desc.ToUpper());
                            builder.AppendFormat("<table>");
                            builder.AppendFormat("<tr>");
                            builder.AppendFormat("<th> # </th>");
                            builder.AppendFormat("<th> Data </th>");
                            builder.AppendFormat("<th> Árbitro </th>");
                            builder.AppendFormat("<th> Equipa/Jogador </th>");
                            builder.AppendFormat("</tr>");
                            builder.AppendFormat("<tr>");
                            builder.AppendFormat("<td>[0]</td>", torneio.Id.ToString());
                            builder.AppendFormat("<td>[0]</td>", jogo.Date.ToShortDateString());
                            builder.AppendFormat("<td>[0]</td>", jogo.Referee);
                            builder.AppendFormat("<td>[0]</td>", jogo.P1 + " vs " + jogo.P2);
                            builder.AppendFormat("</tr>");
                        }
                    }
                    builder.AppendFormat("</body>");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocorreu um erro na exportação.");
            }
        }
    }
}
