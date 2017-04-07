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
    public partial class MenuArbitroForm : Form
    {
        public MenuArbitroForm()
        {
            InitializeComponent();
        }

        private void buttonEditarJogo_Click(object sender, EventArgs e)
        {
            EditarJogoArbitroForm editjogo = new EditarJogoArbitroForm();
            editjogo.Show();
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
