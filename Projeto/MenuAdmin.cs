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
    public partial class MenuAdmin : Form
    {
        public MenuAdmin()
        {
            InitializeComponent();
        }

        private void buttonTorneiosAdmin_Click(object sender, EventArgs e)
        {
            TorneioForm tourF = new TorneioForm();
            tourF.Show();
            this.Close();
        }

        private void buttonUtilizadoresAdmin_Click(object sender, EventArgs e)
        {
            UtilizadoresForm userF = new UtilizadoresForm();
            userF.Show();
            this.Close();

        }

        private void buttonEquipaJogadorAdmin_Click(object sender, EventArgs e)
        {
            GerirEquipasJogadores tpF = new GerirEquipasJogadores();
            tpF.Show();
            this.Close();
        }

        private void buttonBaralhosAdmin_Click(object sender, EventArgs e)
        {

        }

        private void buttonCartasAdmin_Click(object sender, EventArgs e)
        {

        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            FormLogin log = new FormLogin();
            log.Show();
            this.Close();
        }
    }
}
