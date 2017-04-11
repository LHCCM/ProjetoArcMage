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
    public partial class GerirEquipasJogadoresForm : Form
    {
        public GerirEquipasJogadoresForm()
        {
            InitializeComponent();
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            MenuAdminForm menuadmin = new MenuAdminForm();
            menuadmin.Show();
            this.Close();
        }

        private void buttonGerirEquipa_Click(object sender, EventArgs e)
        {
            GerirEquipasForm gerirE = new GerirEquipasForm();
            gerirE.Show();
            this.Close();
        }

        private void buttonGerirJogadores_Click(object sender, EventArgs e)
        {
            GerirJogadoresForm gerirJ = new GerirJogadoresForm();
            gerirJ.Show();
            this.Close();
        }
    }
}
