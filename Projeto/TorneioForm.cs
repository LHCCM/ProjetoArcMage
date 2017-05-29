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

        public TorneioForm()
        {
            InitializeComponent();

            refreshTorneios();
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
            else if (result == DialogResult.Abort)
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
        }

        private void buttonCriarJogo_Click(object sender, EventArgs e)
        {
            NovoJogoForm form = new NovoJogoForm();
            DialogResult result = form.ShowDialog();
        }

        private void buttonEditarJogo_Click(object sender, EventArgs e)
        {
            EditarJogo form = new EditarJogo();
            DialogResult result = form.ShowDialog();
        }
    }
}
