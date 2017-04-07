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
    public partial class UtilizadoresForm : Form
    {
        public UtilizadoresForm()
        {
            InitializeComponent();
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            MenuAdminForm menuadmin = new MenuAdminForm();
            menuadmin.Show();
            this.Close();
        }

        private void buttonNovoUser_Click(object sender, EventArgs e)
        {
            NovoUtilizadorForm userF = new NovoUtilizadorForm();
            userF.Show();
        }

        private void buttonEditUser_Click(object sender, EventArgs e)
        {
            
        }
    }
}
