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
    public partial class MenuAdminForm : Form
    {
        public MenuAdminForm()
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
            GerirEquipasJogadoresForm tpF = new GerirEquipasJogadoresForm();
            tpF.Show();
            this.Close();
        }

        private void buttonBaralhosAdmin_Click(object sender, EventArgs e)
        {
            BaralhosForm baralhosF = new BaralhosForm();
            baralhosF.Show();
            this.Close();
        }

        private void buttonCartasAdmin_Click(object sender, EventArgs e)
        {
            CartasForm cartasF = new CartasForm();
            cartasF.Show();
            this.Close();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            LoginForm log = new LoginForm();
            log.Show();
            this.Close();
        }
    }
}
