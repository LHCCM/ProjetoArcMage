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
    public partial class EditarJogoArbitroForm : Form
    {
        public EditarJogoArbitroForm()
        {
            InitializeComponent();
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            MenuArbitroForm menuarbitro = new MenuArbitroForm();
            menuarbitro.Show();
            this.Close();
        }
    }
}
